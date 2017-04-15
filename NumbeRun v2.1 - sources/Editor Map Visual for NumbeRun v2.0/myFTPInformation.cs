using System;
using System.Collections.Generic;
using System.Text;

public class myFTPInformation
{
    // impostazioni di connessione al DB (libero)
    /*
    public string myHost = "ftp.digiland.it";
    public string myUsername = "space4dream";
    public string myPassword = "diana";

    public string myAddress = "http://digilander.libero.it/space4dream/";
    */

    // impostazioni di connessione al DB (altervista)
    public string myHost = "mmorpggameonline.altervista.org";
    public string myUsername = "mmorpggameonline";
    public string myPassword = "tupmoturte18";

    public string myAddress = "http://mmorpggameonline.altervista.org/";

    // classe contente le funzioni per un collegamento ad un server ftp
    public FtpClient myFTPserver = new FtpClient();

}