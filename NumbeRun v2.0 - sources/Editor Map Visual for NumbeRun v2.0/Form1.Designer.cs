namespace EditorMaps
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_Controllo = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inviaARPGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.compilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_Level = new System.Windows.Forms.ToolStripComboBox();
            this.compilaLivelloSelezionatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaggiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terrenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.rPGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.pictureBox_Mirino = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mirino)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Controllo
            // 
            this.timer_Controllo.Enabled = true;
            this.timer_Controllo.Tick += new System.EventHandler(this.timer_Controllo_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(695, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.toolStripSeparator1,
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.toolStripSeparator2,
            this.inviaARPGamesToolStripMenuItem,
            this.toolStripSeparator6,
            this.compilaToolStripMenuItem,
            this.toolStripSeparator3,
            this.esciToolStripMenuItem});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "&File";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripMenuItem.Image")));
            this.nuovoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Lime;
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nuovoToolStripMenuItem.Text = "&Nuovo";
            this.nuovoToolStripMenuItem.ToolTipText = "Genera un nuova mappa vuota";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apriToolStripMenuItem.Image")));
            this.apriToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Lime;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.apriToolStripMenuItem.Text = "&Apri";
            this.apriToolStripMenuItem.ToolTipText = "Apre una mappa già esistente";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripMenuItem.Image")));
            this.salvaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Lime;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salvaToolStripMenuItem.Text = "&Salva";
            this.salvaToolStripMenuItem.ToolTipText = "Salva la mappa corrente";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // inviaARPGamesToolStripMenuItem
            // 
            this.inviaARPGamesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inviaARPGamesToolStripMenuItem.Image")));
            this.inviaARPGamesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Lime;
            this.inviaARPGamesToolStripMenuItem.Name = "inviaARPGamesToolStripMenuItem";
            this.inviaARPGamesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.inviaARPGamesToolStripMenuItem.Text = "Invia a &RPGames";
            this.inviaARPGamesToolStripMenuItem.ToolTipText = resources.GetString("inviaARPGamesToolStripMenuItem.ToolTipText");
            this.inviaARPGamesToolStripMenuItem.Click += new System.EventHandler(this.inviaARPGamesToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(161, 6);
            // 
            // compilaToolStripMenuItem
            // 
            this.compilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_Level,
            this.compilaLivelloSelezionatoToolStripMenuItem});
            this.compilaToolStripMenuItem.Name = "compilaToolStripMenuItem";
            this.compilaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.compilaToolStripMenuItem.Text = "&Compila";
            // 
            // toolStripComboBox_Level
            // 
            this.toolStripComboBox_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_Level.Name = "toolStripComboBox_Level";
            this.toolStripComboBox_Level.Size = new System.Drawing.Size(121, 21);
            this.toolStripComboBox_Level.ToolTipText = "Seleziona il livello della mappa realizzata";
            // 
            // compilaLivelloSelezionatoToolStripMenuItem
            // 
            this.compilaLivelloSelezionatoToolStripMenuItem.Name = "compilaLivelloSelezionatoToolStripMenuItem";
            this.compilaLivelloSelezionatoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.compilaLivelloSelezionatoToolStripMenuItem.Text = "&Compila livello";
            this.compilaLivelloSelezionatoToolStripMenuItem.ToolTipText = "Compila la mappa controllandone eventuali errori";
            this.compilaLivelloSelezionatoToolStripMenuItem.Click += new System.EventHandler(this.compilaLivelloSelezionatoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.personaggiToolStripMenuItem,
            this.terrenoToolStripMenuItem});
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel2.Text = "Finestra";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.ToolTipText = "Mostra la finestra \'Tolls\' per inserire nuovi oggetti";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // personaggiToolStripMenuItem
            // 
            this.personaggiToolStripMenuItem.Name = "personaggiToolStripMenuItem";
            this.personaggiToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.personaggiToolStripMenuItem.Text = "Personaggi";
            this.personaggiToolStripMenuItem.ToolTipText = "Mostra la finestra \'Personaggi\' per inserire nuovi personaggi";
            this.personaggiToolStripMenuItem.Click += new System.EventHandler(this.personaggiToolStripMenuItem_Click);
            // 
            // terrenoToolStripMenuItem
            // 
            this.terrenoToolStripMenuItem.Name = "terrenoToolStripMenuItem";
            this.terrenoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.terrenoToolStripMenuItem.Text = "Terreno";
            this.terrenoToolStripMenuItem.Click += new System.EventHandler(this.terrenoToolStripMenuItem_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rPGamesToolStripMenuItem});
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel4.Text = "&?";
            // 
            // rPGamesToolStripMenuItem
            // 
            this.rPGamesToolStripMenuItem.Name = "rPGamesToolStripMenuItem";
            this.rPGamesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.rPGamesToolStripMenuItem.Text = "RPGames";
            this.rPGamesToolStripMenuItem.Click += new System.EventHandler(this.rPGamesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(200, 22);
            this.toolStripLabel3.Text = "-";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 18);
            // 
            // pictureBox_Mirino
            // 
            this.pictureBox_Mirino.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Mirino.Image")));
            this.pictureBox_Mirino.Location = new System.Drawing.Point(50, 50);
            this.pictureBox_Mirino.Name = "pictureBox_Mirino";
            this.pictureBox_Mirino.Size = new System.Drawing.Size(6, 6);
            this.pictureBox_Mirino.TabIndex = 1;
            this.pictureBox_Mirino.TabStop = false;
            this.pictureBox_Mirino.Click += new System.EventHandler(this.pictureBox_Mirino_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(695, 400);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox_Mirino);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Map for NumbeRun";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mirino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_Mirino;
        public System.Windows.Forms.Timer timer_Controllo;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        public System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripMenuItem compilaToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        public System.Windows.Forms.ToolStripDropDownButton toolStripLabel2;
        public System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem personaggiToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        public System.Windows.Forms.ToolStripLabel toolStripLabel3;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripDropDownButton toolStripLabel4;
        public System.Windows.Forms.ToolStripMenuItem rPGamesToolStripMenuItem;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBox_Level;
        public System.Windows.Forms.ToolStripMenuItem compilaLivelloSelezionatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terrenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inviaARPGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

    }
}

