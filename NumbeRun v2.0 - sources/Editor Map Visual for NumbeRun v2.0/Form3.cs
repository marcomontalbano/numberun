using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EditorMaps
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //gestione selezione mostro dalla combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_Selezione.Image = imageList1.Images[comboBox1.SelectedIndex];
            switch (comboBox1.Text)
            {
                case "elimina":
                    {
                        label1.Text =
                            "Permette di eliminare il personaggio\n" +
                            "inserito sulla mappa.";
                        break;
                    }
                case "Protagonista":
                    {
                        label1.Text =
                            "E' il protagonista del gioco;\n" +
                            "Per ogni mappa deve essere presente\n" +
                            "almeno e massimo un protagonista.";
                        break;
                    }
                case "MlaRun":
                    {
                        label1.Text =
                            "MlaRun si muove in modo completa-\n" +
                            "mente casuale. La sua velocità è\n" +
                            "particolarmente ridotta.";
                        break;
                    }
                case "TrollRun":
                    {
                        label1.Text =
                            "TrollRun si muove in modo completa-\n" +
                            "mente casuale. La sua velocità è\n" +
                            "leggermente inferiore a quella del\n" +
                            "protagonista.";
                        break;
                    }
                case "CybeRun":
                    {
                        label1.Text =
                            "CybeRun segue assiduamente il\n" +
                            "protagonista. La sua velocità è\n" +
                            "inferiore, ma ciò non esclude che\n" +
                            "sarà un avversario temibile.";
                        break;
                    }
                case "PhantRun":
                    {
                        label1.Text =
                            "PhantRun è un cacciatore di tesori.\n" +
                            "Il suo corpo inconsistente, gli\n" +
                            "premette di passase attraverso tutti\n" +
                            "gli oggetti.";
                        break;
                    }
                case "DevilRun":
                    {
                        label1.Text =
                            "DevilRun segue assiduamente il\n" +
                            "protagonista. La sua velocità è\n" +
                            "notevole; state molto attenti.";
                        break;
                    }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                VariabiliGlobali.Globals.Form3.Hide();
                e.Cancel = true;
            }
        }
    }
}