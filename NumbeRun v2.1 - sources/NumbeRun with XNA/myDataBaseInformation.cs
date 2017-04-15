using System;
using System.Collections.Generic;
using System.Text;

    public class myDataBaseInformation
    {
        // impostazioni di connessione al DB
        public string myHost = "127.0.0.1";
        //public string myHost = "http://83.176.19.244/";
        //public string myHost = "83.176.19.244";
        public string myDatabase = "postgres";
        public string myUser_ID = "postgres";
        public string myPassword = "marco153";

        // dichiara una variabile classe (la variabile è il DataBase)
        public myDataBase myDB = new myDataBase();
    }