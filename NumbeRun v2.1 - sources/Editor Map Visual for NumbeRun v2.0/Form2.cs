using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

namespace EditorMaps
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controlla se l'oggetto su cui si è cliccato è utilizzabile
        /// </summary>
        /// <returns></returns>
        public bool bControllaPossibilitaDiSelezione()
        {
            if (
                // BIANCO
                (vControllaIdOggetto() != 1) &&

                // MOSTRI
                (vControllaIdOggetto() != 2) &&
                (vControllaIdOggetto() != 3) &&
                (vControllaIdOggetto() != 4) &&
                (vControllaIdOggetto() != 5) &&
                (vControllaIdOggetto() != 6) &&
                (vControllaIdOggetto() != 7) &&
                (vControllaIdOggetto() != 8) &&
                (vControllaIdOggetto() != 9) &&
                (vControllaIdOggetto() != 10) &&
                (vControllaIdOggetto() != 11) &&

                // ANIMAZIONE ACQUA
                (vControllaIdOggetto() != 25) &&
                (vControllaIdOggetto() != 26) &&
                (vControllaIdOggetto() != 27) &&

                // ANIMAZIONE MARE
                (vControllaIdOggetto() != 97) &&
                (vControllaIdOggetto() != 98) &&

                // ANIMAZIONE FUOCO
                (vControllaIdOggetto() != 41) &&
                (vControllaIdOggetto() != 42) &&
                (vControllaIdOggetto() != 43)

                )
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// stampa sulla matrice un oggetto selezionato
        /// </summary>
        /// <param name="bAggiornaTerreno"></param>
        public void vSelezionaOggetto(bool bAggiornaTerreno)
        {
            if ( bControllaPossibilitaDiSelezione() )
            {
                groupBox_ChipSet.Text = "ChipSet - selezionato: SI";

                // Immagine completa
                Bitmap _bitmap1 = new Bitmap(pictureBox_ChipSet.Image);
                // Immagine selezionata
                Bitmap _bitmap2 = new Bitmap(VariabiliGlobali.Globals.iGrandezzaImmagini, VariabiliGlobali.Globals.iGrandezzaImmagini);
                // Copia l'immagine selezionata in _bitmap2
                for (int i = 0; i < VariabiliGlobali.Globals.iGrandezzaImmagini; i++)
                    for (int j = 0; j < VariabiliGlobali.Globals.iGrandezzaImmagini; j++)
                        _bitmap2.SetPixel(i, j, _bitmap1.GetPixel(i + (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageX_tools), j + (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageY_tools)));

                // La 'pictureBox_Selezione' prende come immagine l'oggetto scelto.
                pictureBox_Selezione.Image = _bitmap2;

                // Stampa oggetti in matrice
                if (bAggiornaTerreno == true)
                {
                    VariabiliGlobali.Globals.iIdOggettoSelezionato = vControllaIdOggetto();

                }
                else
                    if (VariabiliGlobali.Globals.MyCollisioni.iStampaOggetti[VariabiliGlobali.Globals.iNumeroImageY_tools, VariabiliGlobali.Globals.iNumeroImageX_tools] == 0)
                    {
                        VariabiliGlobali.Globals.MyCollisioni.iStampaOggetti[VariabiliGlobali.Globals.iNumeroImageY_tools, VariabiliGlobali.Globals.iNumeroImageX_tools] = 1;
                    }
                    else
                    {
                        VariabiliGlobali.Globals.MyCollisioni.iStampaOggetti[VariabiliGlobali.Globals.iNumeroImageY_tools, VariabiliGlobali.Globals.iNumeroImageX_tools] = 0;
                    }
            }
        }

        /// <summary>
        /// Dato un un numero, controlla l'esistenza e restituisce l'immagine dell'oggetto corrispondente
        /// </summary>
        /// <returns></returns>
        public bool vControllaIdOggetto(int iNumero)
        {
            int iContatore = -1;

            for (int i = 0; i < VariabiliGlobali.Globals.MyCollisioni.TileSetYCount; i++)
                for (int j = 0; j < VariabiliGlobali.Globals.MyCollisioni.TileSetXCount; j++)
                {
                    iContatore++;
                    if (iContatore == iNumero)
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = j;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = i;
                        return true;
                    }
                }

            return false;
        }

        /// <summary>
        /// torna il numero del chipset selezionato
        /// </summary>
        /// <returns></returns>
        public int vControllaIdOggetto()
        {
            int iContatore = -1;

            for (int i = 0; i < VariabiliGlobali.Globals.MyCollisioni.TileSetYCount; i++)
                for (int j = 0; j < VariabiliGlobali.Globals.MyCollisioni.TileSetXCount; j++)
                {
                    iContatore++;
                    if (i == VariabiliGlobali.Globals.iNumeroImageY_tools)
                        if (j == VariabiliGlobali.Globals.iNumeroImageX_tools)
                            return iContatore;    
                }

            return iContatore;
        }

        private void pictureBox_ChipSet_MouseMove(object sender, MouseEventArgs e)
        {
            // Imposta la cordinata del mirino X
            pictureBox_Mirino.Left = pictureBox_ChipSet.Left + (VariabiliGlobali.Globals.iGrandezzaImmagini * (e.X / VariabiliGlobali.Globals.iGrandezzaImmagini)) + ((VariabiliGlobali.Globals.iGrandezzaImmagini / 2) - (6 / 2));
            // Imposta la cordinata del mirino Y
            pictureBox_Mirino.Top = pictureBox_ChipSet.Top + (VariabiliGlobali.Globals.iGrandezzaImmagini * (e.Y / VariabiliGlobali.Globals.iGrandezzaImmagini)) + ((VariabiliGlobali.Globals.iGrandezzaImmagini / 2) - (6 / 2));
            // Imposta le variabili globali
            VariabiliGlobali.Globals.iNumeroImageX_tools = (e.X / VariabiliGlobali.Globals.iGrandezzaImmagini);
            VariabiliGlobali.Globals.iNumeroImageY_tools = (e.Y / VariabiliGlobali.Globals.iGrandezzaImmagini);
        }

        //caricamento form
        private void Form2_Load(object sender, EventArgs e)
        {
            // Disegna oggettini di visualizzazione e cancellazione livelli
            Bitmap _bitmapOLD1 = new Bitmap(global::EditorMaps.Properties.Resources.freccia1);
            Bitmap _bitmapNEW1 = new Bitmap(32, 32);
            Color _color = new Color();

            for (int i = 0; i < 32; i++)
                for (int j = 0; j < 32; j++)
                {
                    _color = _bitmapOLD1.GetPixel(i, j);
                    if (_color != Color.FromArgb(255, 255, 255, 255))
                    {
                        _bitmapNEW1.SetPixel(i, j, _color);
                    }
                }
            pictureBox_Mliv.Image = _bitmapNEW1;

            Bitmap _bitmapOLD2 = new Bitmap(global::EditorMaps.Properties.Resources.cestino);
            Bitmap _bitmapNEW2 = new Bitmap(32, 32);

            for (int i = 0; i < 32; i++)
                for (int j = 0; j < 32; j++)
                {
                    _color = _bitmapOLD2.GetPixel(i, j);
                    if (_color != Color.FromArgb(255, 255, 255, 255))
                    {
                        _bitmapNEW2.SetPixel(i, j, _color);
                    }
                }
            pictureBox_Eliv.Image = _bitmapNEW2;

            
            VariabiliGlobali.Globals.iIdOggettoSelezionato = 0;
            vSelezionaOggetto(false);

            // Controllo della matrice degli oggetti selezionati e stampa selezione
            vControllaSelezioneCHIPSET();
        }

        

        public void vFormDisable()
        {
            // FORM1
            VariabiliGlobali.Globals._PictureBox.Enabled = false;
            VariabiliGlobali.Globals.Form1.toolStrip1.Enabled = false;

            // FORM2
            UseWaitCursor = true;
            pictureBox_ChipSet.Enabled = false;
            checkBox_Personaggi.Enabled = false;
            VariabiliGlobali.Globals.VARcheckBox_eLiv1 = checkBox_eLiv1.Enabled;
            VariabiliGlobali.Globals.VARcheckBox_eLiv2 = checkBox_eLiv2.Enabled;
            VariabiliGlobali.Globals.VARcheckBox_mLiv1 = checkBox_mLiv1.Enabled;
            VariabiliGlobali.Globals.VARcheckBox_mLiv2 = checkBox_mLiv2.Enabled;
            checkBox_eLiv1.Enabled = false;
            checkBox_eLiv2.Enabled = false;
            checkBox_mLiv1.Enabled = false;
            checkBox_mLiv2.Enabled = false;
            button_Nuovo.Enabled = false;
            button_Apri.Enabled = false;
            button_Salva.Enabled = false;

            // FORM3
            VariabiliGlobali.Globals.Form3.comboBox1.Enabled = false;

            // FORM4
            VariabiliGlobali.Globals.Form4.comboBox1.Enabled = false;
            VariabiliGlobali.Globals.Form4.button1.Enabled = false;
            VariabiliGlobali.Globals.Form4.checkBox_Acqua.Enabled = false;

        }

        public void vFormEnable()
        {
            // FORM1
            VariabiliGlobali.Globals._PictureBox.Enabled = true;
            VariabiliGlobali.Globals.Form1.toolStrip1.Enabled = true;

            // FORM2
            UseWaitCursor = false;
            pictureBox_ChipSet.Enabled = true;
            checkBox_Personaggi.Enabled = true;
            checkBox_eLiv1.Enabled = VariabiliGlobali.Globals.VARcheckBox_eLiv1;
            checkBox_eLiv2.Enabled = VariabiliGlobali.Globals.VARcheckBox_eLiv2;
            checkBox_mLiv1.Enabled = VariabiliGlobali.Globals.VARcheckBox_mLiv1;
            checkBox_mLiv2.Enabled = VariabiliGlobali.Globals.VARcheckBox_mLiv2;
            button_Nuovo.Enabled = true;
            button_Apri.Enabled = true;
            button_Salva.Enabled = true;

            // FORM3
            VariabiliGlobali.Globals.Form3.comboBox1.Enabled = true;

            // FORM4
            VariabiliGlobali.Globals.Form4.comboBox1.Enabled = true;
            VariabiliGlobali.Globals.Form4.button1.Enabled = true;
            VariabiliGlobali.Globals.Form4.checkBox_Acqua.Enabled = true;

        }

        public void vSalvaFile()
        {
 
            //BackgroundWorker _BackgroundWorker = new BackgroundWorker();
            //_BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_Salva_DoWork);
            //_BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(backgroundWorker_WorkOK);
            
            // Salva il file di testo
            DialogResult _DialogResult = saveFileDialog1.ShowDialog();
            if (_DialogResult == DialogResult.OK)
            {
                timer_Apri.Enabled = true;
                vFormDisable();
                //_BackgroundWorker.RunWorkerAsync();
            }
        }
        /*
        private void backgroundWorker_WorkOK(object sender, RunWorkerCompletedEventArgs  e)
        {
            if (VariabiliGlobali.Globals.bCaricamentoOnLine == true)
            {
                // inizializza l'oggetto per la connessione al server FTP.
                VariabiliGlobali.Globals.myFTPinfo.myFTPserver.SetFtpClient(VariabiliGlobali.Globals.myFTPinfo.myHost, VariabiliGlobali.Globals.myFTPinfo.myUsername, VariabiliGlobali.Globals.myFTPinfo.myPassword);
                // connette l'oggetto al server FTP.
                VariabiliGlobali.Globals.myFTPinfo.myFTPserver.Login();

                VariabiliGlobali.Globals.myFTPinfo.myFTPserver.ChangeDir("/NumbeRun/maps");

                if (VariabiliGlobali.Globals.myFTPinfo.myFTPserver.bStatoConnessione)
                {

                    
                    string[] prova = VariabiliGlobali.Globals.myFTPinfo.myFTPserver.GetFileList();
                    bool bEsiste = false;
                    for (int i = 0; i < prova.Length; i++)
                    {
                        if (prova[i].Contains(System.IO.Path.GetFileName(saveFileDialog1.FileName)))
                        {
                            bEsiste = true;
                        }
                    }

                    if (bEsiste)
                    {
                        MessageBox.Show("Il file è già esistente. Prego cambiare nome", VariabiliGlobali.Globals.Form1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        VariabiliGlobali.Globals.myFTPinfo.myFTPserver.Upload(saveFileDialog1.FileName);
                        MessageBox.Show("L'upload è stato effettuato con successo", VariabiliGlobali.Globals.Form1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("ERRORE:\nimpossibile stabilire una connessione con il server FTP. Riprovare più tardi.", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                VariabiliGlobali.Globals.bCaricamentoOnLine = false;
            }
        }
        */
        private void button_Salva_Click(object sender, EventArgs e)
        {
            vSalvaFile();
        }

        //salvataggio delle matrici della mappa
        private void backgroundWorker_Salva_TODO()
        {
            VariabiliGlobali.Globals.iprogressBarF2Value = 0;
            VariabiliGlobali.Globals.iprogressBarF2Max = 0;

            VariabiliGlobali.Globals.sProgressLabelText = "Inizializzazione...";
            for (int h = 0; h < 5; h++)
                for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
                    for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                        VariabiliGlobali.Globals.iprogressBarF2Max++;


            // Nuova variabile di testo
            RichTextBox RTBtesto = new RichTextBox();
            string _testo = "";

            // iMap
            VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice sfondo";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    _testo = _testo + Convert.ToString(VariabiliGlobali.Globals.MyMaps.iMap[i, j]) + "|";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                    VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice sfondo - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                }
            }
            // iMapTrans
            VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice livello 1";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    _testo = _testo + Convert.ToString(VariabiliGlobali.Globals.MyMaps.iMapTrans[i, j]) + "|";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                    VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice livello 1 - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                }
            }
            // iMapObjects
            VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice personaggi";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    _testo = _testo + Convert.ToString(VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j]) + "|";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                    VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice personaggi - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                }
            }
            // iMapTrans2
            VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice livello 2";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    _testo = _testo + Convert.ToString(VariabiliGlobali.Globals.MyMaps.iMapTrans2[i, j]) + "|";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                    VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice livello 2 - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                }
            }
            // cMapWalkable
            VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice collisioni";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    _testo = _testo + Convert.ToString(VariabiliGlobali.Globals.MyMaps.cMapWalkable[i, j]) + "|";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                    VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio matrice collisioni - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                }
            }

            VariabiliGlobali.Globals.sProgressLabelText = "Salvataggio...";
            RTBtesto.AppendText(_testo);
            RTBtesto.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

            VariabiliGlobali.Globals.sProgressLabelText = "-";
            VariabiliGlobali.Globals.iprogressBarF2Value = progressBar1.Maximum;

        }

        public void vApriFile()
        {
            BackgroundWorker _BackgroundWorker = new BackgroundWorker();
            _BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_Apri_DoWork);

            DialogResult _DialogResult = openFileDialog1.ShowDialog();
            if (_DialogResult == DialogResult.OK)
            {
                saveFileDialog1.FileName = openFileDialog1.FileName;
                vGeneraNuovaMappa(false);
                timer_Apri.Enabled = true;
                _BackgroundWorker.RunWorkerAsync();
            }
        }

        private void button_Apri_Click(object sender, EventArgs e)
        {
            vApriFile();
        }

        //apertura mappe
        private void backgroundWorker_Apri_TODO()
        {
            VariabiliGlobali.Globals.iprogressBarF2Value = 0;
            //VariabiliGlobali.Globals.iprogressBarF2Max = 12936;
            VariabiliGlobali.Globals.iprogressBarF2Max = 16170;
            // Nuova variabile di testo
            RichTextBox RTBtesto = new RichTextBox();
            string[] sTesto;

            // Apre il file di testo
            VariabiliGlobali.Globals.sProgressLabelText = "Apertura file...";
            RTBtesto.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            sTesto = RTBtesto.Text.Split('|');

            // Variabile di indicazione
            int iIndicazione = -1;

            /*
             * DA TOGLIERE PER CONVERSIONE
            */
            
            // iMap
            VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice sfondo";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    iIndicazione++;
                    if (sTesto[iIndicazione] == "")
                        iIndicazione++;
                    VariabiliGlobali.Globals.MyMaps.iMap[i, j] = Convert.ToInt16(sTesto[iIndicazione]);
                    VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice sfondo - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                }
            }
        
            // iMapTrans
            VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice livello 1";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    iIndicazione++;
                    if (sTesto[iIndicazione] == "")
                        iIndicazione++;
                    VariabiliGlobali.Globals.MyMaps.iMapTrans[i, j] = Convert.ToInt16(sTesto[iIndicazione]);
                    VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice livello 1 - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                }
            }
            // iMapObjects
            VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice personaggi";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    iIndicazione++;
                    if (sTesto[iIndicazione] == "")
                        iIndicazione++;
                    VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] = Convert.ToInt16(sTesto[iIndicazione]);
                    VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice personaggi - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                }
            }
            // iMapTrans2
            VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice livello 2";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    iIndicazione++;
                    if (sTesto[iIndicazione] == "")
                        iIndicazione++;
                    VariabiliGlobali.Globals.MyMaps.iMapTrans2[i, j] = Convert.ToInt16(sTesto[iIndicazione]);
                    VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice livello 2 - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                }
            }
            // cMapWalkable
            VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice collisioni";
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    iIndicazione++;
                    if (sTesto[iIndicazione] == "")
                        iIndicazione++;
                    VariabiliGlobali.Globals.MyMaps.cMapWalkable[i, j] = Convert.ToChar(sTesto[iIndicazione]);
                    VariabiliGlobali.Globals.sProgressLabelText = "Lettura matrice collisioni - [" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                    VariabiliGlobali.Globals.iprogressBarF2Value++;
                }
            }

            //VariabiliGlobali.Globals.bStampaMatrice = true;
            VariabiliGlobali.Globals.vStampaMatrice();
            VariabiliGlobali.Globals.iprogressBarF2Value = progressBar1.Maximum;
            VariabiliGlobali.Globals.sProgressLabelText = "Visualizzazione in corso...";

        }

        private void backgroundWorker_Apri_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker_Apri_TODO();
        }

        private void timer_Apri_Tick(object sender, EventArgs e)
        {
            VariabiliGlobali.Globals.Form1.toolStripProgressBar1.Maximum = VariabiliGlobali.Globals.iprogressBarF2Max;
            progressBar1.Maximum = VariabiliGlobali.Globals.iprogressBarF2Max;
            VariabiliGlobali.Globals.Form1.toolStripProgressBar1.Value = VariabiliGlobali.Globals.iprogressBarF2Value;
            progressBar1.Value = VariabiliGlobali.Globals.iprogressBarF2Value;
            VariabiliGlobali.Globals.Form1.toolStripLabel3.Text = VariabiliGlobali.Globals.sProgressLabelText;
            label1.Text = VariabiliGlobali.Globals.sProgressLabelText;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                label1.Text = VariabiliGlobali.Globals.sProgressLabelText;
                VariabiliGlobali.Globals.iprogressBarF2Value = 0;
                VariabiliGlobali.Globals.Form1.toolStripProgressBar1.Value = VariabiliGlobali.Globals.iprogressBarF2Value;
                progressBar1.Value = VariabiliGlobali.Globals.iprogressBarF2Value;
                timer_Apri.Enabled = false;

                vFormEnable();
                
            }
        }

        //genera una nuova matrice
        public void vGeneraNuovaMappa(bool bStampaMatrice)
        {
            VariabiliGlobali.Globals.Form2.timer_Apri.Enabled = true;

            VariabiliGlobali.Globals.Form2.vFormDisable();

            // Inizializza le matrici
            VariabiliGlobali.Globals.sProgressLabelText = "Inizializzazione matrici...";
            for (int ii = 0; ii < VariabiliGlobali.Globals.MyMaps.MapHeight; ii++)
            {
                for (int jj = 0; jj < VariabiliGlobali.Globals.MyMaps.MapWidth; jj++)
                {
                    VariabiliGlobali.Globals.MyMaps.iMap[ii, jj] = VariabiliGlobali.Globals.MyMaps.iMapE[ii, jj];
                    VariabiliGlobali.Globals.MyMaps.iMapTrans[ii, jj] = VariabiliGlobali.Globals.MyMaps.iMapTransE[ii, jj];
                    VariabiliGlobali.Globals.MyMaps.iMapObjects[ii, jj] = VariabiliGlobali.Globals.MyMaps.iMapObjectsE[ii, jj];
                    VariabiliGlobali.Globals.MyMaps.iMapTrans2[ii, jj] = VariabiliGlobali.Globals.MyMaps.iMapTrans2E[ii, jj];
                    VariabiliGlobali.Globals.MyMaps.cMapWalkable[ii, jj] = VariabiliGlobali.Globals.MyMaps.cMapWalkableE[ii, jj];

                }
            }

            // Stampa le matrici a video
            VariabiliGlobali.Globals.sProgressLabelText = "Visualizzazione in corso...";
            if (bStampaMatrice == true)
                VariabiliGlobali.Globals.vStampaMatrice();
        }

        private void button_Nuovo_Click(object sender, EventArgs e)
        {
            vGeneraNuovaMappa(true);
        }

        private void backgroundWorker_Salva_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker_Salva_TODO();
        }

        private void Form2_Move(object sender, EventArgs e)
        {
            // Form3
            VariabiliGlobali.Globals.Form3.Left = VariabiliGlobali.Globals.Form2.Left;
            VariabiliGlobali.Globals.Form3.Top = VariabiliGlobali.Globals.Form2.Top + VariabiliGlobali.Globals.Form2.Height + 3;

            // Form4
            VariabiliGlobali.Globals.Form4.Left = VariabiliGlobali.Globals.Form2.Left;
            VariabiliGlobali.Globals.Form4.Top = VariabiliGlobali.Globals.Form3.Top + VariabiliGlobali.Globals.Form3.Height + 3;

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                VariabiliGlobali.Globals.Form2.Hide();
                e.Cancel = true;
            }
        }

        private void checkBox_Personaggi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Personaggi.Checked == true)
            {
                checkBox_eLiv1.Checked = false;
                checkBox_eLiv2.Checked = false;
                checkBox_eLiv1.Enabled = false;
                checkBox_eLiv2.Enabled = false;
            }
            else
            {
                checkBox_eLiv1.Enabled = true;
                checkBox_eLiv2.Enabled = true;
            }
        }

        /// <summary>
        /// controlla il chipset selezionato
        /// </summary>
        public void vControllaSelezioneCHIPSET()
        {
            for (int i = 0; i < VariabiliGlobali.Globals.MyCollisioni.TileSetYCount; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyCollisioni.TileSetXCount; j++)
                {
                    if (VariabiliGlobali.Globals.MyCollisioni.iStampaOggetti[i, j] == 1)
                    {
                        PictureBox _pictureBox = new PictureBox();
                        _pictureBox.Size = new Size(6, 6);
                        _pictureBox.Image = global::EditorMaps.Properties.Resources.mirino_grey;
                        _pictureBox.Name = "pictureBox_" + Convert.ToInt32(i) + "-" + Convert.ToInt32(j);
                        _pictureBox.Location = new Point(
                            j * VariabiliGlobali.Globals.iGrandezzaImmagini + pictureBox_ChipSet.Left + (VariabiliGlobali.Globals.iGrandezzaImmagini / 2 - 3),
                            i * VariabiliGlobali.Globals.iGrandezzaImmagini + pictureBox_ChipSet.Top + (VariabiliGlobali.Globals.iGrandezzaImmagini / 2 - 3));
                        _pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Mirino_MouseClick);
                        groupBox_ChipSet.Controls.Add(_pictureBox);

                        groupBox_ChipSet.Controls[_pictureBox.Name].BringToFront();
                    }
                    else
                        if (VariabiliGlobali.Globals.MyCollisioni.iStampaOggetti[i, j] == 0)
                        {
                            if (groupBox_ChipSet.Controls.Contains(groupBox_ChipSet.Controls["pictureBox_" + Convert.ToInt32(i) + "-" + Convert.ToInt32(j)]))
                            {
                                groupBox_ChipSet.Controls["pictureBox_" + Convert.ToInt32(i) + "-" + Convert.ToInt32(j)].Dispose();
                            }
                        }

                }
            }
        }

        //gestione eventi mouse sul chipset
        private void pictureBox_ChipSet_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                vSelezionaOggetto(false);
            }
            else
                if (e.Button == MouseButtons.Right)
                {
                    groupBox_ChipSet.Text = "ChipSet - selezionato: NO";
                    pictureBox_Selezione.Image = global::EditorMaps.Properties.Resources.vuoto__16x16_;
                    for (int i = 0; i < VariabiliGlobali.Globals.MyCollisioni.TileSetYCount; i++)
                    {
                        for (int j = 0; j < VariabiliGlobali.Globals.MyCollisioni.TileSetXCount; j++)
                        {
                            VariabiliGlobali.Globals.MyCollisioni.iStampaOggetti[i, j] = 0;
                        }
                    }
                }

            // Controllo della matrice degli oggetti selezionati e stampa selezione
            vControllaSelezioneCHIPSET();
        }

        private void pictureBox_Mirino_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                vSelezionaOggetto(false);
            }
            else
                if (e.Button == MouseButtons.Right)
                {
                    groupBox_ChipSet.Text = "ChipSet - selezionato: NO";
                    pictureBox_Selezione.Image = global::EditorMaps.Properties.Resources.vuoto__16x16_;
                    for (int i = 0; i < VariabiliGlobali.Globals.MyCollisioni.TileSetYCount; i++)
                    {
                        for (int j = 0; j < VariabiliGlobali.Globals.MyCollisioni.TileSetXCount; j++)
                        {
                            VariabiliGlobali.Globals.MyCollisioni.iStampaOggetti[i, j] = 0;
                        }
                    }
                }

            // Controllo della matrice degli oggetti selezionati e stampa selezione
            vControllaSelezioneCHIPSET();
        }

        private void checkBox_mLiv1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_mLiv2.Enabled = Convert.ToBoolean(1 - Convert.ToInt16(checkBox_mLiv1.Checked));

            VariabiliGlobali.Globals.Form2.vFormDisable();
            VariabiliGlobali.Globals.Form2.timer_Apri.Enabled = true;
            VariabiliGlobali.Globals.sProgressLabelText = "Aggiornamento livelli in corso...";
            VariabiliGlobali.Globals.vStampaMatrice();
        }

        private void checkBox_mLiv2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_mLiv1.Enabled = Convert.ToBoolean(1 - Convert.ToInt16(checkBox_mLiv2.Checked));

            VariabiliGlobali.Globals.Form2.vFormDisable();
            VariabiliGlobali.Globals.Form2.timer_Apri.Enabled = true;
            VariabiliGlobali.Globals.sProgressLabelText = "Aggiornamento livelli in corso...";
            VariabiliGlobali.Globals.vStampaMatrice();
        }
    }
}