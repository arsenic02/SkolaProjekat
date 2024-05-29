namespace SkolaProjekat.Forme
{
    partial class OcenaDodajForma
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
            label6 = new Label();
            label5 = new Label();
            tbOpis = new TextBox();
            label3 = new Label();
            tbNumerickaVrednost = new TextBox();
            label2 = new Label();
            btnDodaj = new Button();
            dtpDatum = new DateTimePicker();
            label1 = new Label();
            tbId = new TextBox();
            cbNazivPredmeta = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 12);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 27;
            label6.Text = "Datum dobijanja ocene:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 106);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 26;
            label5.Text = "Tekstualni opis";
            // 
            // tbOpis
            // 
            tbOpis.Location = new Point(12, 124);
            tbOpis.Name = "tbOpis";
            tbOpis.Size = new Size(100, 23);
            tbOpis.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 24;
            label3.Text = "Numerička vrednost ocene";
            // 
            // tbNumerickaVrednost
            // 
            tbNumerickaVrednost.Location = new Point(12, 78);
            tbNumerickaVrednost.Name = "tbNumerickaVrednost";
            tbNumerickaVrednost.Size = new Size(100, 23);
            tbNumerickaVrednost.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 153);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 20;
            label2.Text = "Naziv Predmeta";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(335, 209);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(97, 33);
            btnDodaj.TabIndex = 18;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(232, 30);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(200, 23);
            dtpDatum.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 16;
            label1.Text = "ID Ocene";
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Location = new Point(11, 30);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 15;
            // 
            // cbNazivPredmeta
            // 
            cbNazivPredmeta.FormattingEnabled = true;
            cbNazivPredmeta.Location = new Point(12, 171);
            cbNazivPredmeta.Name = "cbNazivPredmeta";
            cbNazivPredmeta.Size = new Size(205, 23);
            cbNazivPredmeta.TabIndex = 28;
            // 
            // OcenaDodajForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 280);
            Controls.Add(cbNazivPredmeta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbOpis);
            Controls.Add(label3);
            Controls.Add(tbNumerickaVrednost);
            Controls.Add(label2);
            Controls.Add(btnDodaj);
            Controls.Add(dtpDatum);
            Controls.Add(label1);
            Controls.Add(tbId);
            MaximumSize = new Size(506, 319);
            MinimumSize = new Size(506, 319);
            Name = "OcenaDodajForma";
            Text = "OcenaDodajForma";
            Load += OcenaDodajForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TextBox tbOpis;
        private Label label3;
        private TextBox tbNumerickaVrednost;
        private Label label2;
        private Button btnDodaj;
        private DateTimePicker dtpDatum;
        private Label label1;
        private TextBox tbId;
        private ComboBox cbNazivPredmeta;
    }
}