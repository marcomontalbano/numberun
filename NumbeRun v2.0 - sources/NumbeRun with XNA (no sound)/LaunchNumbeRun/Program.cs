using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace LaunchNumbeRun
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                // controllo degli argomenti
                VariabiliGlobali.Globals.sNomeUtente = args[0];
                VariabiliGlobali.Globals.sPasswordUtente = args[1];
                VariabiliGlobali.Globals.sDataBaseIP = args[2];

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

            }
            
        }
    }
}