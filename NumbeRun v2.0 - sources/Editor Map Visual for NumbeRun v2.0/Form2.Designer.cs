namespace EditorMaps
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox_ChipSet = new System.Windows.Forms.GroupBox();
            this.pictureBox_Mirino = new System.Windows.Forms.PictureBox();
            this.pictureBox_ChipSet = new System.Windows.Forms.PictureBox();
            this.groupBox_Selezione = new System.Windows.Forms.GroupBox();
            this.pictureBox_Selezione = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer_Apri = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Personaggi = new System.Windows.Forms.CheckBox();
            this.checkBox_eLiv1 = new System.Windows.Forms.CheckBox();
            this.checkBox_eLiv2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_mLiv2 = new System.Windows.Forms.CheckBox();
            this.checkBox_mLiv1 = new System.Windows.Forms.CheckBox();
            this.pictureBox_Mliv = new System.Windows.Forms.PictureBox();
            this.pictureBox_Eliv = new System.Windows.Forms.PictureBox();
            this.button_Nuovo = new System.Windows.Forms.Button();
            this.button_Salva = new System.Windows.Forms.Button();
            this.button_Apri = new System.Windows.Forms.Button();
            this.groupBox_ChipSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mirino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChipSet)).BeginInit();
            this.groupBox_Selezione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Selezione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mliv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eliv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_ChipSet
            // 
            this.groupBox_ChipSet.Controls.Add(this.pictureBox_Mirino);
            this.groupBox_ChipSet.Controls.Add(this.pictureBox_ChipSet);
            this.groupBox_ChipSet.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ChipSet.Name = "groupBox_ChipSet";
            this.groupBox_ChipSet.Size = new System.Drawing.Size(209, 219);
            this.groupBox_ChipSet.TabIndex = 1;
            this.groupBox_ChipSet.TabStop = false;
            this.groupBox_ChipSet.Text = "ChipSet";
            // 
            // pictureBox_Mirino
            // 
            this.pictureBox_Mirino.Image = global::EditorMaps.Properties.Resources.mirino;
            this.pictureBox_Mirino.Location = new System.Drawing.Point(11, 24);
            this.pictureBox_Mirino.Name = "pictureBox_Mirino";
            this.pictureBox_Mirino.Size = new System.Drawing.Size(6, 6);
            this.pictureBox_Mirino.TabIndex = 3;
            this.pictureBox_Mirino.TabStop = false;
            this.pictureBox_Mirino.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Mirino_MouseClick);
            // 
            // pictureBox_ChipSet
            // 
            this.pictureBox_ChipSet.Image = global::EditorMaps.Properties.Resources.fulltileset;
            this.pictureBox_ChipSet.Location = new System.Drawing.Point(6, 19);
            this.pictureBox_ChipSet.Name = "pictureBox_ChipSet";
            this.pictureBox_ChipSet.Size = new System.Drawing.Size(192, 192);
            this.pictureBox_ChipSet.TabIndex = 2;
            this.pictureBox_ChipSet.TabStop = false;
            this.pictureBox_ChipSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ChipSet_MouseMove);
            this.pictureBox_ChipSet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ChipSet_MouseClick);
            // 
            // groupBox_Selezione
            // 
            this.groupBox_Selezione.Controls.Add(this.pictureBox_Selezione);
            this.groupBox_Selezione.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox_Selezione.Location = new System.Drawing.Point(12, 242);
            this.groupBox_Selezione.Name = "groupBox_Selezione";
            this.groupBox_Selezione.Size = new System.Drawing.Size(67, 46);
            this.groupBox_Selezione.TabIndex = 2;
            this.groupBox_Selezione.TabStop = false;
            this.groupBox_Selezione.Text = "Selezione";
            // 
            // pictureBox_Selezione
            // 
            this.pictureBox_Selezione.Image = global::EditorMaps.Properties.Resources.vuoto__16x16_;
            this.pictureBox_Selezione.Location = new System.Drawing.Point(26, 19);
            this.pictureBox_Selezione.Name = "pictureBox_Selezione";
            this.pictureBox_Selezione.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Selezione.TabIndex = 3;
            this.pictureBox_Selezione.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Lime;
            this.imageList1.Images.SetKeyName(0, "nuovo.bmp");
            this.imageList1.Images.SetKeyName(1, "apri.bmp");
            this.imageList1.Images.SetKeyName(2, "salva.bmp");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 303);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // timer_Apri
            // 
            this.timer_Apri.Tick += new System.EventHandler(this.timer_Apri_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "File di mappa|*.NRmp";
            this.openFileDialog1.Title = "Apre una mappa";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "File di mappa|*.NRmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            // 
            // checkBox_Personaggi
            // 
            this.checkBox_Personaggi.AutoSize = true;
            this.checkBox_Personaggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Personaggi.Location = new System.Drawing.Point(85, 284);
            this.checkBox_Personaggi.Name = "checkBox_Personaggi";
            this.checkBox_Personaggi.Size = new System.Drawing.Size(70, 16);
            this.checkBox_Personaggi.TabIndex = 11;
            this.checkBox_Personaggi.Text = "Personaggi";
            this.checkBox_Personaggi.UseVisualStyleBackColor = true;
            this.checkBox_Personaggi.CheckedChanged += new System.EventHandler(this.checkBox_Personaggi_CheckedChanged);
            // 
            // checkBox_eLiv1
            // 
            this.checkBox_eLiv1.AutoSize = true;
            this.checkBox_eLiv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_eLiv1.Location = new System.Drawing.Point(100, 265);
            this.checkBox_eLiv1.Name = "checkBox_eLiv1";
            this.checkBox_eLiv1.Size = new System.Drawing.Size(15, 14);
            this.checkBox_eLiv1.TabIndex = 12;
            this.checkBox_eLiv1.UseVisualStyleBackColor = true;
            // 
            // checkBox_eLiv2
            // 
            this.checkBox_eLiv2.AutoSize = true;
            this.checkBox_eLiv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_eLiv2.Location = new System.Drawing.Point(124, 265);
            this.checkBox_eLiv2.Name = "checkBox_eLiv2";
            this.checkBox_eLiv2.Size = new System.Drawing.Size(15, 14);
            this.checkBox_eLiv2.TabIndex = 13;
            this.checkBox_eLiv2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "2";
            // 
            // checkBox_mLiv2
            // 
            this.checkBox_mLiv2.AutoSize = true;
            this.checkBox_mLiv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_mLiv2.Location = new System.Drawing.Point(124, 248);
            this.checkBox_mLiv2.Name = "checkBox_mLiv2";
            this.checkBox_mLiv2.Size = new System.Drawing.Size(15, 14);
            this.checkBox_mLiv2.TabIndex = 17;
            this.checkBox_mLiv2.UseVisualStyleBackColor = true;
            this.checkBox_mLiv2.CheckedChanged += new System.EventHandler(this.checkBox_mLiv2_CheckedChanged);
            // 
            // checkBox_mLiv1
            // 
            this.checkBox_mLiv1.AutoSize = true;
            this.checkBox_mLiv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_mLiv1.Location = new System.Drawing.Point(100, 248);
            this.checkBox_mLiv1.Name = "checkBox_mLiv1";
            this.checkBox_mLiv1.Size = new System.Drawing.Size(15, 14);
            this.checkBox_mLiv1.TabIndex = 16;
            this.checkBox_mLiv1.UseVisualStyleBackColor = true;
            this.checkBox_mLiv1.CheckedChanged += new System.EventHandler(this.checkBox_mLiv1_CheckedChanged);
            // 
            // pictureBox_Mliv
            // 
            this.pictureBox_Mliv.Image = global::EditorMaps.Properties.Resources.freccia1;
            this.pictureBox_Mliv.Location = new System.Drawing.Point(83, 247);
            this.pictureBox_Mliv.Name = "pictureBox_Mliv";
            this.pictureBox_Mliv.Size = new System.Drawing.Size(14, 14);
            this.pictureBox_Mliv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Mliv.TabIndex = 18;
            this.pictureBox_Mliv.TabStop = false;
            // 
            // pictureBox_Eliv
            // 
            this.pictureBox_Eliv.Image = global::EditorMaps.Properties.Resources.cestino;
            this.pictureBox_Eliv.Location = new System.Drawing.Point(83, 265);
            this.pictureBox_Eliv.Name = "pictureBox_Eliv";
            this.pictureBox_Eliv.Size = new System.Drawing.Size(14, 14);
            this.pictureBox_Eliv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Eliv.TabIndex = 4;
            this.pictureBox_Eliv.TabStop = false;
            // 
            // button_Nuovo
            // 
            this.button_Nuovo.AutoEllipsis = true;
            this.button_Nuovo.ImageIndex = 0;
            this.button_Nuovo.ImageList = this.imageList1;
            this.button_Nuovo.Location = new System.Drawing.Point(158, 241);
            this.button_Nuovo.Name = "button_Nuovo";
            this.button_Nuovo.Size = new System.Drawing.Size(63, 23);
            this.button_Nuovo.TabIndex = 8;
            this.button_Nuovo.UseVisualStyleBackColor = true;
            this.button_Nuovo.Click += new System.EventHandler(this.button_Nuovo_Click);
            // 
            // button_Salva
            // 
            this.button_Salva.AutoEllipsis = true;
            this.button_Salva.ImageIndex = 2;
            this.button_Salva.ImageList = this.imageList1;
            this.button_Salva.Location = new System.Drawing.Point(192, 271);
            this.button_Salva.Name = "button_Salva";
            this.button_Salva.Size = new System.Drawing.Size(29, 22);
            this.button_Salva.TabIndex = 6;
            this.button_Salva.UseVisualStyleBackColor = true;
            this.button_Salva.Click += new System.EventHandler(this.button_Salva_Click);
            // 
            // button_Apri
            // 
            this.button_Apri.AutoEllipsis = true;
            this.button_Apri.ImageIndex = 1;
            this.button_Apri.ImageList = this.imageList1;
            this.button_Apri.Location = new System.Drawing.Point(157, 271);
            this.button_Apri.Name = "button_Apri";
            this.button_Apri.Size = new System.Drawing.Size(29, 22);
            this.button_Apri.TabIndex = 5;
            this.button_Apri.UseVisualStyleBackColor = true;
            this.button_Apri.Click += new System.EventHandler(this.button_Apri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(228, 347);
            this.Controls.Add(this.pictureBox_Mliv);
            this.Controls.Add(this.pictureBox_Eliv);
            this.Controls.Add(this.checkBox_mLiv2);
            this.Controls.Add(this.checkBox_mLiv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_eLiv2);
            this.Controls.Add(this.checkBox_eLiv1);
            this.Controls.Add(this.checkBox_Personaggi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Nuovo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_Salva);
            this.Controls.Add(this.button_Apri);
            this.Controls.Add(this.groupBox_Selezione);
            this.Controls.Add(this.groupBox_ChipSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "Tools";
            this.TopMost = true;
            this.Move += new System.EventHandler(this.Form2_Move);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox_ChipSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mirino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChipSet)).EndInit();
            this.groupBox_Selezione.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Selezione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mliv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eliv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_ChipSet;
        public System.Windows.Forms.PictureBox pictureBox_ChipSet;
        public System.Windows.Forms.PictureBox pictureBox_Selezione;
        public System.Windows.Forms.PictureBox pictureBox_Mirino;
        public System.Windows.Forms.GroupBox groupBox_Selezione;
        public System.Windows.Forms.Button button_Apri;
        public System.Windows.Forms.Button button_Salva;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer_Apri;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button button_Nuovo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkBox_Personaggi;
        public System.Windows.Forms.CheckBox checkBox_eLiv1;
        public System.Windows.Forms.CheckBox checkBox_eLiv2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox checkBox_mLiv2;
        public System.Windows.Forms.CheckBox checkBox_mLiv1;
        private System.Windows.Forms.PictureBox pictureBox_Eliv;
        private System.Windows.Forms.PictureBox pictureBox_Mliv;

    }
}