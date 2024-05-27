namespace SkolaProjekat.Forme
{
    partial class UcenikAzurirajForma
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
            btnAzuriraj = new Button();
            label1 = new Label();
            tbJUB = new TextBox();
            dtpDatum = new DateTimePicker();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 11);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 29;
            label4.Text = "Adresa stanovanja";
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(322, 29);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(132, 23);
            tbAdresa.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 11);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 27;
            label3.Text = "Prezime";
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(221, 29);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(95, 23);
            tbPrezime.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 11);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 25;
            label2.Text = "Ime";
            // 
            // tbIme
            // 
            tbIme.Location = new Point(123, 29);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(92, 23);
            tbIme.TabIndex = 24;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(357, 226);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(97, 33);
            btnAzuriraj.TabIndex = 23;
            btnAzuriraj.Text = "Ažuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 22;
            label1.Text = "JUB";
            label1.Click += label1_Click;
            // 
            // tbJUB
            // 
            tbJUB.Location = new Point(12, 29);
            tbJUB.Name = "tbJUB";
            tbJUB.Size = new Size(105, 23);
            tbJUB.TabIndex = 21;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(12, 74);
            dtpDatum.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(216, 23);
            dtpDatum.TabIndex = 20;
            // 
            // UcenikAzurirajForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 280);
            Controls.Add(label4);
            Controls.Add(tbAdresa);
            Controls.Add(label3);
            Controls.Add(tbPrezime);
            Controls.Add(label2);
            Controls.Add(tbIme);
            Controls.Add(btnAzuriraj);
            Controls.Add(label1);
            Controls.Add(tbJUB);
            Controls.Add(dtpDatum);
            MaximumSize = new Size(506, 319);
            MinimumSize = new Size(506, 319);
            Name = "UcenikAzurirajForma";
            Text = "UcenikAzurirajForma";
            Load += UcenikAzurirajForma_Load;
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
        private Button btnAzuriraj;
        private Label label1;
        private TextBox tbJUB;
        private DateTimePicker dtpDatum;
    }
}