using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace LaunchNumbeRun
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void vLoadGame()
        {
            if (System.IO.File.Exists("NumbeRun.exe"))
            {
                ProcessStartInfo ps = new ProcessStartInfo("NumbeRun.exe");
                ps.Arguments = VariabiliGlobali.Globals.sNomeUtente + " " + VariabiliGlobali.Globals.sPasswordUtente + " " + VariabiliGlobali.Globals.sDataBaseIP;
                ps.RedirectStandardOutput = true;
                ps.UseShellExecute = false;
                Process p = Process.Start(ps);
            }
            else
            {
                MessageBox.Show("impossibile proseguire; il file è stato cancellato o rimosso", Text);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Avvia il video
            if (timer_Ritardo.Interval == 90)
            {
                axWindowsMediaPlayer1.URL = "RPGames Intro.wmv";
                timer_Ritardo.Interval = 99;
            }

            // Aspetta che il video sia avviato
            if (timer_Ritardo.Interval == 99)
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    timer_Ritardo.Interval = 100;
            }

            if (timer_Ritardo.Interval == 100)
            {
                if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    timer_Ritardo.Enabled = false;
                    timer_CHIUSURA.Enabled = true;
                    axWindowsMediaPlayer1.URL = "";
                    vLoadGame();
                }
                else
                    if (axWindowsMediaPlayer1.fullScreen == false)
                    {
                        timer_Ritardo.Enabled = false;
                        timer_CHIUSURA.Enabled = true;
                        axWindowsMediaPlayer1.URL = "";
                        vLoadGame();
                    }
            }
        }

        private void timer_CHIUSURA_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}