namespace EditorMaps
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox_Selezione = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox_Selezione = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox_Selezione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Selezione)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Selezione
            // 
            this.groupBox_Selezione.Controls.Add(this.comboBox1);
            this.groupBox_Selezione.Controls.Add(this.pictureBox_Selezione);
            this.groupBox_Selezione.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox_Selezione.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Selezione.Name = "groupBox_Selezione";
            this.groupBox_Selezione.Size = new System.Drawing.Size(204, 46);
            this.groupBox_Selezione.TabIndex = 3;
            this.groupBox_Selezione.TabStop = false;
            this.groupBox_Selezione.Text = "Selezione";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "elimina",
            "Protagonista",
            "MlaRun",
            "TrollRun",
            "CybeRun",
            "PhantRun",
            "DevilRun"});
            this.comboBox1.Location = new System.Drawing.Point(67, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox_Selezione
            // 
            this.pictureBox_Selezione.Location = new System.Drawing.Point(26, 19);
            this.pictureBox_Selezione.Name = "pictureBox_Selezione";
            this.pictureBox_Selezione.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Selezione.TabIndex = 3;
            this.pictureBox_Selezione.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrizione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "_";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "vuoto (16x16).bmp");
            this.imageList1.Images.SetKeyName(1, "maschio.bmp");
            this.imageList1.Images.SetKeyName(2, "mostro1.bmp");
            this.imageList1.Images.SetKeyName(3, "mostro2.bmp");
            this.imageList1.Images.SetKeyName(4, "mostro3.bmp");
            this.imageList1.Images.SetKeyName(5, "mostro4.bmp");
            this.imageList1.Images.SetKeyName(6, "mostro5.bmp");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 148);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Selezione);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.Text = "Personaggi";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox_Selezione.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Selezione)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_Selezione;
        public System.Windows.Forms.PictureBox pictureBox_Selezione;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ImageList imageList1;
    }
}