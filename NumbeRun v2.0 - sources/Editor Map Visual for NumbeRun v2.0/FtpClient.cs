using System;
using System.Net;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;

/*
 * FTP Client library in C#
 * Autore: Marco Montalbano
 * E-mail: marco153@hotmail.it
 */

    /// <summary>
    /// Classe utile per la connessione a un server FTP.
    /// </summary>
	public class FtpClient
	{
		public class FtpException : Exception
		{
			public FtpException(string message) : base(message){}
			public FtpException(string message, Exception innerException) : base(message,innerException){}
		}

        // ***
		private static int BUFFER_SIZE = 512;
		private static Encoding ASCII = Encoding.ASCII;

        // ***
		private bool verboseDebugging = false;
        
        // variabili per la connessione al server FTP.
		private string server = "localhost";
		private string remotePath = ".";
		private string username = "anonymous";
		private string password = "anonymous@anonymous.net";

        // ***
		private string message = null;
		private string result = null;

        // variabile contenente l'ultimo errore della connessione generato.
        private string sLastError = ".";

        // variabili per la connessione.
		private int port = 21;
		private int bytes = 0;
		private int resultCode = 0;
        private int timeoutSeconds = 10;

        /// <summary>
        /// Indica se l'oggetto è connesso o meno al server FTP.
        /// </summary>
		private bool bLoggedIn = false;

        // Variabile per la modalità binaria.
		private bool binMode = false;

        // ***
		private Byte[] buffer = new Byte[BUFFER_SIZE];
		private Socket clientSocket = null;


        /// <summary>
		/// Costruttore.
		/// </summary>
		public FtpClient()
		{

		}

		/// <summary>
        /// Costruttore.
		/// </summary>
		/// <param name="server">Indirizzo del server a cui connettersi.</param>
		/// <param name="username">Nome dell'utente.</param>
		/// <param name="password">Password dell'utente.</param>
		public FtpClient(string server, string username, string password)
		{
			this.server = server;
			this.username = username;
			this.password = password;
		}

		/// <summary>
		/// Costruttore.
		/// </summary>
        /// <param name="server">Indirizzo del server a cui connettersi.</param>
        /// <param name="username">Nome dell'utente.</param>
        /// <param name="password">Password dell'utente.</param>
		/// <param name="timeoutSeconds">Timeout (in secondi).</param>
		/// <param name="port">Numero della porta.</param>
		public FtpClient(string server, string username, string password, int timeoutSeconds, int port)
		{
			this.server = server;
			this.username = username;
			this.password = password;
			this.timeoutSeconds = timeoutSeconds;
			this.port = port;
		}

        /// <summary>
        /// Imposta i parametri per la connessione.
        /// </summary>
        /// <param name="server">Indirizzo del server a cui connettersi.</param>
        /// <param name="username">Nome dell'utente.</param>
        /// <param name="password">Password dell'utente.</param>
        public void SetFtpClient(string server, string username, string password)
        {
            this.server = server;
            this.username = username;
            this.password = password;
        }

        /// <summary>
        /// Riceve o imposta l'ultimo messaggio di log (per eventuale errore)
        /// </summary>
        public string LastError
        {
            get
            {
                return this.sLastError;
            }
        }

        /// <summary>
        /// Indica se l'oggetto è connesso o meno al server FTP.
        /// </summary>
        public bool bStatoConnessione
        {
            get
            {
                return this.bLoggedIn;
            }
        }

		/// <summary>
		/// Mostra tutte le comunicazioni del file di log
		/// </summary>
		public bool VerboseDebugging
		{
			get
			{
				return this.verboseDebugging;
			}
			set
			{
				this.verboseDebugging = value;
			}
		}

		/// <summary>
		/// Porta remota del server. Tipicamente TCP 21
		/// </summary>
		public int Port
		{
			get
			{
				return this.port;
			}
			set
			{
				this.port = value;
			}
		}

		/// <summary>
		/// Tempo di attesa per la risposta del server, in secondi.
		/// </summary>
		public int Timeout
		{
			get
			{
				return this.timeoutSeconds;
			}
			set
			{
				this.timeoutSeconds = value;
			}
		}

		/// <summary>
		/// Ricevi o imposta il nome del server FTP.
		/// </summary>
		/// <returns></returns>
		public string Server
		{
			get
			{
				return this.server;
			}
			set
			{
				this.server = value;
			}
		}

		/// <summary>
        /// Ricevi o imposta il numero della porta.
		/// </summary>
		/// <returns></returns>
		public int RemotePort
		{
			get
			{
				return this.port;
			}
			set
			{
				this.port = value;
			}
		}

		/// <summary>
        /// Ricevi o imposta la directory remota.
		/// </summary>
		public string RemotePath
		{
			get
			{
				return this.remotePath;
			}
			set
			{
				this.remotePath = value;
			}
		}

		/// <summary>
        /// Ricevi o imposta l'username.
		/// </summary>
		public string Username
		{
			get
			{
				return this.username;
			}
			set
			{
				this.username = value;
			}
		}

		/// <summary>
        /// Ricevi o imposta la password.
		/// </summary>
		public string Password
		{
			get
			{
				return this.password;
			}
			set
			{
				this.password = value;
			}
		}

		/// <summary>
        /// Se il valore è vero, imposta la modalità binaria per il downloads, altrimenti,
        /// per la modalità Ascii.
		/// </summary>
		public bool BinaryMode
		{
			get
			{
				return this.binMode;
			}
			set
			{
				if ( this.binMode == value ) return;

				if ( value )
					sendCommand("TYPE I");

				else
					sendCommand("TYPE A");

				if ( this.resultCode != 200 )
                {
                    this.sLastError = result.Substring(4);
                    throw new FtpException(result.Substring(4));
                }
			}
		}

		/// <summary>
		/// Effettua il login al server remoto.
		/// </summary>
		public void Login()
		{
            if (this.bLoggedIn)
            {
                this.Close();
            }

			Debug.WriteLine("Opening connection to " + this.server, "FtpClient" );

			IPAddress addr = null;
			IPEndPoint ep = null;

			try
			{
				this.clientSocket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
				addr = Dns.Resolve(this.server).AddressList[0];
				ep = new IPEndPoint( addr, this.port );
				this.clientSocket.Connect(ep);
			}
			catch(Exception ex)
			{
				// doubtfull
                if (this.clientSocket != null && this.clientSocket.Connected)
                {
                    this.clientSocket.Close();
                }
                this.sLastError = "Host sconosciuto";
				throw new FtpException("Couldn't connect to remote server",ex);
			}

			this.readResponse();

			if(this.resultCode != 220)
			{
				this.Close();
                this.sLastError = this.result.Substring(4);
				throw new FtpException(this.result.Substring(4));
			}

			this.sendCommand( "USER " + username );

			if( !(this.resultCode == 331 || this.resultCode == 230) )
			{
				this.cleanup();
                this.sLastError = this.result.Substring(4);
				throw new FtpException(this.result.Substring(4));
			}

			if( this.resultCode != 230 )
			{
				this.sendCommand( "PASS " + password );

				if( !(this.resultCode == 230 || this.resultCode == 202) )
				{
					this.cleanup();
                    this.sLastError = this.result.Substring(4);
					throw new FtpException(this.result.Substring(4));
				}
			}

			this.bLoggedIn = true;

			Debug.WriteLine( "Connected to " + this.server, "FtpClient" );

			this.ChangeDir(this.remotePath);
		}
		
		/// <summary>
		/// Chiudi la connessione al server.
		/// </summary>
		public void Close()
		{
			Debug.WriteLine("Closing connection to " + this.server, "FtpClient" );

			if( this.clientSocket != null )
			{
				this.sendCommand("QUIT");
			}

			this.cleanup();
		}

		/// <summary>
		/// Ritorna un array di stringhe, contenente la lista dei file della directory remota.
		/// </summary>
		/// <returns></returns>
		public string[] GetFileList()
		{
			return this.GetFileList("*.*");
		}

		/// <summary>
        /// Ritorna un array di stringhe, contenente la lista dei file della directory remota.
		/// </summary>
		/// <param name="mask"></param>
		/// <returns></returns>
		public string[] GetFileList(string mask)
		{
			if ( !this.bLoggedIn ) this.Login();

			Socket cSocket = createDataSocket();

			this.sendCommand("NLST " + mask);

            if (!(this.resultCode == 150 || this.resultCode == 125))
            {
                this.sLastError = this.result.Substring(4);
                throw new FtpException(this.result.Substring(4));
            }

			this.message = "";

			DateTime timeout = DateTime.Now.AddSeconds(this.timeoutSeconds);

			while( timeout > DateTime.Now )
			{
				int bytes = cSocket.Receive(buffer, buffer.Length, 0);
				this.message += ASCII.GetString(buffer, 0, bytes);

				if ( bytes < this.buffer.Length ) break;
			}

			string[] msg = this.message.Replace("\r","").Split('\n');

			cSocket.Close();

			if ( this.message.IndexOf( "No such file or directory" ) != -1 )
				msg = new string[]{};

			this.readResponse();

			if ( this.resultCode != 226 )
				msg = new string[]{};
			//	throw new FtpException(result.Substring(4));

			return msg;
		}
		
		/// <summary>
		/// Ritorna la grandezza di un file.
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public long GetFileSize(string fileName)
		{
			if ( !this.bLoggedIn ) this.Login();

			this.sendCommand("SIZE " + fileName);
			long size=0;

            if (this.resultCode == 213)
                size = long.Parse(this.result.Substring(4));

            else
            {
                this.sLastError = this.result.Substring(4);
                throw new FtpException(this.result.Substring(4));
            }

			return size;
		}
	
		/// <summary>
		/// Scarica un file nella cartella di Assembly.
		/// </summary>
		/// <param name="remFileName"></param>
		public void Download(string remFileName)
		{
			this.Download(remFileName,"",false);
		}

		/// <summary>
        /// Scarica un file nella cartella di Assembly, settando la flag 'resume'.
		/// </summary>
		/// <param name="remFileName"></param>
		/// <param name="resume"></param>
		public void Download(string remFileName,Boolean resume)
		{
			this.Download(remFileName,"",resume);
		}
		
		/// <summary>
		/// Scarica un file remoto, in una cartella su disco.
        /// Il nome del file locale sarà creato o sovrascritto, ma il percorso deve esistere.
		/// </summary>
		/// <param name="remFileName"></param>
		/// <param name="locFileName"></param>
		public void Download(string remFileName,string locFileName)
		{
			this.Download(remFileName,locFileName,false);
		}

        /// <summary>
        /// Variabile che indica se il file è stato scaricato dal server.
        /// </summary>
        private bool bDownloadVAR = false;
        /// <summary>
        /// Indica se il file è stato scaricato dal server o no ( Download() )
        /// </summary>
        public bool bDownload
        {
            get
            {
                return this.bDownloadVAR;
            }
        }
		/// <summary>
        /// Scarica un file remoto, in una cartella su disco, settando la flag 'resume'.
        /// Il nome del file locale sarà creato o sovrascritto, ma il percorso deve esistere.
		/// </summary>
		/// <param name="remFileName"></param>
		/// <param name="locFileName"></param>
		/// <param name="resume"></param>
		public void Download(string remFileName,string locFileName,Boolean resume)
		{
            this.bDownloadVAR = false;

			if ( !this.bLoggedIn ) this.Login();

			this.BinaryMode = true;

			Debug.WriteLine("Downloading file " + remFileName + " from " + server + "/" + remotePath, "FtpClient" );

			if (locFileName.Equals(""))
			{
				locFileName = remFileName;
			}

			FileStream output = null;

			if ( !File.Exists(locFileName) )
				output = File.Create(locFileName);

			else
				output = new FileStream(locFileName,FileMode.Open);

			Socket cSocket = createDataSocket();

			long offset = 0;

			if ( resume )
			{
				offset = output.Length;

				if ( offset > 0 )
				{
					this.sendCommand( "REST " + offset );
					if ( this.resultCode != 350 )
					{
						//Server dosnt support resuming
						offset = 0;
						Debug.WriteLine("Resuming not supported:" + result.Substring(4), "FtpClient" );
                    }
					else
					{
						Debug.WriteLine("Resuming at offset " + offset, "FtpClient" );
						output.Seek( offset, SeekOrigin.Begin );
					}
				}
			}

			this.sendCommand("RETR " + remFileName);

			if ( this.resultCode != 150 && this.resultCode != 125 )
			{
                this.bDownloadVAR = false;

                this.sLastError = this.result.Substring(4);
				throw new FtpException(this.result.Substring(4));
			}

			DateTime timeout = DateTime.Now.AddSeconds(this.timeoutSeconds);

			while ( timeout > DateTime.Now )
			{
				this.bytes = cSocket.Receive(buffer, buffer.Length, 0);
				output.Write(this.buffer,0,this.bytes);

				if ( this.bytes <= 0)
				{
					break;
				}
			}

			output.Close();

			if ( cSocket.Connected ) cSocket.Close();

			this.readResponse();

            if (this.resultCode != 226 && this.resultCode != 250)
            {
                this.bDownloadVAR = false;

                this.sLastError = this.result.Substring(4);
                throw new FtpException(this.result.Substring(4));
            }

            this.bDownloadVAR = true;
		}

        /// <summary>
        /// Variabile che indica se il file è stato caricato sul server.
        /// </summary>
        private bool bUploadVAR = false;
        /// <summary>
        /// Indica se il file è stato caricato sul server o no ( Upload() )
        /// </summary>
        public bool bUpload
        {
            get
            {
                return this.bUploadVAR;
            }
        }
		/// <summary>
		/// Upload un file.
		/// </summary>
		/// <param name="fileName"></param>
		public void Upload(string fileName)
		{
			this.Upload(fileName,false);
		}

		/// <summary>
		/// Upload un file e imposta la resume flag.
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="resume"></param>
		public void Upload(string fileName, bool resume)
		{
            this.bUploadVAR = false;

            if (!this.bLoggedIn)
            {
                this.Login();
            }
			Socket cSocket = null ;
			long offset = 0;

			if ( resume )
			{
				try
				{
					this.BinaryMode = true;

					offset = GetFileSize( Path.GetFileName(fileName) );
				}
				catch(Exception)
				{
					// file not exist
					offset = 0;
				}
			}

			// open stream to read file
			FileStream input = new FileStream(fileName,FileMode.Open);

			if ( resume && input.Length < offset )
			{
				// different file size
				Debug.WriteLine("Overwriting " + fileName, "FtpClient");
				offset = 0;
			}
			else if ( resume && input.Length == offset )
			{
				// file done
				input.Close();
				Debug.WriteLine("Skipping completed " + fileName + " - turn resume off to not detect.", "FtpClient");
                
                //
                this.bUploadVAR = false;
                //

                return;
			}

			// dont create untill we know that we need it
			cSocket = this.createDataSocket();

			if ( offset > 0 )
			{
				this.sendCommand( "REST " + offset );
				if ( this.resultCode != 350 )
				{
					Debug.WriteLine("Resuming not supported", "FtpClient");
					offset = 0;
				}
			}

			this.sendCommand( "STOR " + Path.GetFileName(fileName) );

            if (this.resultCode != 125 && this.resultCode != 150)
            {
                this.sLastError = result.Substring(4);
                this.bUploadVAR = false;
                throw new FtpException(result.Substring(4));
            }

			if ( offset != 0 )
			{
				Debug.WriteLine("Resuming at offset " + offset, "FtpClient" );

				input.Seek(offset,SeekOrigin.Begin);
			}

			Debug.WriteLine( "Uploading file " + fileName + " to " + remotePath, "FtpClient" );

			while ((bytes = input.Read(buffer,0,buffer.Length)) > 0)
			{
				cSocket.Send(buffer, bytes, 0);
			}
			
			input.Close();

			if (cSocket.Connected)
			{
				cSocket.Close();
			}

			this.readResponse();

            if (this.resultCode != 226 && this.resultCode != 250)
            {
                this.sLastError = this.result.Substring(4);
                this.bUploadVAR = false;
                throw new FtpException(this.result.Substring(4));
            }

            //
            this.bUploadVAR = true;
            //
		}
		
		/// <summary>
		/// Upload una directory e i files in essa contenuti
		/// </summary>
		/// <param name="path"></param>
		/// <param name="recurse">Whether to recurse sub directories</param>
		public void UploadDirectory(string path, bool recurse)
		{
			this.UploadDirectory(path,recurse,"*.*");
		}
		
		/// <summary>
        /// Upload una directory and i files in essa contenuti
		/// </summary>
		/// <param name="path"></param>
		/// <param name="recurse">Whether to recurse sub directories</param>
		/// <param name="mask">Only upload files of the given mask - everything is '*.*'</param>
		public void UploadDirectory(string path, bool recurse, string mask)
		{
			string[] dirs = path.Replace("/",@"\").Split('\\');
			string rootDir = dirs[ dirs.Length - 1 ];

			// make the root dir if it doed not exist
			if ( this.GetFileList(rootDir).Length < 1 ) this.MakeDir(rootDir);

			this.ChangeDir(rootDir);

			foreach ( string file in Directory.GetFiles(path,mask) )
			{
				this.Upload(file,true);
			}
			if ( recurse )
			{
				foreach ( string directory in Directory.GetDirectories(path) )
				{
					this.UploadDirectory(directory,recurse,mask);
				}
			}

			this.ChangeDir("..");
		}

        /// <summary>
        /// Variabile che indica se il file è stato eliminato
        /// </summary>
        private bool bDeleteFileVAR = false;
        /// <summary>
        /// Indica se il file è stato eliminato o no ( DeleteFile() )
        /// </summary>
        public bool bDeleteFile
        {
            get
            {
                return this.bDeleteFileVAR;
            }
        }
		/// <summary>
		/// Elimina un file da un server remoto FTP.
		/// </summary>
		/// <param name="fileName"></param>
		public void DeleteFile(string fileName)
		{
            this.bDeleteFileVAR = false;

			if ( !this.bLoggedIn ) this.Login();

			this.sendCommand( "DELE " + fileName );

            if (this.resultCode != 250)
            {
                this.sLastError = this.result.Substring(4);
                this.bDeleteFileVAR = false;
                throw new FtpException(this.result.Substring(4));
            }

            this.bDeleteFileVAR = true;
			Debug.WriteLine( "Deleted file " + fileName, "FtpClient" );
		}

        /// <summary>
        /// Variabile che indica se il file è stato rinominato
        /// </summary>
        private bool bRenameFileVAR = false;
        /// <summary>
        /// Indica se il file è stato rinominato o no ( RenameFile() )
        /// </summary>
        public bool bRenameFile
        {
            get
            {
                return this.bRenameFileVAR;
            }
        }
		/// <summary>
		/// Rinomina un file da un server remoto FTP.
		/// </summary>
		/// <param name="oldFileName"></param>
		/// <param name="newFileName"></param>
		/// <param name="overwrite">setting to false will throw exception if it exists</param>
        public void RenameFile(string oldFileName,string newFileName, bool overwrite)
		{
            this.bRenameFileVAR = false;

			if ( !this.bLoggedIn ) this.Login();

			this.sendCommand( "RNFR " + oldFileName );

            if (this.resultCode != 350)
            {
                this.sLastError = this.result.Substring(4);
                this.bRenameFileVAR = false;
                throw new FtpException(this.result.Substring(4));
            }

            if (!overwrite && this.GetFileList(newFileName).Length > 0)
            {
                this.sLastError = "File already exists";
                this.bRenameFileVAR = false;
                throw new FtpException("File already exists");
            }

			this.sendCommand( "RNTO " + newFileName );

            if (this.resultCode != 250)
            {
                this.sLastError = this.result.Substring(4);
                this.bRenameFileVAR = false;
                throw new FtpException(this.result.Substring(4));
            }

            this.bRenameFileVAR = true;
			Debug.WriteLine( "Renamed file " + oldFileName + " to " + newFileName, "FtpClient" );
		}

        /// <summary>
        /// Variabile che indica se la directory è stata cancellata
        /// </summary>
        private bool bRemoveDirVAR = false;
        /// <summary>
        /// Indica se la directory è stata cancellata o no ( RemoveDir() )
        /// </summary>
        public bool bRemoveDir
        {
            get
            {
                return this.bRemoveDirVAR;
            }
        }
        /// <summary>
        /// Elimina una directory da un server remoto FTP.
        /// </summary>
        /// <param name="dirName"></param>
        public void RemoveDir(string dirName)
        {
            this.bRemoveDirVAR = false;

            if (!this.bLoggedIn) this.Login();

            this.sendCommand("RMD " + dirName);

            if (this.resultCode != 250)
            {
                this.sLastError = this.result.Substring(4);
                this.bRemoveDirVAR = false;
                throw new FtpException(this.result.Substring(4));
            }

            this.bRemoveDirVAR = true;
            Debug.WriteLine("Removed directory " + dirName, "FtpClient");
        }

        /// <summary>
        /// Variabile che indica se la directory è stata creata
        /// </summary>
        private bool bMakeDirVAR = false;
        /// <summary>
        /// Indica se la directory è stata creata o no ( MakeDir() )
        /// </summary>
        public bool bMakeDir
        {
            get
            {
                return this.bMakeDirVAR;
            }
        }
		/// <summary>
		/// Crea una directory su un server remoto FTP.
		/// </summary>
		/// <param name="dirName"></param>
		public void MakeDir(string dirName)
		{
            this.bMakeDirVAR = false;

			if ( !this.bLoggedIn ) this.Login();

			this.sendCommand( "MKD " + dirName );

            if (this.resultCode != 250 && this.resultCode != 257)
            {
                this.sLastError = this.result.Substring(4);
                this.bMakeDirVAR = false;

                try
                {
                    RemoveDir(dirName);
                    MakeDir(dirName);
                } catch
                {
                    this.sLastError = this.result.Substring(4);
                    this.bMakeDirVAR = false;
                    throw new FtpException(this.result.Substring(4));
                }
               

            }

            this.bMakeDirVAR = true;
			Debug.WriteLine( "Created directory " + dirName, "FtpClient" );
		}

        /// <summary>
        /// Rinomina una directory da un server remoto FTP.
        /// </summary>
        /// <param name="OldDirName">Nome della cartella, sul server, da rinominare.</param>
        /// <param name="NewDirName">Nuovo nome che si vuole attribuire alla cartella.</param>
        public void RenameDir(string OldDirName, string NewDirName)
        {
            if (!this.bLoggedIn) this.Login();

            this.sendCommand("RNFR /" + OldDirName);

            if (this.resultCode != 350)
            {
                this.sLastError = this.result.Substring(4);
                throw new FtpException(this.result.Substring(4));
            }

            this.sendCommand("RNTO /" + NewDirName);

            if (this.resultCode != 250)
            {
                this.sLastError = this.result.Substring(4);
                throw new FtpException(this.result.Substring(4));
            }

            Debug.WriteLine("Renamed directory " + OldDirName + " to " + NewDirName, "FtpClient");
        }

        /// <summary>
        /// Variabile che indica se la directory è stata cambiata
        /// </summary>
        private bool bChangeDirVAR = false;
        /// <summary>
        /// Indica se la directory è stata cambiata o no ( ChangeDir() )
        /// </summary>
        public bool bChangeDir
        {
            get
            {
                return this.bChangeDirVAR;
            }
        }
		/// <summary>
		/// Change the current working directory on the remote FTP server.
		/// </summary>
		/// <param name="dirName"></param>
		public void ChangeDir(string dirName)
		{
            this.bChangeDirVAR = false;

			if( dirName == null || dirName.Equals(".") || dirName.Length == 0 )
			{
                this.bChangeDirVAR = false;
				return;
			}

			if ( !this.bLoggedIn ) this.Login();

			this.sendCommand( "CWD " + dirName );

            if (this.resultCode != 250)
            {
                this.sLastError = result.Substring(4);
                this.bChangeDirVAR = false;
                throw new FtpException(result.Substring(4));
            }

			this.sendCommand( "PWD" );

            if (this.resultCode != 257)
            {
                this.sLastError = result.Substring(4);
                this.bChangeDirVAR = false;
                throw new FtpException(result.Substring(4));
            }

			// gonna have to do better than this....
			this.remotePath = this.message.Split('"')[1];

            this.bChangeDirVAR = true;
			Debug.WriteLine( "Current directory is " + this.remotePath, "FtpClient" );
		}

		/// <summary>
		/// 
		/// </summary>
		private void readResponse()
		{
			this.message = "";
			this.result = this.readLine();

			if ( this.result.Length > 3 )
				this.resultCode = int.Parse( this.result.Substring(0,3) );
			else
				this.result = null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private string readLine()
		{
			while(true)
			{
				this.bytes = clientSocket.Receive( this.buffer, this.buffer.Length, 0 );
				this.message += ASCII.GetString( this.buffer, 0, this.bytes );

				if ( this.bytes < this.buffer.Length )
				{
					break;
				}
			}

			string[] msg = this.message.Split('\n');

			if ( this.message.Length > 2 )
				this.message = msg[ msg.Length - 2 ];

			else
				this.message = msg[0];


			if ( this.message.Length > 4 && !this.message.Substring(3,1).Equals(" ") ) return this.readLine();

			if ( this.verboseDebugging )
			{
				for(int i = 0; i < msg.Length - 1; i++)
				{
					Debug.Write( msg[i], "FtpClient" );
				}
			}

			return message;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="command"></param>
		private void sendCommand(String command)
		{
			if ( this.verboseDebugging ) Debug.WriteLine(command,"FtpClient");

			Byte[] cmdBytes = Encoding.ASCII.GetBytes( ( command + "\r\n" ).ToCharArray() );
			clientSocket.Send( cmdBytes, cmdBytes.Length, 0);
			this.readResponse();
		}

		/// <summary>
		/// when doing data transfers, we need to open another socket for it.
		/// </summary>
		/// <returns>Connected socket</returns>
		private Socket createDataSocket()
		{
			this.sendCommand("PASV");

            if (this.resultCode != 227)
            {
                this.sLastError = this.result.Substring(4);
                throw new FtpException(this.result.Substring(4));
            }

			int index1 = this.result.IndexOf('(');
			int index2 = this.result.IndexOf(')');

			string ipData = this.result.Substring(index1+1,index2-index1-1);

			int[] parts = new int[6];

			int len = ipData.Length;
			int partCount = 0;
			string buf="";

			for (int i = 0; i < len && partCount <= 6; i++)
			{
				char ch = char.Parse( ipData.Substring(i,1) );

				if ( char.IsDigit(ch) )
					buf+=ch;

                else if (ch != ',')
                {
                    this.sLastError = "Malformed PASV result: " + result;
                    throw new FtpException("Malformed PASV result: " + result);
                }

				if ( ch == ',' || i+1 == len )
				{
					try
					{
						parts[partCount++] = int.Parse(buf);
						buf = "";
					}
					catch (Exception ex)
					{
                        this.sLastError = "Malformed PASV result (not supported?): " + this.result;
						throw new FtpException("Malformed PASV result (not supported?): " + this.result, ex);
                    }
				}
			}

			string ipAddress = parts[0] + "."+ parts[1]+ "." + parts[2] + "." + parts[3];

			int port = (parts[4] << 8) + parts[5];

			Socket socket = null;
			IPEndPoint ep = null;

			try
			{
				socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
				ep = new IPEndPoint(Dns.Resolve(ipAddress).AddressList[0], port);
				socket.Connect(ep);
			}
			catch(Exception ex)
			{
				// doubtfull....
				if ( socket != null && socket.Connected ) socket.Close();

                this.sLastError = "Can't connect to remote server";
				throw new FtpException("Can't connect to remote server", ex);
			}

			return socket;
		}
		
		/// <summary>
		/// Always release those sockets.
		/// </summary>
		private void cleanup()
		{
			if ( this.clientSocket!=null )
			{
				this.clientSocket.Close();
				this.clientSocket = null;
			}
			this.bLoggedIn = false;
		}

		/// <summary>
		/// Destuctor
		/// </summary>
		~FtpClient()
		{
			this.cleanup();
		}


		/**************************************************************************************************************/
		#region Async methods (auto generated)

/*
				WinInetApi.FtpClient ftp = new WinInetApi.FtpClient();

				MethodInfo[] methods = ftp.GetType().GetMethods(BindingFlags.DeclaredOnly|BindingFlags.Instance|BindingFlags.Public);

				foreach ( MethodInfo method in methods )
				{
					string param = "";
					string values = "";
					foreach ( ParameterInfo i in  method.GetParameters() )
					{
						param += i.ParameterType.Name + " " + i.Name + ",";
						values += i.Name + ",";
					}
					

					Debug.WriteLine("private delegate " + method.ReturnType.Name + " " + method.Name + "Callback(" + param.TrimEnd(',') + ");");

					Debug.WriteLine("public System.IAsyncResult Begin" + method.Name + "( " + param + " System.AsyncCallback callback )");
					Debug.WriteLine("{");
					Debug.WriteLine("" + method.Name + "Callback ftpCallback = new " + method.Name + "Callback(" + values + " this." + method.Name + ");");
					Debug.WriteLine("return ftpCallback.BeginInvoke(callback, null);");
					Debug.WriteLine("}");
					Debug.WriteLine("public void End" + method.Name + "(System.IAsyncResult asyncResult)");
					Debug.WriteLine("{");
					Debug.WriteLine(method.Name + "Callback fc = (" + method.Name + "Callback) ((AsyncResult)asyncResult).AsyncDelegate;");
					Debug.WriteLine("fc.EndInvoke(asyncResult);");
					Debug.WriteLine("}");
					//Debug.WriteLine(method);
				}
*/


		private delegate void LoginCallback();
		public System.IAsyncResult BeginLogin(  System.AsyncCallback callback )
		{
			LoginCallback ftpCallback = new LoginCallback( this.Login);
			return ftpCallback.BeginInvoke(callback, null);
		}
		private delegate void CloseCallback();
		public System.IAsyncResult BeginClose(  System.AsyncCallback callback )
		{
			CloseCallback ftpCallback = new CloseCallback( this.Close);
			return ftpCallback.BeginInvoke(callback, null);
		}
		private delegate String[] GetFileListCallback();
		public System.IAsyncResult BeginGetFileList(  System.AsyncCallback callback )
		{
			GetFileListCallback ftpCallback = new GetFileListCallback( this.GetFileList);
			return ftpCallback.BeginInvoke(callback, null);
		}
		private delegate String[] GetFileListMaskCallback(String mask);
		public System.IAsyncResult BeginGetFileList( String mask, System.AsyncCallback callback )
		{
			GetFileListMaskCallback ftpCallback = new GetFileListMaskCallback(this.GetFileList);
			return ftpCallback.BeginInvoke(mask, callback, null);
		}
		private delegate Int64 GetFileSizeCallback(String fileName);
		public System.IAsyncResult BeginGetFileSize( String fileName, System.AsyncCallback callback )
		{
			GetFileSizeCallback ftpCallback = new GetFileSizeCallback(this.GetFileSize);
			return ftpCallback.BeginInvoke(fileName, callback, null);
		}
		private delegate void DownloadCallback(String remFileName);
		public System.IAsyncResult BeginDownload( String remFileName, System.AsyncCallback callback )
		{
			DownloadCallback ftpCallback = new DownloadCallback(this.Download);
			return ftpCallback.BeginInvoke(remFileName, callback, null);
		}
		private delegate void DownloadFileNameResumeCallback(String remFileName,Boolean resume);
		public System.IAsyncResult BeginDownload( String remFileName,Boolean resume, System.AsyncCallback callback )
		{
			DownloadFileNameResumeCallback ftpCallback = new DownloadFileNameResumeCallback(this.Download);
			return ftpCallback.BeginInvoke(remFileName, resume, callback, null);
		}
		private delegate void DownloadFileNameFileNameCallback(String remFileName,String locFileName);
		public System.IAsyncResult BeginDownload( String remFileName,String locFileName, System.AsyncCallback callback )
		{
			DownloadFileNameFileNameCallback ftpCallback = new DownloadFileNameFileNameCallback(this.Download);
			return ftpCallback.BeginInvoke(remFileName, locFileName, callback, null);
		}
		private delegate void DownloadFileNameFileNameResumeCallback(String remFileName,String locFileName,Boolean resume);
		public System.IAsyncResult BeginDownload( String remFileName,String locFileName,Boolean resume, System.AsyncCallback callback )
		{
			DownloadFileNameFileNameResumeCallback ftpCallback = new DownloadFileNameFileNameResumeCallback(this.Download);
			return ftpCallback.BeginInvoke(remFileName, locFileName, resume, callback, null);
		}
		private delegate void UploadCallback(String fileName);
		public System.IAsyncResult BeginUpload( String fileName, System.AsyncCallback callback )
		{
			UploadCallback ftpCallback = new UploadCallback(this.Upload);
			return ftpCallback.BeginInvoke(fileName, callback, null);
		}
		private delegate void UploadFileNameResumeCallback(String fileName,Boolean resume);
		public System.IAsyncResult BeginUpload( String fileName,Boolean resume, System.AsyncCallback callback )
		{
			UploadFileNameResumeCallback ftpCallback = new UploadFileNameResumeCallback(this.Upload);
			return ftpCallback.BeginInvoke(fileName, resume, callback, null);
		}
		private delegate void UploadDirectoryCallback(String path,Boolean recurse);
		public System.IAsyncResult BeginUploadDirectory( String path,Boolean recurse, System.AsyncCallback callback )
		{
			UploadDirectoryCallback ftpCallback = new UploadDirectoryCallback(this.UploadDirectory);
			return ftpCallback.BeginInvoke(path, recurse, callback, null);
		}
		private delegate void UploadDirectoryPathRecurseMaskCallback(String path,Boolean recurse,String mask);
		public System.IAsyncResult BeginUploadDirectory( String path,Boolean recurse,String mask, System.AsyncCallback callback )
		{
			UploadDirectoryPathRecurseMaskCallback ftpCallback = new UploadDirectoryPathRecurseMaskCallback(this.UploadDirectory);
			return ftpCallback.BeginInvoke(path, recurse, mask, callback, null);
		}
		private delegate void DeleteFileCallback(String fileName);
		public System.IAsyncResult BeginDeleteFile( String fileName, System.AsyncCallback callback )
		{
			DeleteFileCallback ftpCallback = new DeleteFileCallback(this.DeleteFile);
			return ftpCallback.BeginInvoke(fileName, callback, null);
		}
		private delegate void RenameFileCallback(String oldFileName,String newFileName,Boolean overwrite);
		public System.IAsyncResult BeginRenameFile( String oldFileName,String newFileName,Boolean overwrite, System.AsyncCallback callback )
		{
			RenameFileCallback ftpCallback = new RenameFileCallback(this.RenameFile);
			return ftpCallback.BeginInvoke(oldFileName, newFileName, overwrite, callback, null);
		}
		private delegate void MakeDirCallback(String dirName);
		public System.IAsyncResult BeginMakeDir( String dirName, System.AsyncCallback callback )
		{
			MakeDirCallback ftpCallback = new MakeDirCallback(this.MakeDir);
			return ftpCallback.BeginInvoke(dirName, callback, null);
		}
		private delegate void RemoveDirCallback(String dirName);
		public System.IAsyncResult BeginRemoveDir( String dirName, System.AsyncCallback callback )
		{
			RemoveDirCallback ftpCallback = new RemoveDirCallback(this.RemoveDir);
			return ftpCallback.BeginInvoke(dirName, callback, null);
		}
        private delegate void RenameDirCallback(String OldDirName, String NewDirName);
        public System.IAsyncResult BeginRenameDir(String OldDirName, String NewDirName, System.AsyncCallback callback)
		{
            RenameDirCallback ftpCallback = new RenameDirCallback(this.RenameDir);
            return ftpCallback.BeginInvoke(OldDirName, NewDirName, callback, null);
		}
		private delegate void ChangeDirCallback(String dirName);
		public System.IAsyncResult BeginChangeDir( String dirName, System.AsyncCallback callback )
		{
			ChangeDirCallback ftpCallback = new ChangeDirCallback(this.ChangeDir);
			return ftpCallback.BeginInvoke(dirName, callback, null);
		}

		#endregion
	}