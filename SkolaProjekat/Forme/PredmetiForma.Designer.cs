namespace SkolaProjekat.Forme
{
    partial class PredmetiForma
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
            btnDodaj = new Button();
            listaPredmeta = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(223, 295);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(90, 34);
            btnObrisi.TabIndex = 15;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(223, 41);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(90, 35);
            btnDodaj.TabIndex = 13;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // listaPredmeta
            // 
            listaPredmeta.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9 });
            listaPredmeta.FullRowSelect = true;
            listaPredmeta.GridLines = true;
            listaPredmeta.Location = new Point(12, 13);
            listaPredmeta.Name = "listaPredmeta";
            listaPredmeta.Size = new Size(205, 316);
            listaPredmeta.TabIndex = 12;
            listaPredmeta.UseCompatibleStateImageBehavior = false;
            listaPredmeta.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Naziv Predmeta";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Tip Predmeta";
            columnHeader9.Width = 100;
            // 
            // PredmetiForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 345);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(listaPredmeta);
            MaximumSize = new Size(358, 384);
            MinimumSize = new Size(358, 384);
            Name = "PredmetiForma";
            Text = "PredmetiForma";
            Load += PredmetiForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnObrisi;
        private Button btnDodaj;
        private ListView listaPredmeta;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}