namespace SkolaProjekat.Forme
{
    partial class UceniciForma
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
            btnVidiOcene = new Button();
            btnObrisi = new Button();
            btnAzuriraj = new Button();
            btnDodaj = new Button();
            listaUcenika = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnVidiOcene
            // 
            btnVidiOcene.Location = new Point(323, 286);
            btnVidiOcene.Name = "btnVidiOcene";
            btnVidiOcene.Size = new Size(152, 35);
            btnVidiOcene.TabIndex = 13;
            btnVidiOcene.Text = "Pogledaj Ocene";
            btnVidiOcene.UseVisualStyleBackColor = true;
            btnVidiOcene.Click += btnVidiOcene_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(563, 287);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(102, 34);
            btnObrisi.TabIndex = 12;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(133, 286);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(102, 35);
            btnAzuriraj.TabIndex = 11;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(25, 286);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(102, 35);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // listaUcenika
            // 
            listaUcenika.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listaUcenika.FullRowSelect = true;
            listaUcenika.GridLines = true;
            listaUcenika.Location = new Point(25, 12);
            listaUcenika.Name = "listaUcenika";
            listaUcenika.Size = new Size(640, 257);
            listaUcenika.TabIndex = 9;
            listaUcenika.UseCompatibleStateImageBehavior = false;
            listaUcenika.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Jednistveni upisni broj";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prezime";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Adresa Stanovanja";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Datum Upisa";
            columnHeader5.Width = 80;
            // 
            // UceniciForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 345);
            Controls.Add(btnVidiOcene);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodaj);
            Controls.Add(listaUcenika);
            MaximumSize = new Size(705, 384);
            MinimumSize = new Size(705, 384);
            Name = "UceniciForma";
            Text = "UceniciForma";
            Load += UceniciForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVidiOcene;
        private Button btnObrisi;
        private Button btnAzuriraj;
        private Button btnDodaj;
        private ListView listaUcenika;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}