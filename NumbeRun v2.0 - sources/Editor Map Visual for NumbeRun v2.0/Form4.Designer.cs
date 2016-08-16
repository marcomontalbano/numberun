namespace EditorMaps
{
    partial class Form4
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
            this.groupBox_Selezione = new System.Windows.Forms.GroupBox();
            this.checkBox_Acqua = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox_Selezione = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_Selezione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Selezione)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Selezione
            // 
            this.groupBox_Selezione.Controls.Add(this.checkBox_Acqua);
            this.groupBox_Selezione.Controls.Add(this.comboBox1);
            this.groupBox_Selezione.Controls.Add(this.pictureBox_Selezione);
            this.groupBox_Selezione.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox_Selezione.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Selezione.Name = "groupBox_Selezione";
            this.groupBox_Selezione.Size = new System.Drawing.Size(204, 64);
            this.groupBox_Selezione.TabIndex = 4;
            this.groupBox_Selezione.TabStop = false;
            this.groupBox_Selezione.Text = "Selezione";
            // 
            // checkBox_Acqua
            // 
            this.checkBox_Acqua.AutoSize = true;
            this.checkBox_Acqua.Checked = true;
            this.checkBox_Acqua.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Acqua.Location = new System.Drawing.Point(67, 41);
            this.checkBox_Acqua.Name = "checkBox_Acqua";
            this.checkBox_Acqua.Size = new System.Drawing.Size(127, 17);
            this.checkBox_Acqua.TabIndex = 5;
            this.checkBox_Acqua.Text = "Non eliminare l\'acqua";
            this.checkBox_Acqua.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erba",
            "Erba chiara",
            "Sabbia",
            "Deserto",
            "Palude",
            "Acqua",
            "Terra Bruciata",
            "Erba Fitta",
            "Fango",
            "Erba Alta",
            "Pietra"});
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aggiorna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 108);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_Selezione);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form4";
            this.ShowInTaskbar = false;
            this.Text = "Terreno";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox_Selezione.ResumeLayout(false);
            this.groupBox_Selezione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Selezione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_Selezione;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.PictureBox pictureBox_Selezione;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox checkBox_Acqua;
    }
}