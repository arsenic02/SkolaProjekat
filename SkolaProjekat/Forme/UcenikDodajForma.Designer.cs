namespace SkolaProjekat.Forme
{
    partial class UcenikDodajForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            tbAdresa = new TextBox();
            label3 = new Label();
            tbPrezime = new TextBox();
            label2 = new Label();
            tbIme = new TextBox();
            label1 = new Label();
            tbJUB = new TextBox();
            dtpDatum = new DateTimePicker();
            btnDodaj = new Button();
            cbRazred = new ComboBox();
            cbSmer = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 15);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 38;
            label4.Text = "Adresa stanovanja";
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(323, 33);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(132, 23);
            tbAdresa.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 15);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 36;
            label3.Text = "Prezime";
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(222, 33);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(95, 23);
            tbPrezime.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 15);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 34;
            label2.Text = "Ime";
            // 
            // tbIme
            // 
            tbIme.Location = new Point(124, 33);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(92, 23);
            tbIme.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 32;
            label1.Text = "JUB";
            // 
            // tbJUB
            // 
            tbJUB.Location = new Point(13, 33);
            tbJUB.Name = "tbJUB";
            tbJUB.Size = new Size(105, 23);
            tbJUB.TabIndex = 31;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(13, 78);
            dtpDatum.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(216, 23);
            dtpDatum.TabIndex = 30;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(364, 232);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(91, 30);
            btnDodaj.TabIndex = 29;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cbRazred
            // 
            cbRazred.FormattingEnabled = true;
            cbRazred.Location = new Point(12, 156);
            cbRazred.Name = "cbRazred";
            cbRazred.Size = new Size(121, 23);
            cbRazred.TabIndex = 39;
            // 
            // cbSmer
            // 
            cbSmer.FormattingEnabled = true;
            cbSmer.Location = new Point(166, 156);
            cbSmer.Name = "cbSmer";
            cbSmer.Size = new Size(121, 23);
            cbSmer.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 138);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 41;
            label5.Text = "Razred:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 138);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 42;
            label6.Text = "Smer:";
            // 
            // UcenikDodajForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 280);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbSmer);
            Controls.Add(cbRazred);
            Controls.Add(label4);
            Controls.Add(tbAdresa);
            Controls.Add(label3);
            Controls.Add(tbPrezime);
            Controls.Add(label2);
            Controls.Add(tbIme);
            Controls.Add(label1);
            Controls.Add(tbJUB);
            Controls.Add(dtpDatum);
            Controls.Add(btnDodaj);
            MaximumSize = new Size(506, 319);
            MinimumSize = new Size(506, 319);
            Name = "UcenikDodajForma";
            Text = "UcenikDodajForma";
            Load += UcenikDodajForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox tbAdresa;
        private Label label3;
        private TextBox tbPrezime;
        private Label label2;
        private TextBox tbIme;
        private Label label1;
        private TextBox tbJUB;
        private DateTimePicker dtpDatum;
        private Button btnDodaj;
        private ComboBox cbRazred;
        private ComboBox cbSmer;
        private Label label5;
        private Label label6;
    }
}