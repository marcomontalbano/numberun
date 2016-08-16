using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EditorMaps
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //gestione variabili globali in base allo sfondo selezionato
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "Erba":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 0;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 0;
                        break;
                    }
                case "Erba chiara":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 0;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 6;
                        break;
                    }
                case "Sabbia":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 1;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 6;
                        break;
                    }
                case "Deserto":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 2;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 6;
                        break;
                    }
                case "Palude":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 3;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 6;
                        break;
                    }
                case "Acqua":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 0;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 8;
                        break;
                    }
                case "Terra Bruciata":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 3;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 8;
                        break;
                    }
                case "Erba Fitta":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 4;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 8;
                        break;
                    }
                case "Fango":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 5;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 8;
                        break;
                    }
                case "Erba Alta":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 6;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 8;
                        break;
                    }
                case "Pietra":
                    {
                        VariabiliGlobali.Globals.iNumeroImageX_tools = 7;
                        VariabiliGlobali.Globals.iNumeroImageY_tools = 8;
                        break;
                    }
            }

            VariabiliGlobali.Globals.Form2.vSelezionaOggetto(true);

            pictureBox_Selezione.Image = VariabiliGlobali.Globals.Form2.pictureBox_Selezione.Image;

            for (int ii = 0; ii < VariabiliGlobali.Globals.MyMaps.MapHeight; ii++)
            {
                for (int jj = 0; jj < VariabiliGlobali.Globals.MyMaps.MapWidth; jj++)
                {
                    if ((checkBox_Acqua.Checked == true) && (VariabiliGlobali.Globals.MyMaps.iMap[ii, jj] != 096))
                        VariabiliGlobali.Globals.MyMaps.iMap[ii, jj] = VariabiliGlobali.Globals.iIdOggettoSelezionato;
                    else
                        if (checkBox_Acqua.Checked == false)
                            VariabiliGlobali.Globals.MyMaps.iMap[ii, jj] = VariabiliGlobali.Globals.iIdOggettoSelezionato;
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                VariabiliGlobali.Globals.Form4.Hide();
                e.Cancel = true;
            }
        }

        //cambiamento del terreno
        private void button1_Click(object sender, EventArgs e)
        {
            // Genera nuova mappa  
            int iSI = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = iSI;

            VariabiliGlobali.Globals.Form2.vFormDisable();
            VariabiliGlobali.Globals.Form2.timer_Apri.Enabled = true;
            VariabiliGlobali.Globals.sProgressLabelText = "Cambiamento del terreno in corso...";
            VariabiliGlobali.Globals.vStampaMatrice();
        }
    }
}