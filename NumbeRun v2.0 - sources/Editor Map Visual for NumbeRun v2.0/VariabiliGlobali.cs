using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using EditorMaps;

namespace VariabiliGlobali
{
    public class Globals
    {
        public static bool VARcheckBox_eLiv1 = true;
        public static bool VARcheckBox_eLiv2 = true;
        public static bool VARcheckBox_mLiv1 = true;
        public static bool VARcheckBox_mLiv2 = true;

        //public static myFTPInformation myFTPinfo = new myFTPInformation();

        public static bool bCaricamentoOnLine = false;

        /// <summary>
        /// Immagine della mappa - Form1
        /// </summary>
        public static PictureBox _PictureBox = new PictureBox();

        /// <summary>
        /// Stampa la mappa del gioco in un thread separato
        /// </summary>
        public static void vStampaMatrice()
        {
            BackgroundWorker _BackgroundWorker = new BackgroundWorker();
            _BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(VariabiliGlobali.Globals.Form1.vStampaMatrice);
            _BackgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Value della progressBar1
        /// </summary>
        public static int iprogressBarF2Value = 0;

        /// <summary>
        /// Numero massimo della progressBar1
        /// </summary>
        public static int iprogressBarF2Max = 1;

        /// <summary>
        /// Gestisce il testo scritto nella Label della Form2
        /// </summary>
        public static string sProgressLabelText = "";

        /// <summary>
        /// Variabile di controllo, se true viene generata una mappa vuota
        /// </summary>
        public static bool bNuovaMappa = false;

        /// <summary>
        /// Variabile di controllo, se true viene stampata tutta la matrice a video
        /// </summary>
        public static bool bStampaMatrice = false;

        public static Collisioni MyCollisioni = new Collisioni();

        /// <summary>
        /// Grandezza di defaul delle immagini
        /// </summary>
        public static int iGrandezzaImmagini = 16;

        /// <summary>
        ///  ID dell'oggetto selezionato
        /// </summary>
        public static int iIdOggettoSelezionato = 0;

        /// <summary>
        /// Form1
        /// </summary>
        public static Form1 Form1 = new Form1();
        /// <summary>
        /// Form2
        /// </summary>
        public static Form2 Form2 = new Form2();
        /// <summary>
        /// Form2
        /// </summary>
        public static Form3 Form3 = new Form3();
        /// <summary>
        /// Form4
        /// </summary>
        public static Form4 Form4 = new Form4();

        /// <summary>
        /// Indica la posizione della Scroll Bar orizzontale
        /// </summary>
        public static int iPosizioneSBorizzontale = 0;
        /// <summary>
        /// Indica la posizione della Scroll Bar verticale
        /// </summary>
        public static int iPosizioneSBverticale = 0; 

        /// <summary>
        /// Posizione del puntatore X nel tools
        /// </summary>
        public static int iNumeroImageX_tools = 0;
        /// <summary>
        /// Posizione del puntatore Y nel tools
        /// </summary>
        public static int iNumeroImageY_tools = 0;

        /// <summary>
        /// Posizione del puntatore X nell'editor
        /// </summary>
        public static int iNumeroImageX_editor = 0;
        /// <summary>
        /// Posizione del puntatore Y nell'editor
        /// </summary>
        public static int iNumeroImageY_editor = 0;

        /// <summary>
        /// Contiene tutte le matrici per la costruzione della mappa
        /// </summary>
        public static Maps MyMaps = new Maps();
    }
}
