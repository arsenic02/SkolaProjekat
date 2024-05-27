namespace SkolaProjekat.Forme
{
    partial class OceneForma
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
            btnDodaj = new Button();
            listaOcena = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(641, 285);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(102, 34);
            btnObrisi.TabIndex = 12;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(120, 284);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(102, 35);
            btnAzuriraj.TabIndex = 11;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(12, 284);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(102, 35);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // listaOcena
            // 
            listaOcena.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listaOcena.FullRowSelect = true;
            listaOcena.GridLines = true;
            listaOcena.Location = new Point(12, 21);
            listaOcena.Name = "listaOcena";
            listaOcena.Size = new Size(731, 257);
            listaOcena.TabIndex = 9;
            listaOcena.UseCompatibleStateImageBehavior = false;
            listaOcena.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Naziv Predmeta";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "JUB";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Datum Dobijanja";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Numericka vrednost";
            columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Opis";
            columnHeader8.Width = 200;
            // 
            // OceneForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 339);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodaj);
            Controls.Add(listaOcena);
            MaximumSize = new Size(775, 378);
            MinimumSize = new Size(775, 378);
            Name = "OceneForma";
            Text = "UcenikOceneForma";
            Load += OceneForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnObrisi;
        private Button btnAzuriraj;
        private Button btnDodaj;
        private ListView listaOcena;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}