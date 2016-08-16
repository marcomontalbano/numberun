using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// per il LocalIP
using System.Net;
using System.Net.Sockets;
// libreria Postgresql
using Npgsql;

    public class myDataBase
    {

        IDbConnection dbcon;        // variabile di connessione
        IDbCommand dbcmd;           // variabile di comando
        public IDataReader idrReader;  // variabile di lettura (pubblica, leggibile all'esterno
        public bool bStatoConnessione = false;
        public string sHost;
        public string sDatabase;
        public string sUser_ID;
        public string sPassword;

        // connette il DB tramite i campi richiesti
        public bool bConnettiDB(string sHost_cp, string sDatabase_cp, string sUser_ID_cp, string sPassword_cp)
        {
            // inizializza variabili classe
            sHost = sHost_cp;
            sDatabase = sDatabase_cp;
            sUser_ID = sUser_ID_cp;
            sPassword = sPassword_cp;
            // compone stringa per la connessione al DB
            string connectionString =
                "Server=" + sHost +
                ";Database=" + sDatabase +
                ";User ID=" + sUser_ID +
                ";Password=" + sPassword + ";";

            // connette al DB
            dbcon = new NpgsqlConnection(connectionString);
            try
            {
                dbcon.Open();
                bStatoConnessione = true;
            }
            catch
            {
                bStatoConnessione = false;
            }

            return bStatoConnessione;
        }

        // esegue una query, il cui risultato viene messo nella variabile 'reader'
        public bool bEseguiQuery(string sql)
        {
            if (bStatoConnessione == true)
            {
                dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = sql;
                idrReader = dbcmd.ExecuteReader();
            }
            if (idrReader != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // controlla se esiste un valore stabilito (stringa T-UPLA)
        public bool bTuplaEsistente(string sTabella, string sCampo, string sTupla)
        {
            string iNum = "";

            string sql = "SELECT COUNT(" + sCampo + ") FROM " + sTabella + " WHERE " + sCampo + "='" + sTupla + "'";
            if (this.bEseguiQuery(sql))
            {
                while (this.idrReader.Read())
                {
                    iNum = Convert.ToString(this.idrReader[0]);
                }
            }
            if (iNum == "0")
            {
                return false;
            } else
            {
                return true;
            }
        }

        // controlla se esiste un valore stabilito (intero T-UPLA)
        public bool bTuplaEsistente(string sTabella, string sCampo, int iTupla)
        {
            string iNum = "";

            string sql = "SELECT COUNT(" + sCampo + ") FROM " + sTabella + " WHERE " + sCampo + "=" + iTupla;
            if (this.bEseguiQuery(sql))
            {
                while (this.idrReader.Read())
                {
                    iNum = Convert.ToString(this.idrReader[0]);
                }
            }
            if (iNum == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // sconnette il DB, annullando le variabili
        public void vSconnettiDB()
        {
            idrReader.Close();
            idrReader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbcon.Close();
            dbcon = null;

            bStatoConnessione = false;
        }
    }
