using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EditorMaps
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Imposta le proprietà della Form1
            VariabiliGlobali.Globals.Form1.Show();

            // Imposta le proprietà della Form2
            VariabiliGlobali.Globals.Form2.Show();
            VariabiliGlobali.Globals.Form2.Left = 5;
            VariabiliGlobali.Globals.Form2.Top = 53;

            // Imposta le proprietà della Form3
            VariabiliGlobali.Globals.Form3.Show();
            VariabiliGlobali.Globals.Form3.Left = VariabiliGlobali.Globals.Form2.Left;
            VariabiliGlobali.Globals.Form3.Top = VariabiliGlobali.Globals.Form2.Top + VariabiliGlobali.Globals.Form2.Height + 3;

            // Imposta le proprietà della Form3
            VariabiliGlobali.Globals.Form4.Show();
            VariabiliGlobali.Globals.Form4.Left = VariabiliGlobali.Globals.Form2.Left;
            VariabiliGlobali.Globals.Form4.Top = VariabiliGlobali.Globals.Form3.Top + VariabiliGlobali.Globals.Form3.Height + 3;

            // Genera nuova mappa   
            VariabiliGlobali.Globals.Form1.vCreaImmagine();

            VariabiliGlobali.Globals.Form2.vFormDisable();
            VariabiliGlobali.Globals.Form2.timer_Apri.Enabled = true;
            VariabiliGlobali.Globals.sProgressLabelText = "Inizializzazione...";
            VariabiliGlobali.Globals.vStampaMatrice();

        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(50);
        }
    }
}