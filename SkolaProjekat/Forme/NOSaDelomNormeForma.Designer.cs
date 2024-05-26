namespace SkolaProjekat.Forme
{
    partial class NOSaDelomNormeForma
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
            btnObrisi = new Button();
            btnAzuriraj = new Button();
            btnDodajZaposlenog = new Button();
            listaZaposlenih = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(526, 116);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(102, 34);
            btnObrisi.TabIndex = 7;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(526, 75);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(102, 35);
            btnAzuriraj.TabIndex = 6;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // btnDodajZaposlenog
            // 
            btnDodajZaposlenog.Location = new Point(526, 34);
            btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            btnDodajZaposlenog.Size = new Size(102, 35);
            btnDodajZaposlenog.TabIndex = 5;
            btnDodajZaposlenog.Text = "Dodaj";
            btnDodajZaposlenog.UseVisualStyleBackColor = true;
            btnDodajZaposlenog.Click += btnDodajZaposlenog_Click;
            // 
            // listaZaposlenih
            // 
            listaZaposlenih.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listaZaposlenih.FullRowSelect = true;
            listaZaposlenih.GridLines = true;
            listaZaposlenih.Location = new Point(12, 12);
            listaZaposlenih.Name = "listaZaposlenih";
            listaZaposlenih.Size = new Size(489, 393);
            listaZaposlenih.TabIndex = 4;
            listaZaposlenih.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "JMBG";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ime Roditelja";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Prezime";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Adresa stanovanja";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Broj casova nedeljno";
            // 
            // NOSaDelomNormeForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 450);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodajZaposlenog);
            Controls.Add(listaZaposlenih);
            Name = "NOSaDelomNormeForma";
            Text = "NOSaDelomCasovaForma";
            Load += NOSaDelomNormeForma_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnObrisi;
        private Button btnAzuriraj;
        private Button btnDodajZaposlenog;
        private ListView listaZaposlenih;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}