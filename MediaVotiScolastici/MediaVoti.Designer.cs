namespace MediaVotiScolastici
{
    partial class MediaVoti
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaVoti));
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblNomeCognomeAlunni = new System.Windows.Forms.Label();
            this.txtNomeCognomeAlunni = new System.Windows.Forms.TextBox();
            this.gboxClasse = new System.Windows.Forms.GroupBox();
            this.rdbVC = new System.Windows.Forms.RadioButton();
            this.rdbIVC = new System.Windows.Forms.RadioButton();
            this.rdbIIIC = new System.Windows.Forms.RadioButton();
            this.rdbIIC = new System.Windows.Forms.RadioButton();
            this.rdbIC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOraleMate = new System.Windows.Forms.TextBox();
            this.lblOraleMate = new System.Windows.Forms.Label();
            this.txtScrittoMate = new System.Windows.Forms.TextBox();
            this.lblScrittoMate = new System.Windows.Forms.Label();
            this.txtLabInfo = new System.Windows.Forms.TextBox();
            this.lblLabInformatica = new System.Windows.Forms.Label();
            this.txtOraleInfo = new System.Windows.Forms.TextBox();
            this.txtScInfo = new System.Windows.Forms.TextBox();
            this.lblOraleInformatica = new System.Windows.Forms.Label();
            this.lblScrittoInformatica = new System.Windows.Forms.Label();
            this.lblMediaVoti = new System.Windows.Forms.Label();
            this.txtMediaInfo = new System.Windows.Forms.TextBox();
            this.lblMediaMate = new System.Windows.Forms.Label();
            this.txtMediaMatematica = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnLeggi = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnMediaInformatica = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLabMate = new System.Windows.Forms.Label();
            this.txtlabMate = new System.Windows.Forms.TextBox();
            this.cboxInformatica = new System.Windows.Forms.ComboBox();
            this.cboxMatematica = new System.Windows.Forms.ComboBox();
            this.gboxClasse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitolo.Location = new System.Drawing.Point(12, 21);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(696, 32);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Media dei Voti per la materie Informatica e Matematica";
            // 
            // lblNomeCognomeAlunni
            // 
            this.lblNomeCognomeAlunni.AutoSize = true;
            this.lblNomeCognomeAlunni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCognomeAlunni.Location = new System.Drawing.Point(14, 67);
            this.lblNomeCognomeAlunni.Name = "lblNomeCognomeAlunni";
            this.lblNomeCognomeAlunni.Size = new System.Drawing.Size(326, 24);
            this.lblNomeCognomeAlunni.TabIndex = 1;
            this.lblNomeCognomeAlunni.Text = "Nome Cognome Alunno o Alunna";
            // 
            // txtNomeCognomeAlunni
            // 
            this.txtNomeCognomeAlunni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCognomeAlunni.Location = new System.Drawing.Point(18, 107);
            this.txtNomeCognomeAlunni.Name = "txtNomeCognomeAlunni";
            this.txtNomeCognomeAlunni.Size = new System.Drawing.Size(322, 20);
            this.txtNomeCognomeAlunni.TabIndex = 2;
            this.txtNomeCognomeAlunni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gboxClasse
            // 
            this.gboxClasse.Controls.Add(this.rdbVC);
            this.gboxClasse.Controls.Add(this.rdbIVC);
            this.gboxClasse.Controls.Add(this.rdbIIIC);
            this.gboxClasse.Controls.Add(this.rdbIIC);
            this.gboxClasse.Controls.Add(this.rdbIC);
            this.gboxClasse.Location = new System.Drawing.Point(18, 144);
            this.gboxClasse.Name = "gboxClasse";
            this.gboxClasse.Size = new System.Drawing.Size(446, 79);
            this.gboxClasse.TabIndex = 3;
            this.gboxClasse.TabStop = false;
            this.gboxClasse.Text = "Inserisci la Classe";
            // 
            // rdbVC
            // 
            this.rdbVC.AutoSize = true;
            this.rdbVC.Location = new System.Drawing.Point(357, 34);
            this.rdbVC.Name = "rdbVC";
            this.rdbVC.Size = new System.Drawing.Size(76, 17);
            this.rdbVC.TabIndex = 4;
            this.rdbVC.TabStop = true;
            this.rdbVC.Text = "Classe V C";
            this.rdbVC.UseVisualStyleBackColor = true;
            this.rdbVC.CheckedChanged += new System.EventHandler(this.rdbVC_CheckedChanged);
            // 
            // rdbIVC
            // 
            this.rdbIVC.AutoSize = true;
            this.rdbIVC.Location = new System.Drawing.Point(272, 34);
            this.rdbIVC.Name = "rdbIVC";
            this.rdbIVC.Size = new System.Drawing.Size(79, 17);
            this.rdbIVC.TabIndex = 3;
            this.rdbIVC.TabStop = true;
            this.rdbIVC.Text = "Classe IV C";
            this.rdbIVC.UseVisualStyleBackColor = true;
            this.rdbIVC.CheckedChanged += new System.EventHandler(this.rdbIVC_CheckedChanged);
            // 
            // rdbIIIC
            // 
            this.rdbIIIC.AutoSize = true;
            this.rdbIIIC.Location = new System.Drawing.Point(177, 34);
            this.rdbIIIC.Name = "rdbIIIC";
            this.rdbIIIC.Size = new System.Drawing.Size(78, 17);
            this.rdbIIIC.TabIndex = 2;
            this.rdbIIIC.TabStop = true;
            this.rdbIIIC.Text = "Classe III C";
            this.rdbIIIC.UseVisualStyleBackColor = true;
            this.rdbIIIC.CheckedChanged += new System.EventHandler(this.rdbIIIC_CheckedChanged);
            // 
            // rdbIIC
            // 
            this.rdbIIC.AutoSize = true;
            this.rdbIIC.Location = new System.Drawing.Point(96, 34);
            this.rdbIIC.Name = "rdbIIC";
            this.rdbIIC.Size = new System.Drawing.Size(75, 17);
            this.rdbIIC.TabIndex = 1;
            this.rdbIIC.TabStop = true;
            this.rdbIIC.Text = "Classe II C";
            this.rdbIIC.UseVisualStyleBackColor = true;
            this.rdbIIC.CheckedChanged += new System.EventHandler(this.rdbIIC_CheckedChanged);
            // 
            // rdbIC
            // 
            this.rdbIC.AutoSize = true;
            this.rdbIC.Location = new System.Drawing.Point(20, 34);
            this.rdbIC.Name = "rdbIC";
            this.rdbIC.Size = new System.Drawing.Size(72, 17);
            this.rdbIC.TabIndex = 0;
            this.rdbIC.TabStop = true;
            this.rdbIC.Text = "Classe I C";
            this.rdbIC.UseVisualStyleBackColor = true;
            this.rdbIC.CheckedChanged += new System.EventHandler(this.rdbIC_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxMatematica);
            this.groupBox1.Controls.Add(this.cboxInformatica);
            this.groupBox1.Controls.Add(this.txtlabMate);
            this.groupBox1.Controls.Add(this.lblLabMate);
            this.groupBox1.Controls.Add(this.txtOraleMate);
            this.groupBox1.Controls.Add(this.lblOraleMate);
            this.groupBox1.Controls.Add(this.txtScrittoMate);
            this.groupBox1.Controls.Add(this.lblScrittoMate);
            this.groupBox1.Controls.Add(this.txtLabInfo);
            this.groupBox1.Controls.Add(this.lblLabInformatica);
            this.groupBox1.Controls.Add(this.txtOraleInfo);
            this.groupBox1.Controls.Add(this.txtScInfo);
            this.groupBox1.Controls.Add(this.lblOraleInformatica);
            this.groupBox1.Controls.Add(this.lblScrittoInformatica);
            this.groupBox1.Location = new System.Drawing.Point(18, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voti Informatica e Matematica";
            // 
            // txtOraleMate
            // 
            this.txtOraleMate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOraleMate.Location = new System.Drawing.Point(379, 84);
            this.txtOraleMate.Name = "txtOraleMate";
            this.txtOraleMate.Size = new System.Drawing.Size(48, 20);
            this.txtOraleMate.TabIndex = 23;
            // 
            // lblOraleMate
            // 
            this.lblOraleMate.AutoSize = true;
            this.lblOraleMate.Location = new System.Drawing.Point(283, 91);
            this.lblOraleMate.Name = "lblOraleMate";
            this.lblOraleMate.Size = new System.Drawing.Size(90, 13);
            this.lblOraleMate.TabIndex = 22;
            this.lblOraleMate.Text = "Orale Matematica";
            // 
            // txtScrittoMate
            // 
            this.txtScrittoMate.BackColor = System.Drawing.SystemColors.Window;
            this.txtScrittoMate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScrittoMate.Location = new System.Drawing.Point(232, 84);
            this.txtScrittoMate.Name = "txtScrittoMate";
            this.txtScrittoMate.Size = new System.Drawing.Size(48, 20);
            this.txtScrittoMate.TabIndex = 21;
            // 
            // lblScrittoMate
            // 
            this.lblScrittoMate.AutoSize = true;
            this.lblScrittoMate.Location = new System.Drawing.Point(128, 91);
            this.lblScrittoMate.Name = "lblScrittoMate";
            this.lblScrittoMate.Size = new System.Drawing.Size(95, 13);
            this.lblScrittoMate.TabIndex = 20;
            this.lblScrittoMate.Text = "Scritto Matematica";
            // 
            // txtLabInfo
            // 
            this.txtLabInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLabInfo.Location = new System.Drawing.Point(554, 29);
            this.txtLabInfo.Name = "txtLabInfo";
            this.txtLabInfo.Size = new System.Drawing.Size(48, 20);
            this.txtLabInfo.TabIndex = 15;
            // 
            // lblLabInformatica
            // 
            this.lblLabInformatica.AutoSize = true;
            this.lblLabInformatica.Location = new System.Drawing.Point(433, 36);
            this.lblLabInformatica.Name = "lblLabInformatica";
            this.lblLabInformatica.Size = new System.Drawing.Size(115, 13);
            this.lblLabInformatica.TabIndex = 14;
            this.lblLabInformatica.Text = "Laboratorio Informatica";
            // 
            // txtOraleInfo
            // 
            this.txtOraleInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOraleInfo.Location = new System.Drawing.Point(379, 29);
            this.txtOraleInfo.Name = "txtOraleInfo";
            this.txtOraleInfo.Size = new System.Drawing.Size(48, 20);
            this.txtOraleInfo.TabIndex = 13;
            // 
            // txtScInfo
            // 
            this.txtScInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScInfo.Location = new System.Drawing.Point(232, 28);
            this.txtScInfo.Name = "txtScInfo";
            this.txtScInfo.Size = new System.Drawing.Size(48, 20);
            this.txtScInfo.TabIndex = 12;
            // 
            // lblOraleInformatica
            // 
            this.lblOraleInformatica.AutoSize = true;
            this.lblOraleInformatica.Location = new System.Drawing.Point(286, 36);
            this.lblOraleInformatica.Name = "lblOraleInformatica";
            this.lblOraleInformatica.Size = new System.Drawing.Size(87, 13);
            this.lblOraleInformatica.TabIndex = 11;
            this.lblOraleInformatica.Text = "Orale Informatica";
            // 
            // lblScrittoInformatica
            // 
            this.lblScrittoInformatica.AutoSize = true;
            this.lblScrittoInformatica.Location = new System.Drawing.Point(131, 36);
            this.lblScrittoInformatica.Name = "lblScrittoInformatica";
            this.lblScrittoInformatica.Size = new System.Drawing.Size(92, 13);
            this.lblScrittoInformatica.TabIndex = 10;
            this.lblScrittoInformatica.Text = "Scritto Informatica";
            // 
            // lblMediaVoti
            // 
            this.lblMediaVoti.AutoSize = true;
            this.lblMediaVoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaVoti.Location = new System.Drawing.Point(647, 244);
            this.lblMediaVoti.Name = "lblMediaVoti";
            this.lblMediaVoti.Size = new System.Drawing.Size(216, 24);
            this.lblMediaVoti.TabIndex = 5;
            this.lblMediaVoti.Text = "Media Voti Informatica";
            // 
            // txtMediaInfo
            // 
            this.txtMediaInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMediaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaInfo.Location = new System.Drawing.Point(686, 273);
            this.txtMediaInfo.Name = "txtMediaInfo";
            this.txtMediaInfo.Size = new System.Drawing.Size(177, 29);
            this.txtMediaInfo.TabIndex = 6;
            // 
            // lblMediaMate
            // 
            this.lblMediaMate.AutoSize = true;
            this.lblMediaMate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaMate.Location = new System.Drawing.Point(643, 305);
            this.lblMediaMate.Name = "lblMediaMate";
            this.lblMediaMate.Size = new System.Drawing.Size(220, 24);
            this.lblMediaMate.TabIndex = 7;
            this.lblMediaMate.Text = "Media Voti Matematica";
            // 
            // txtMediaMatematica
            // 
            this.txtMediaMatematica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMediaMatematica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaMatematica.Location = new System.Drawing.Point(686, 336);
            this.txtMediaMatematica.Multiline = true;
            this.txtMediaMatematica.Name = "txtMediaMatematica";
            this.txtMediaMatematica.Size = new System.Drawing.Size(177, 29);
            this.txtMediaMatematica.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Transparent;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(27, 368);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 43);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(125, 368);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(89, 43);
            this.btnSalva.TabIndex = 10;
            this.btnSalva.Text = "Salva";
            this.btnSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnLeggi
            // 
            this.btnLeggi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLeggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggi.ForeColor = System.Drawing.Color.Transparent;
            this.btnLeggi.Image = ((System.Drawing.Image)(resources.GetObject("btnLeggi.Image")));
            this.btnLeggi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeggi.Location = new System.Drawing.Point(220, 368);
            this.btnLeggi.Name = "btnLeggi";
            this.btnLeggi.Size = new System.Drawing.Size(89, 43);
            this.btnLeggi.TabIndex = 11;
            this.btnLeggi.Text = "Leggi";
            this.btnLeggi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeggi.UseVisualStyleBackColor = false;
            this.btnLeggi.Click += new System.EventHandler(this.btnLeggi_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.ForeColor = System.Drawing.Color.Transparent;
            this.btnEsci.Image = ((System.Drawing.Image)(resources.GetObject("btnEsci.Image")));
            this.btnEsci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEsci.Location = new System.Drawing.Point(782, 388);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(81, 47);
            this.btnEsci.TabIndex = 12;
            this.btnEsci.Text = "Esci";
            this.btnEsci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnMediaInformatica
            // 
            this.btnMediaInformatica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMediaInformatica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaInformatica.ForeColor = System.Drawing.Color.Transparent;
            this.btnMediaInformatica.Image = ((System.Drawing.Image)(resources.GetObject("btnMediaInformatica.Image")));
            this.btnMediaInformatica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMediaInformatica.Location = new System.Drawing.Point(506, 87);
            this.btnMediaInformatica.Name = "btnMediaInformatica";
            this.btnMediaInformatica.Size = new System.Drawing.Size(282, 40);
            this.btnMediaInformatica.TabIndex = 13;
            this.btnMediaInformatica.Text = "Calcola Media Informatica";
            this.btnMediaInformatica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMediaInformatica.UseVisualStyleBackColor = false;
            this.btnMediaInformatica.Click += new System.EventHandler(this.btnMediaInformatica_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(506, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calcola Media Matematica";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLabMate
            // 
            this.lblLabMate.AutoSize = true;
            this.lblLabMate.Location = new System.Drawing.Point(430, 91);
            this.lblLabMate.Name = "lblLabMate";
            this.lblLabMate.Size = new System.Drawing.Size(118, 13);
            this.lblLabMate.TabIndex = 24;
            this.lblLabMate.Text = "Laboratorio Matematica";
            // 
            // txtlabMate
            // 
            this.txtlabMate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlabMate.Location = new System.Drawing.Point(554, 84);
            this.txtlabMate.Name = "txtlabMate";
            this.txtlabMate.Size = new System.Drawing.Size(48, 20);
            this.txtlabMate.TabIndex = 25;
            // 
            // cboxInformatica
            // 
            this.cboxInformatica.FormattingEnabled = true;
            this.cboxInformatica.Items.AddRange(new object[] {
            "Informatica"});
            this.cboxInformatica.Location = new System.Drawing.Point(9, 28);
            this.cboxInformatica.Name = "cboxInformatica";
            this.cboxInformatica.Size = new System.Drawing.Size(116, 21);
            this.cboxInformatica.TabIndex = 26;
            // 
            // cboxMatematica
            // 
            this.cboxMatematica.FormattingEnabled = true;
            this.cboxMatematica.Items.AddRange(new object[] {
            "Matematica"});
            this.cboxMatematica.Location = new System.Drawing.Point(9, 84);
            this.cboxMatematica.Name = "cboxMatematica";
            this.cboxMatematica.Size = new System.Drawing.Size(116, 21);
            this.cboxMatematica.TabIndex = 27;
            // 
            // MediaVoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(875, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMediaInformatica);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnLeggi);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtMediaMatematica);
            this.Controls.Add(this.lblMediaMate);
            this.Controls.Add(this.txtMediaInfo);
            this.Controls.Add(this.lblMediaVoti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxClasse);
            this.Controls.Add(this.txtNomeCognomeAlunni);
            this.Controls.Add(this.lblNomeCognomeAlunni);
            this.Controls.Add(this.lblTitolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaVoti";
            this.Text = "MediaVoti Informatica e Matematica";
            this.gboxClasse.ResumeLayout(false);
            this.gboxClasse.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblNomeCognomeAlunni;
        private System.Windows.Forms.TextBox txtNomeCognomeAlunni;
        private System.Windows.Forms.GroupBox gboxClasse;
        private System.Windows.Forms.RadioButton rdbIIC;
        private System.Windows.Forms.RadioButton rdbIC;
        private System.Windows.Forms.RadioButton rdbIIIC;
        private System.Windows.Forms.RadioButton rdbVC;
        private System.Windows.Forms.RadioButton rdbIVC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLabInfo;
        private System.Windows.Forms.Label lblLabInformatica;
        private System.Windows.Forms.TextBox txtOraleInfo;
        private System.Windows.Forms.TextBox txtScInfo;
        private System.Windows.Forms.Label lblOraleInformatica;
        private System.Windows.Forms.Label lblScrittoInformatica;
        private System.Windows.Forms.Label lblMediaVoti;
        private System.Windows.Forms.TextBox txtMediaInfo;
        private System.Windows.Forms.TextBox txtOraleMate;
        private System.Windows.Forms.Label lblOraleMate;
        private System.Windows.Forms.TextBox txtScrittoMate;
        private System.Windows.Forms.Label lblScrittoMate;
        private System.Windows.Forms.Label lblMediaMate;
        private System.Windows.Forms.TextBox txtMediaMatematica;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnLeggi;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnMediaInformatica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLabMate;
        private System.Windows.Forms.TextBox txtlabMate;
        private System.Windows.Forms.ComboBox cboxMatematica;
        private System.Windows.Forms.ComboBox cboxInformatica;
    }
}

