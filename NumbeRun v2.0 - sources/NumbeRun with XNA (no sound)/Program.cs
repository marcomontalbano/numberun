using System;
using System.Windows.Forms;

namespace NumbeRun
{
    static class Program
    {
        static System.Threading.Mutex mMutex;
        /// <summary>
        /// Controlla se il processo è già in esecuzione
        /// </summary>
        /// <returns>TRUE -> è la prima volta che viene eseguita l'applicazione | FALSE -> il processo è già in esecuzione</returns>
        private static bool IsFirstTime()
        {

            bool newProcess;

            mMutex = new System.Threading.Mutex(true, "Applicazione Singleton", out newProcess);

            return newProcess;

        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {

            if (args.Length != 3)
            {
                MessageBox.Show("eseguire l'applicazione dal Launcher", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // controllo degli argomenti
                VariabiliGlobali.Globals.sNomeUtente = args[0];
                VariabiliGlobali.Globals.sPasswordUtente = args[1];
                VariabiliGlobali.Globals.sDataBaseIP = args[2];

                if (
                    (VariabiliGlobali.Globals.sNomeUtente == "#launchgame#") &&
                    (VariabiliGlobali.Globals.sPasswordUtente == "#launchgame#") &&
                    (VariabiliGlobali.Globals.sDataBaseIP == "#launchgame#")
                    )
                {
                    // Imposta la modalità del gioco off-line
                    VariabiliGlobali.Globals.bModOnLine = false;

                    using (Game1 game = new Game1())
                    {
                        game.Run();
                    }
                }
                else
                {
                    // Imposta la modalità del gioco on-line
                    VariabiliGlobali.Globals.bModOnLine = true;

                    if (VariabiliGlobali.Globals.myDBinformation.myDB.bConnettiDB(VariabiliGlobali.Globals.sDataBaseIP, VariabiliGlobali.Globals.myDBinformation.myDatabase, VariabiliGlobali.Globals.myDBinformation.myUser_ID, VariabiliGlobali.Globals.myDBinformation.myPassword))
                    {
                        // Imposta la modalità del gioco on-line
                        VariabiliGlobali.Globals.bModOnLine = true;

                        // seleziona utenti
                        string sql =
                            "SELECT TRIM(privilegio) FROM users_pwd WHERE users='" + VariabiliGlobali.Globals.sNomeUtente + "' and passwords='" + VariabiliGlobali.Globals.sPasswordUtente + "';";
                        // variabile che conterrà il privilegio dell'utente
                        string privilegio = null;
                        // esegue la query e inserisce nella variabile 'privilegio', il privilegio
                        // dell'utente che si vuole loggare.
                        if (VariabiliGlobali.Globals.myDBinformation.myDB.bEseguiQuery(sql))
                        {
                            while (VariabiliGlobali.Globals.myDBinformation.myDB.idrReader.Read())
                            {
                                privilegio = ((string)VariabiliGlobali.Globals.myDBinformation.myDB.idrReader[0]);   // mette nella variabile privilegio quello dell'utente
                            }
                        }

                        // controlla se l'USER e la PASSWORD inseriti, esistono
                        if (privilegio != null)
                        {
                            // Disconnette il DB
                            VariabiliGlobali.Globals.myDBinformation.myDB.vSconnettiDB();

                            using (Game1 game = new Game1())
                            {
                                game.Run();
                            }

                        }
                        else
                        {
                            MessageBox.Show("impossibile eseguire l'applicazione", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERRORE:\ndatabase non trovato; impossibile la connessione", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}

