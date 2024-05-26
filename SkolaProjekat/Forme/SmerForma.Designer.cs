namespace SkolaProjekat.Forme
{
    partial class SmerForma
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
            btnDodajSmer = new Button();
            listaSmerova = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnVidiPredmet = new Button();
            SuspendLayout();
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(264, 226);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(102, 34);
            btnObrisi.TabIndex = 7;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(264, 80);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(102, 35);
            btnAzuriraj.TabIndex = 6;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // btnDodajSmer
            // 
            btnDodajSmer.Location = new Point(264, 39);
            btnDodajSmer.Name = "btnDodajSmer";
            btnDodajSmer.Size = new Size(102, 35);
            btnDodajSmer.TabIndex = 5;
            btnDodajSmer.Text = "Dodaj";
            btnDodajSmer.UseVisualStyleBackColor = true;
            btnDodajSmer.Click += btnDodajSmer_Click;
            // 
            // listaSmerova
            // 
            listaSmerova.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3 });
            listaSmerova.FullRowSelect = true;
            listaSmerova.GridLines = true;
            listaSmerova.Location = new Point(12, 12);
            listaSmerova.Name = "listaSmerova";
            listaSmerova.Size = new Size(246, 257);
            listaSmerova.TabIndex = 4;
            listaSmerova.UseCompatibleStateImageBehavior = false;
            listaSmerova.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv Smera";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Max Br. Ucenika";
            columnHeader3.Width = 120;
            // 
            // btnVidiPredmet
            // 
            btnVidiPredmet.Location = new Point(264, 146);
            btnVidiPredmet.Name = "btnVidiPredmet";
            btnVidiPredmet.Size = new Size(102, 47);
            btnVidiPredmet.TabIndex = 8;
            btnVidiPredmet.Text = "Pogledaj Predmet";
            btnVidiPredmet.UseVisualStyleBackColor = true;
            btnVidiPredmet.Click += btnVidiPredmet_Click;
            // 
            // SmerForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 290);
            Controls.Add(btnVidiPredmet);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodajSmer);
            Controls.Add(listaSmerova);
            MaximumSize = new Size(420, 329);
            MinimumSize = new Size(420, 329);
            Name = "SmerForma";
            Text = "SmerForma";
            Load += SmerForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnObrisi;
        private Button btnAzuriraj;
        private Button btnDodajSmer;
        private ListView listaSmerova;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnVidiPredmet;
    }
}