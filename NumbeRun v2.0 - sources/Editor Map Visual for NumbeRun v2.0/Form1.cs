using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VariabiliGlobali;

namespace EditorMaps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// funzione che stampa la matrice della mappa
        /// </summary>
        public void vStampaMatrice(object sender, DoWorkEventArgs e)
        {
            //numero massimo della progressbar (altezza matrice*larghezza matrice)
            VariabiliGlobali.Globals.iprogressBarF2Max =
                VariabiliGlobali.Globals.MyMaps.MapHeight *
                VariabiliGlobali.Globals.MyMaps.MapWidth;

            //valore iniziale della progressabar
            VariabiliGlobali.Globals.iprogressBarF2Value = 0;

            //bitmap che contiene l'immagine del chipset
            Bitmap _bitmapSELEZIONE = new Bitmap(VariabiliGlobali.Globals.Form2.pictureBox_ChipSet.Image);
            //bitmap che contiene l'immagine della mappa
            Bitmap _bitmapNEW = new Bitmap(VariabiliGlobali.Globals._PictureBox.Image);
            Color _color = new Color();

            //ciclo di stampaggio
            for (int ii = 0; ii < VariabiliGlobali.Globals.MyMaps.MapHeight; ii++)
            {
                for (int jj = 0; jj < VariabiliGlobali.Globals.MyMaps.MapWidth; jj++)
                {
                    VariabiliGlobali.Globals.iprogressBarF2Value++;

                    //controllo del livello dell'oggetto in posizione ii,jj e gestione del colore
                    if (vControllaIdOggetto(VariabiliGlobali.Globals.MyMaps.iMap[ii, jj]))
                        {
                            for (int i = 0; i < VariabiliGlobali.Globals.iGrandezzaImmagini; i++)
                                for (int j = 0; j < VariabiliGlobali.Globals.iGrandezzaImmagini; j++)
                                {
                                    //controllo se il chipset relativo all'oggetto deve essere disegnato a colori o meno
                                    //la scelta viene gestita dalla prima riga dei checkbox
                                    _color = _bitmapSELEZIONE.GetPixel((VariabiliGlobali.Globals.iNumeroImageX_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + i, (VariabiliGlobali.Globals.iNumeroImageY_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + j);
                                    if (_color != Color.FromArgb(255, 255, 255, 255))
                                    {
                                        if ((VariabiliGlobali.Globals.Form2.checkBox_mLiv1.Checked == true) ||
                                            (VariabiliGlobali.Globals.Form2.checkBox_mLiv2.Checked == true))
                                        {
                                            int grayValue = (int)(0.299 * _color.R + 0.587 * _color.G + 0.114 * _color.B);
                                            _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * jj) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * ii) + j, Color.FromArgb(grayValue, grayValue, grayValue));
                                        } else
                                            _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * jj) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * ii) + j, _color);
                                    }
                                }
                        }

                    // Stampa LIVELLO1
                    //cerco l'oggetto sul chipset e cerco la posizione sulla mappa dove stampare l'oggetto
                    if ((vControllaIdOggetto(VariabiliGlobali.Globals.MyMaps.iMapTrans[ii, jj])) &&
                        (VariabiliGlobali.Globals.MyMaps.iMapTrans[ii, jj] != 001))
                    {
                        for (int i = 0; i < VariabiliGlobali.Globals.iGrandezzaImmagini; i++)
                            for (int j = 0; j < VariabiliGlobali.Globals.iGrandezzaImmagini; j++)
                            {
                                //gestione del colore: normale o in grigio
                                _color = _bitmapSELEZIONE.GetPixel((VariabiliGlobali.Globals.iNumeroImageX_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + i, (VariabiliGlobali.Globals.iNumeroImageY_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + j);
                                if (_color != Color.FromArgb(255, 255, 255, 255))
                                {
                                    if (VariabiliGlobali.Globals.Form2.checkBox_mLiv2.Checked == true)
                                    {
                                        int grayValue = (int)(0.299 * _color.R + 0.587 * _color.G + 0.114 * _color.B);
                                        _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * jj) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * ii) + j, Color.FromArgb(grayValue, grayValue, grayValue));
                                    }
                                    else
                                        _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * jj) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * ii) + j, _color);
                                }
                            }
                    }

                    // Stampa PERSONAGGI
                    //cerco il personaggio sulla lista dei personaggi e cerco la posizione dove stamparlo
                    _bitmapSELEZIONE = new Bitmap(VariabiliGlobali.Globals.Form3.imageList1.Images[VariabiliGlobali.Globals.MyMaps.iMapObjects[ii, jj]]);
                    if (VariabiliGlobali.Globals.MyMaps.iMapObjects[ii, jj] != 000)
                    {
                        for (int i = 0; i < VariabiliGlobali.Globals.iGrandezzaImmagini; i++)
                            for (int j = 0; j < VariabiliGlobali.Globals.iGrandezzaImmagini; j++)
                            {
                                //gestione del colore: normale o in grigio
                                _color = _bitmapSELEZIONE.GetPixel(i, j);
                                if (_color != Color.FromArgb(255, 255, 255, 255))
                                {
                                    if ((VariabiliGlobali.Globals.Form2.checkBox_mLiv1.Checked == true) ||
                                        (VariabiliGlobali.Globals.Form2.checkBox_mLiv2.Checked == true))
                                    {
                                        int grayValue = (int)(0.299 * _color.R + 0.587 * _color.G + 0.114 * _color.B);
                                        _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * jj) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * ii) + j, Color.FromArgb(grayValue, grayValue, grayValue));
                                    }
                                    else
                                        _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * jj) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * ii) + j, _color);
                                }
                            }
                    }

                    // Stampa LIVELLO2
                    //cerco l'oggetto sul chipset e cerco la posizione sulla mappa dove stampare l'oggetto
                    _bitmapSELEZIONE = new Bitmap(VariabiliGlobali.Globals.Form2.pictureBox_ChipSet.Image);
                    if ((vControllaIdOggetto(VariabiliGlobali.Globals.MyMaps.iMapTrans2[ii, jj])) &&
                        (VariabiliGlobali.Globals.MyMaps.iMapTrans2[ii, jj] != 001))
                    {
                        for (int i = 0; i < VariabiliGlobali.Globals.iGrandezzaImmagini; i++)
                            for (int j = 0; j < VariabiliGlobali.Globals.iGrandezzaImmagini; j++)
                            {
                                //gestione del colore: normale o in grigio
                                _color = _bitmapSELEZIONE.GetPixel((VariabiliGlobali.Globals.iNumeroImageX_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + i, (VariabiliGlobali.Globals.iNumeroImageY_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + j);
                                if (_color != Color.FromArgb(255, 255, 255, 255))
                                {
                                    if (VariabiliGlobali.Globals.Form2.checkBox_mLiv1.Checked == true)
                                    {
                                        int grayValue = (int)(0.299 * _color.R + 0.587 * _color.G + 0.114 * _color.B);
                                        _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * jj) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * ii) + j, Color.FromArgb(grayValue, grayValue, grayValue));
                                    }
                                    else
                                        _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * jj) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * ii) + j, _color);
                                }
                            }
                    }
                }
            }

            VariabiliGlobali.Globals.iprogressBarF2Value = VariabiliGlobali.Globals.iprogressBarF2Max;
            VariabiliGlobali.Globals.sProgressLabelText = "-";

            //l'immagine finale della mappa si copia nelle variabili globali
            VariabiliGlobali.Globals._PictureBox.Image = _bitmapNEW;           
        }

        public void vCreaImmagine()
        {
            PictureBox _PictureBox = new PictureBox();
            _PictureBox.Name = "_PictureBox";
            _PictureBox.Left = 0;
            _PictureBox.Top = 25;
            _PictureBox.Height = 528;
            _PictureBox.Width = 1568;
            _PictureBox.Image = global::EditorMaps.Properties.Resources.empty;

            _PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_empty_MouseMove);
            _PictureBox.Click += new System.EventHandler(this.pictureBox_empty_Click);

            VariabiliGlobali.Globals._PictureBox = _PictureBox;

            Controls.Add(VariabiliGlobali.Globals._PictureBox);
        }

        public void vDistruggiImmagine()
        {

            Controls.Remove(VariabiliGlobali.Globals._PictureBox);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 200; i++)
            {
                toolStripComboBox_Level.Items.Add("Livello " + Convert.ToString(i)); 
            }
            toolStripComboBox_Level.SelectedIndex = 0;
        }

        private void pictureBox_empty_MouseMove(object sender, MouseEventArgs e)
        {
            // Imposta la cordinata del mirino X
                pictureBox_Mirino.Left = (Convert.ToInt32(e.X / VariabiliGlobali.Globals.iGrandezzaImmagini) * VariabiliGlobali.Globals.iGrandezzaImmagini) + ((VariabiliGlobali.Globals.iGrandezzaImmagini / 2) - (6 / 2)) - VariabiliGlobali.Globals.iPosizioneSBorizzontale;
            // Imposta la cordinata del mirino Y
                pictureBox_Mirino.Top = 25 + (Convert.ToInt32(e.Y / VariabiliGlobali.Globals.iGrandezzaImmagini) * VariabiliGlobali.Globals.iGrandezzaImmagini) + ((VariabiliGlobali.Globals.iGrandezzaImmagini / 2) - (6 / 2)) - VariabiliGlobali.Globals.iPosizioneSBverticale;
            // Imposta le variabili globali
                VariabiliGlobali.Globals.iNumeroImageX_editor = (e.X / VariabiliGlobali.Globals.iGrandezzaImmagini);
                VariabiliGlobali.Globals.iNumeroImageY_editor = (e.Y / VariabiliGlobali.Globals.iGrandezzaImmagini);
        }

        /// <summary>
        /// Dato un un numero, controlla l'esistenza e restituisce l'immagine dell'oggetto corrispondente
        /// </summary>
        private bool vControllaIdOggetto(int iNumero)
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
        /// stampa un oggetto selezionato sullo schermo
        /// </summary>
        private void vStampaOggettoOutput()
        {
            // Copia dei valori dell'oggetto da stampare
            int X = VariabiliGlobali.Globals.iNumeroImageX_tools;
            int Y = VariabiliGlobali.Globals.iNumeroImageY_tools;
            vControllaIdOggetto(VariabiliGlobali.Globals.MyMaps.iMap[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor]);
            
            // Stampa sfondo
            Bitmap _bitmapSELEZIONE = new Bitmap(VariabiliGlobali.Globals.Form2.pictureBox_ChipSet.Image);
                Bitmap _bitmapNEW = new Bitmap(VariabiliGlobali.Globals._PictureBox.Image);
                // Copia l'immagine selezionata dell'immagine

                Color _color = new Color();

                    for (int i = 0; i < VariabiliGlobali.Globals.iGrandezzaImmagini; i++)
                        for (int j = 0; j < VariabiliGlobali.Globals.iGrandezzaImmagini; j++)
                        {
                            _color = _bitmapSELEZIONE.GetPixel((VariabiliGlobali.Globals.iNumeroImageX_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + i, (VariabiliGlobali.Globals.iNumeroImageY_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + j);
                            if (_color != Color.FromArgb(255, 255, 255, 255))
                            {
                                if ((VariabiliGlobali.Globals.Form2.checkBox_mLiv1.Checked == true) ||
                                    (VariabiliGlobali.Globals.Form2.checkBox_mLiv2.Checked == true))
                                {
                                    int grayValue = (int)(0.299 * _color.R + 0.587 * _color.G + 0.114 * _color.B);
                                    _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageX_editor) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageY_editor) + j, Color.FromArgb(grayValue, grayValue, grayValue));
                                }
                                else
                                    _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageX_editor) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageY_editor) + j, _color);
                            }  
                        }

                    VariabiliGlobali.Globals.iNumeroImageX_tools = X;
                    VariabiliGlobali.Globals.iNumeroImageY_tools = Y;
                
            // Stampa LIVELLO1
                if (vControllaIdOggetto(VariabiliGlobali.Globals.MyMaps.iMapTrans[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor]))
                {
                    _bitmapSELEZIONE = new Bitmap(VariabiliGlobali.Globals.Form2.pictureBox_ChipSet.Image);
                    // Copia l'immagine selezionata dell'immagine

                    _color = new Color();
                    

                    for (int i = 0; i < VariabiliGlobali.Globals.iGrandezzaImmagini; i++)
                        for (int j = 0; j < VariabiliGlobali.Globals.iGrandezzaImmagini; j++)
                        {
                            _color = _bitmapSELEZIONE.GetPixel((VariabiliGlobali.Globals.iNumeroImageX_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + i, (VariabiliGlobali.Globals.iNumeroImageY_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + j);
                            if (_color != Color.FromArgb(255, 255, 255, 255))
                            {
                                if (VariabiliGlobali.Globals.Form2.checkBox_mLiv2.Checked == true)
                                {
                                    int grayValue = (int)(0.299 * _color.R + 0.587 * _color.G + 0.114 * _color.B);
                                    _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageX_editor) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageY_editor) + j, Color.FromArgb(grayValue, grayValue, grayValue));
                                }
                                else
                                    _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageX_editor) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageY_editor) + j, _color);
                            }
                        }
                }

            // Stampa PERSONAGGI
                if (VariabiliGlobali.Globals.MyMaps.iMapObjects[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor] != 000)
                {
                    _bitmapSELEZIONE = new Bitmap(VariabiliGlobali.Globals.Form3.imageList1.Images[VariabiliGlobali.Globals.MyMaps.iMapObjects[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor]]);
                    // Copia l'immagine selezionata dell'immagine

                    _color = new Color();

                    for (int i = 0; i < VariabiliGlobali.Globals.iGrandezzaImmagini; i++)
                        for (int j = 0; j < VariabiliGlobali.Globals.iGrandezzaImmagini; j++)
                        {
                            _color = _bitmapSELEZIONE.GetPixel(i, j);
                            if (_color != Color.FromArgb(255, 255, 255, 255))
                            {
                                if ((VariabiliGlobali.Globals.Form2.checkBox_mLiv1.Checked == true) ||
                                    (VariabiliGlobali.Globals.Form2.checkBox_mLiv2.Checked == true))
                                {
                                    int grayValue = (int)(0.299 * _color.R + 0.587 * _color.G + 0.114 * _color.B);
                                    _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageX_editor) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageY_editor) + j, Color.FromArgb(grayValue, grayValue, grayValue));
                                }
                                else
                                    _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageX_editor) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageY_editor) + j, _color);
                            }
                        }
                }

            // Stampa LIVELLO2
                if (vControllaIdOggetto(VariabiliGlobali.Globals.MyMaps.iMapTrans2[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor]))
                {

                    // Controllo da aggiungere
                    _bitmapSELEZIONE = new Bitmap(VariabiliGlobali.Globals.Form2.pictureBox_ChipSet.Image);
                    //_bitmapNEW = new Bitmap(_bitmapNEW);
                    // Copia l'immagine selezionata dell'immagine

                    _color = new Color();

                    for (int i = 0; i < VariabiliGlobali.Globals.iGrandezzaImmagini; i++)
                        for (int j = 0; j < VariabiliGlobali.Globals.iGrandezzaImmagini; j++)
                        {
                            _color = _bitmapSELEZIONE.GetPixel((VariabiliGlobali.Globals.iNumeroImageX_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + i, (VariabiliGlobali.Globals.iNumeroImageY_tools * VariabiliGlobali.Globals.iGrandezzaImmagini) + j);
                            if (_color != Color.FromArgb(255, 255, 255, 255))
                            {
                                if (VariabiliGlobali.Globals.Form2.checkBox_mLiv1.Checked == true)
                                {
                                    int grayValue = (int)(0.299 * _color.R + 0.587 * _color.G + 0.114 * _color.B);
                                    _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageX_editor) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageY_editor) + j, Color.FromArgb(grayValue, grayValue, grayValue));
                                }
                                else
                                    _bitmapNEW.SetPixel((VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageX_editor) + i, (VariabiliGlobali.Globals.iGrandezzaImmagini * VariabiliGlobali.Globals.iNumeroImageY_editor) + j, _color);
                            }
                        }
                }
            
            //stampa effettiva dell'immagine
            VariabiliGlobali.Globals._PictureBox.Image = _bitmapNEW;
        }

        /// <summary>
        /// Aggiunge un nuovo oggetto alla matrice
        /// </summary>
        public void vStampaOggettoInMatrice()
        {
            // Stampa dell'oggetto nella matrice
            if ((VariabiliGlobali.Globals.Form2.checkBox_eLiv1.Checked == true) ||
                (VariabiliGlobali.Globals.Form2.checkBox_eLiv2.Checked == true))
            {
                if (VariabiliGlobali.Globals.Form2.checkBox_eLiv1.Checked == true)
                    VariabiliGlobali.Globals.MyMaps.iMapTrans[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor] = 001;

                if (VariabiliGlobali.Globals.Form2.checkBox_eLiv2.Checked == true)
                    VariabiliGlobali.Globals.MyMaps.iMapTrans2[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor] = 002;
            }
            else
                if (VariabiliGlobali.Globals.Form2.checkBox_Personaggi.Checked == true)
                {
                    VariabiliGlobali.Globals.MyMaps.iMapObjects[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor] = VariabiliGlobali.Globals.Form3.comboBox1.SelectedIndex;
                }
                else
                {
                    // Controllo delle cordinate dell'oggetto da disegnare
                    VariabiliGlobali.Globals.Form2.vControllaIdOggetto(VariabiliGlobali.Globals.iIdOggettoSelezionato);

                    // Imposto il valore della variabile al numero di livello dell'oggetto
                    int iNumLivello = VariabiliGlobali.Globals.MyCollisioni.iLivelloOggetti[VariabiliGlobali.Globals.iNumeroImageY_tools, VariabiliGlobali.Globals.iNumeroImageX_tools];

                    switch (iNumLivello)
                    {
                        case 000:
                            {
                                VariabiliGlobali.Globals.MyMaps.iMap[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor] = VariabiliGlobali.Globals.iIdOggettoSelezionato;
                                break;
                            }
                        case 001:
                            {
                                VariabiliGlobali.Globals.MyMaps.iMapTrans[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor] = VariabiliGlobali.Globals.iIdOggettoSelezionato;
                                break;
                            }
                        case 002:
                            {
                                VariabiliGlobali.Globals.MyMaps.iMapTrans2[VariabiliGlobali.Globals.iNumeroImageY_editor, VariabiliGlobali.Globals.iNumeroImageX_editor] = VariabiliGlobali.Globals.iIdOggettoSelezionato;
                                break;
                            }
                    }
                }



            VariabiliGlobali.Globals.MyMaps.cMapWalkable[
                VariabiliGlobali.Globals.iNumeroImageY_editor,
                VariabiliGlobali.Globals.iNumeroImageX_editor
            ] =

                VariabiliGlobali.Globals.MyCollisioni.cFusioneCollisioneOggetti(
                    VariabiliGlobali.Globals.MyMaps.iMapTrans[
                        VariabiliGlobali.Globals.iNumeroImageY_editor,
                        VariabiliGlobali.Globals.iNumeroImageX_editor
                    ],
                    VariabiliGlobali.Globals.MyMaps.iMapTrans2[
                        VariabiliGlobali.Globals.iNumeroImageY_editor,
                        VariabiliGlobali.Globals.iNumeroImageX_editor
                    ]

                );

            // Visualizza l'oggetto sullo schermo
            vStampaOggettoOutput();
        }

        /// <summary>
        /// Controlla la matrice degli oggetti da stampare
        /// </summary>
        // funzione antecedente allo stampo dell'oggetto
        private void vControllaMatriceDaStampare()
        {
            if ((VariabiliGlobali.Globals.Form2.checkBox_eLiv1.Checked == false) &&
                (VariabiliGlobali.Globals.Form2.checkBox_eLiv2.Checked == false) &&
                (VariabiliGlobali.Globals.Form2.checkBox_Personaggi.Checked == false))
            {
                bool bTrovato = false;

                int iX = 0;
                int iY = 0;

                int OLDiNumeroImageX_tools = VariabiliGlobali.Globals.iNumeroImageX_tools;
                int OLDiNumeroImageY_tools = VariabiliGlobali.Globals.iNumeroImageY_tools;

                int OLDiNumeroImageX_editor = VariabiliGlobali.Globals.iNumeroImageX_editor;
                int OLDiNumeroImageY_editor = VariabiliGlobali.Globals.iNumeroImageY_editor;

                for (int i = 0; i < VariabiliGlobali.Globals.MyCollisioni.TileSetYCount; i++)
                {
                    for (int j = 0; j < VariabiliGlobali.Globals.MyCollisioni.TileSetXCount; j++)
                    {
                        if (VariabiliGlobali.Globals.MyCollisioni.iStampaOggetti[i, j] == 1)
                        {
                            if (bTrovato == false)
                            {
                                bTrovato = true;
                                OLDiNumeroImageX_tools = j;
                                OLDiNumeroImageY_tools = i;
                                iX = j;
                                iY = i;
                            }
                            VariabiliGlobali.Globals.iNumeroImageX_tools = OLDiNumeroImageX_tools + (j - iX);
                            VariabiliGlobali.Globals.iNumeroImageY_tools = OLDiNumeroImageY_tools + (i - iY);

                            VariabiliGlobali.Globals.iNumeroImageX_editor = OLDiNumeroImageX_editor + (j - iX);
                            VariabiliGlobali.Globals.iNumeroImageY_editor = OLDiNumeroImageY_editor + (i - iY);

                            VariabiliGlobali.Globals.iIdOggettoSelezionato = VariabiliGlobali.Globals.Form2.vControllaIdOggetto();

                            vStampaOggettoInMatrice();

                            VariabiliGlobali.Globals.iNumeroImageX_tools = OLDiNumeroImageX_tools;
                            VariabiliGlobali.Globals.iNumeroImageY_tools = OLDiNumeroImageY_tools;
                        }
                    }
                }
            } else
                vStampaOggettoInMatrice();
        }

        //click sulla mappa
        private void pictureBox_empty_Click(object sender, EventArgs e)
        {
            vControllaMatriceDaStampare();           
        }

        private void pictureBox_Mirino_Click(object sender, EventArgs e)
        {
            vControllaMatriceDaStampare(); 
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                VariabiliGlobali.Globals.iPosizioneSBorizzontale = e.NewValue;
            } else
                if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
                {
                    VariabiliGlobali.Globals.iPosizioneSBverticale = e.NewValue;
                }
        }

        private void timer_Controllo_Tick(object sender, EventArgs e)
        {
            if (VariabiliGlobali.Globals.Form2.Visible == true)
                toolsToolStripMenuItem.Checked = true;
            else
                toolsToolStripMenuItem.Checked = false;

            if (VariabiliGlobali.Globals.Form3.Visible == true)
                personaggiToolStripMenuItem.Checked = true;
            else
                personaggiToolStripMenuItem.Checked = false;

            if (VariabiliGlobali.Globals.Form4.Visible == true)
                terrenoToolStripMenuItem.Checked = true;
            else
                terrenoToolStripMenuItem.Checked = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //genera una nuova mappa
        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariabiliGlobali.Globals.Form2.vGeneraNuovaMappa(true);
        }

        //apertura file mappa NRmp
        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariabiliGlobali.Globals.Form2.vApriFile();
        }

        //salvataggio mappa
        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            VariabiliGlobali.Globals.Form2.vSalvaFile();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolsToolStripMenuItem.Checked == false)
                VariabiliGlobali.Globals.Form2.Show();
            else
                VariabiliGlobali.Globals.Form2.Hide();
        }

        private void personaggiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (personaggiToolStripMenuItem.Checked == false)
                VariabiliGlobali.Globals.Form3.Show();
            else
                VariabiliGlobali.Globals.Form3.Hide();
        }

        //gestione dimensione finestre
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (VariabiliGlobali.Globals.Form1.WindowState == FormWindowState.Minimized)
            {
                VariabiliGlobali.Globals.Form2.Hide();
                VariabiliGlobali.Globals.Form3.Hide();
                VariabiliGlobali.Globals.Form4.Hide();
            }
            else
            if (VariabiliGlobali.Globals.Form1.WindowState == FormWindowState.Maximized)
            {
                VariabiliGlobali.Globals.Form2.Show();
                VariabiliGlobali.Globals.Form3.Show();
                VariabiliGlobali.Globals.Form4.Show();
                VariabiliGlobali.Globals.Form2.WindowState = FormWindowState.Normal;
                VariabiliGlobali.Globals.Form3.WindowState = FormWindowState.Normal;
                VariabiliGlobali.Globals.Form4.WindowState = FormWindowState.Normal;
            }
            else
            {
                VariabiliGlobali.Globals.Form2.Show();
                VariabiliGlobali.Globals.Form3.Show();
                VariabiliGlobali.Globals.Form4.Show();
                VariabiliGlobali.Globals.Form2.WindowState = VariabiliGlobali.Globals.Form1.WindowState;
                VariabiliGlobali.Globals.Form3.WindowState = VariabiliGlobali.Globals.Form1.WindowState;
                VariabiliGlobali.Globals.Form4.WindowState = VariabiliGlobali.Globals.Form1.WindowState;
            }
        }

        /// <summary>
        /// crea le righe di codice di una mappa da inserire in NumbeRun
        /// </summary>
        public void vCompilaMappa()
        {
            string sTesto = "";

            // Calcolo dei mostri presenti nella mappa
            int iNumeroMostri = 0;
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    if ((VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] >= 2) && (VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] <= 6))
                    {
                        iNumeroMostri++;
                    }
                }
            }

            int iNumeroProtagonisti = 0;
            for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
            {
                for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                {
                    if (VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] == 1)
                    {
                        iNumeroProtagonisti++;
                    }
                }
            }



            if ((iNumeroMostri <= 10) && (iNumeroProtagonisti == 1))
            {
                // Regione del livello
                sTesto = sTesto + "    #region Level " + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1);
                sTesto = sTesto + "\n\n";

                // Summary per la 'iMap'
                sTesto = sTesto + "    /// <summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// Matrice \"L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMap\"";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// </summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    public int[,] L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMap =";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "        {";
                sTesto = sTesto + "\n";
                // iMap
                for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
                {
                    sTesto = sTesto + "            {";
                    for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                    {
                        if (VariabiliGlobali.Globals.MyMaps.iMap[i, j] <= 9)
                            sTesto = sTesto + "00"; else
                            if (VariabiliGlobali.Globals.MyMaps.iMap[i, j] <= 99)
                                sTesto = sTesto + "0";

                        sTesto = sTesto + Convert.ToString(VariabiliGlobali.Globals.MyMaps.iMap[i, j]);
                        if (j != VariabiliGlobali.Globals.MyMaps.MapWidth - 1)
                            sTesto = sTesto + ",";
                    }
                    sTesto = sTesto + "},";
                    sTesto = sTesto + "\n";
                }
                sTesto = sTesto + "};";
                sTesto = sTesto + "\n\n";

                // Summary per la 'iMapTrans'
                sTesto = sTesto + "    /// <summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// Matrice \"L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMapTrans\"";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// </summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    public int[,] L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMapTrans =";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "        {";
                sTesto = sTesto + "\n";
                // iMapTrans
                for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
                {
                    sTesto = sTesto + "            {";
                    for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                    {
                        if (VariabiliGlobali.Globals.MyMaps.iMapTrans[i, j] <= 9)
                            sTesto = sTesto + "00";
                        else
                            if (VariabiliGlobali.Globals.MyMaps.iMapTrans[i, j] <= 99)
                                sTesto = sTesto + "0";

                        sTesto = sTesto + Convert.ToString(VariabiliGlobali.Globals.MyMaps.iMapTrans[i, j]);
                        if (j != VariabiliGlobali.Globals.MyMaps.MapWidth - 1)
                            sTesto = sTesto + ",";
                    }
                    sTesto = sTesto + "},";
                    sTesto = sTesto + "\n";
                }
                sTesto = sTesto + "};";
                sTesto = sTesto + "\n\n";


                // Summary per la 'iMapObjects'
                sTesto = sTesto + "    /// <summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// Matrice \"L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMapObjects\"";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// </summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    public int[,] L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMapObjects =";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "        {";
                sTesto = sTesto + "\n";
                // iMapObjects
                for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
                {
                    sTesto = sTesto + "            {";
                    for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                    {
                        sTesto = sTesto + "000";
                        if (j != VariabiliGlobali.Globals.MyMaps.MapWidth - 1)
                            sTesto = sTesto + ",";
                    }
                    sTesto = sTesto + "},";
                    sTesto = sTesto + "\n";
                }
                sTesto = sTesto + "};";
                sTesto = sTesto + "\n\n";


                // Summary per la 'iMapTrans2'
                sTesto = sTesto + "    /// <summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// Matrice \"L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMapTrans2\"";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// </summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    public int[,] L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMapTrans2 =";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "        {";
                sTesto = sTesto + "\n";
                // iMapTrans2
                for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
                {
                    sTesto = sTesto + "            {";
                    for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                    {
                        if (VariabiliGlobali.Globals.MyMaps.iMapTrans2[i, j] <= 9)
                            sTesto = sTesto + "00";
                        else
                            if (VariabiliGlobali.Globals.MyMaps.iMapTrans2[i, j] <= 99)
                                sTesto = sTesto + "0";

                        sTesto = sTesto + Convert.ToString(VariabiliGlobali.Globals.MyMaps.iMapTrans2[i, j]);
                        if (j != VariabiliGlobali.Globals.MyMaps.MapWidth - 1)
                            sTesto = sTesto + ",";
                    }
                    sTesto = sTesto + "},";
                    sTesto = sTesto + "\n";
                }
                sTesto = sTesto + "};";
                sTesto = sTesto + "\n\n";

                // Summary per la 'cMapWalkable'
                sTesto = sTesto + "    /// <summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// Matrice \"L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_cMapWalkable\"";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// </summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    public char[,] L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_cMapWalkable =";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "        {";
                sTesto = sTesto + "\n";
                // cMapWalkable
                for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
                {
                    sTesto = sTesto + "            {";
                    for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                    {
                        sTesto = sTesto + "'" + VariabiliGlobali.Globals.MyMaps.cMapWalkable[i, j] + "'";
                        if (j != VariabiliGlobali.Globals.MyMaps.MapWidth - 1)
                            sTesto = sTesto + ",";
                    }
                    sTesto = sTesto + "},";
                    sTesto = sTesto + "\n";
                }
                sTesto = sTesto + "};";
                sTesto = sTesto + "\n\n";

                // Summary il caricamento del livello
                sTesto = sTesto + "    /// <summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// Carica il livello " + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1);
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    /// </summary>";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    public void vLoadLevel" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "()";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "    {";
                sTesto = sTesto + "\n";

                // Carica la mappa
                sTesto = sTesto + "        // Carica la mappa";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "        for (int i = 0; i < VariabiliGlobali.Globals.myMaps.MapHeight; i++)";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "        {";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "            for (int j = 0; j < VariabiliGlobali.Globals.myMaps.MapWidth; j++)";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "            {";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "                VariabiliGlobali.Globals.myMaps.iMap[i, j] = this.L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMap[i, j];";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "                VariabiliGlobali.Globals.myMaps.iMapTrans[i, j] = this.L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMapTrans[i, j];";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "                VariabiliGlobali.Globals.myMaps.iMapObjects[i, j] = this.L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMapObjects[i, j];";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "                VariabiliGlobali.Globals.myMaps.iMapTrans2[i, j] = this.L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_iMapTrans2[i, j];";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "                VariabiliGlobali.Globals.myMaps.cMapWalkable[i, j] = this.L" + Convert.ToString(toolStripComboBox_Level.SelectedIndex + 1) + "_cMapWalkable[i, j];";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "            }";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "        }";
                sTesto = sTesto + "\n\n";

                // Inserisci il numero dei mostri
                sTesto = sTesto + "        // Numero dei mostri contenuti nella mappa";
                sTesto = sTesto + "\n";
                sTesto = sTesto + "        iNumeroMostriNellaMappa = " + Convert.ToString(iNumeroMostri) + ";";
                sTesto = sTesto + "\n\n";

                int iNumeroMostro = 0;
                // Stampa dei personaggi
                for (int i = 0; i < VariabiliGlobali.Globals.MyMaps.MapHeight; i++)
                {
                    for (int j = 0; j < VariabiliGlobali.Globals.MyMaps.MapWidth; j++)
                    {
                        if (VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] == 1)
                        {
                            sTesto = sTesto + "        //Coordinate del Personaggio";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMaps.iMapX = " + Convert.ToString(j - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetX) + ";";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMaps.iMapY = " + Convert.ToString(i - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetY) + ";";
                            sTesto = sTesto + "\n\n";
                        }

                        // MlaRun
                        if (VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] == 2)
                        {
                            iNumeroMostro++;
                            sTesto = sTesto + "        //Coordinate del Mostro" + Convert.ToString(iNumeroMostro);
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].MlaRun_.bSelezionato = true;";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarX = " + Convert.ToString(j - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetX) + ";";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarY = " + Convert.ToString(i - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetY) + ";";
                            sTesto = sTesto + "\n\n";
                        }

                        // TrollRun
                        if (VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] == 3)
                        {
                            iNumeroMostro++;
                            sTesto = sTesto + "        //Coordinate del Mostro" + Convert.ToString(iNumeroMostro);
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].TrollRun_.bSelezionato = true;";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarX = " + Convert.ToString(j - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetX) + ";";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarY = " + Convert.ToString(i - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetY) + ";";
                            sTesto = sTesto + "\n\n";
                        }

                        // CybeRun
                        if (VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] == 4)
                        {
                            iNumeroMostro++;
                            sTesto = sTesto + "        //Coordinate del Mostro" + Convert.ToString(iNumeroMostro);
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].CybeRun_.bSelezionato = true;";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarX = " + Convert.ToString(j - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetX) + ";";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarY = " + Convert.ToString(i - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetY) + ";";
                            sTesto = sTesto + "\n\n";
                        }

                        // PhantRun
                        if (VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] == 5)
                        {
                            iNumeroMostro++;
                            sTesto = sTesto + "        //Coordinate del Mostro" + Convert.ToString(iNumeroMostro);
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].PhantRun_.bSelezionato = true;";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarX = " + Convert.ToString(j - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetX) + ";";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarY = " + Convert.ToString(i - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetY) + ";";
                            sTesto = sTesto + "\n\n";
                        }

                        // DevilRun
                        if (VariabiliGlobali.Globals.MyMaps.iMapObjects[i, j] == 6)
                        {
                            iNumeroMostro++;
                            sTesto = sTesto + "        //Coordinate del Mostro" + Convert.ToString(iNumeroMostro);
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].DevilRun_.bSelezionato = true;";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarX = " + Convert.ToString(j - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetX) + ";";
                            sTesto = sTesto + "\n";
                            sTesto = sTesto + "        VariabiliGlobali.Globals.myMonster[" + Convert.ToString(iNumeroMostro - 1) + "].iPlayerAvatarY = " + Convert.ToString(i - VariabiliGlobali.Globals.MyMaps.iMapDisplayOffsetY) + ";";
                            sTesto = sTesto + "\n\n";
                        }
                    }
                }

                sTesto = sTesto + "}";
                sTesto = sTesto + "\n\n";
                sTesto = sTesto + "    #endregion";
                sTesto = sTesto + "\n\n";
            }
            else
                MessageBox.Show("Errore nella compilazione");


            RichTextBox _testo = new RichTextBox();

            _testo.AppendText(sTesto);
            _testo.SelectAll();
            //il file non viene salvato ma viene copiato negli appunti
            _testo.Copy();
        }

        //compilazione della mappa
        private void compilaLivelloSelezionatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vCompilaMappa();
        }

        private void terrenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (terrenoToolStripMenuItem.Checked == false)
                VariabiliGlobali.Globals.Form4.Show();
            else
                VariabiliGlobali.Globals.Form4.Hide();
        }

        //help di NumbeRun e gestione del link al sito
        private void rPGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (System.IO.File.Exists("D:\\Programmi\\Mozilla Firefox\\firefox.exe"))
            {
                System.Diagnostics.Process.Start("FireFox", "http://mmorpggameonline.altervista.org/RPGames/");
            } else
                System.Diagnostics.Process.Start("IExplore", "http://mmorpggameonline.altervista.org/RPGames/");
        }

        private void inviaARPGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Salva e invia la mappa direttamente alla RPGames.\n" +
                "Per il nome del file, se siete registrati presso la RPGames, usate la seguente sintassi:\n" +
                "nomefile:          nickname-nomemappa . NRmp\n" +
                "esempio:           marco153-dungeon . NRmp",
                VariabiliGlobali.Globals.Form1.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (VariabiliGlobali.Globals.Form2.saveFileDialog1.FileName == "")
                VariabiliGlobali.Globals.Form2.saveFileDialog1.FileName = "nickname-nomemappa.NRmp";

                VariabiliGlobali.Globals.bCaricamentoOnLine = true;

                VariabiliGlobali.Globals.Form2.vSalvaFile();
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}