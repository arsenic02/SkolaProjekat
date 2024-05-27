namespace SkolaProjekat.Forme
{
    partial class OcenaAzurirajForma
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
            tbId = new TextBox();
            label1 = new Label();
            dtpDatum = new DateTimePicker();
            btnAzuriraj = new Button();
            label2 = new Label();
            tbNazivPredmeta = new TextBox();
            label3 = new Label();
            tbNumerickaVrednost = new TextBox();
            label5 = new Label();
            tbOpis = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.Location = new Point(16, 27);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "ID Ocene";
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(237, 27);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(200, 23);
            dtpDatum.TabIndex = 2;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(340, 206);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(97, 33);
            btnAzuriraj.TabIndex = 3;
            btnAzuriraj.Text = "Ažuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 56);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "Naziv Predmeta";
            // 
            // tbNazivPredmeta
            // 
            tbNazivPredmeta.Location = new Point(16, 74);
            tbNazivPredmeta.Name = "tbNazivPredmeta";
            tbNazivPredmeta.Size = new Size(100, 23);
            tbNazivPredmeta.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 104);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 9;
            label3.Text = "Numerička vrednost ocene";
            // 
            // tbNumerickaVrednost
            // 
            tbNumerickaVrednost.Location = new Point(16, 122);
            tbNumerickaVrednost.Name = "tbNumerickaVrednost";
            tbNumerickaVrednost.Size = new Size(100, 23);
            tbNumerickaVrednost.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 150);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 13;
            label5.Text = "Tekstualni opis";
            // 
            // tbOpis
            // 
            tbOpis.Location = new Point(16, 168);
            tbOpis.Name = "tbOpis";
            tbOpis.Size = new Size(100, 23);
            tbOpis.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 9);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 14;
            label6.Text = "Datum dobijanja ocene:";
            // 
            // OcenaAzurirajForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 280);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbOpis);
            Controls.Add(label3);
            Controls.Add(tbNumerickaVrednost);
            Controls.Add(label2);
            Controls.Add(tbNazivPredmeta);
            Controls.Add(btnAzuriraj);
            Controls.Add(dtpDatum);
            Controls.Add(label1);
            Controls.Add(tbId);
            MaximumSize = new Size(506, 319);
            MinimumSize = new Size(506, 319);
            Name = "OcenaAzurirajForma";
            Text = "OcenaAzurirajForma";
            Load += OcenaAzurirajForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private Label label1;
        private DateTimePicker dtpDatum;
        private Button btnAzuriraj;
        private Label label2;
        private TextBox tbNazivPredmeta;
        private Label label3;
        private TextBox tbNumerickaVrednost;
        private Label label5;
        private TextBox tbOpis;
        private Label label6;
    }
}