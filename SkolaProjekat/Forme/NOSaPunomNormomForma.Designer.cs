﻿namespace SkolaProjekat.Forme
{
    partial class NOSaPunomNormomForma
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
            listaZaposlenih = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnDodajZaposlenog = new Button();
            btnAzuriraj = new Button();
            btnObrisi = new Button();
            SuspendLayout();
            // 
            // listaZaposlenih
            // 
            listaZaposlenih.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listaZaposlenih.FullRowSelect = true;
            listaZaposlenih.GridLines = true;
            listaZaposlenih.Location = new Point(12, 12);
            listaZaposlenih.Name = "listaZaposlenih";
            listaZaposlenih.Size = new Size(636, 333);
            listaZaposlenih.TabIndex = 0;
            listaZaposlenih.UseCompatibleStateImageBehavior = false;
            listaZaposlenih.View = View.Details;
            listaZaposlenih.SelectedIndexChanged += listaZaposlenih_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "JMBG";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ime Roditelja";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Prezime";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Adresa stanovanja";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Broj casova";
            columnHeader6.Width = 80;
            // 
            // btnDodajZaposlenog
            // 
            btnDodajZaposlenog.Location = new Point(12, 351);
            btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            btnDodajZaposlenog.Size = new Size(102, 35);
            btnDodajZaposlenog.TabIndex = 1;
            btnDodajZaposlenog.Text = "Dodaj";
            btnDodajZaposlenog.UseVisualStyleBackColor = true;
            btnDodajZaposlenog.Click += btnDodajZaposlenog_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(120, 351);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(102, 35);
            btnAzuriraj.TabIndex = 2;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(546, 352);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(102, 34);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // NOSaPunomNormomForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 424);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodajZaposlenog);
            Controls.Add(listaZaposlenih);
            MaximumSize = new Size(676, 463);
            MinimumSize = new Size(676, 463);
            Name = "NOSaPunomNormomForma";
            Text = "NOSaPunomNormomForma";
            Load += NOSaPunomNormomForma_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListView listaZaposlenih;
        private Button btnDodajZaposlenog;
        private Button btnAzuriraj;
        private Button btnObrisi;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}