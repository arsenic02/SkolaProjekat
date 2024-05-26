namespace SkolaProjekat.Forme
{
    partial class SmerDodajForma
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
            btnDodaj = new Button();
            tbNazivSmera = new TextBox();
            tbMaxBr = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(39, 143);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(139, 48);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // tbNazivSmera
            // 
            tbNazivSmera.Location = new Point(39, 30);
            tbNazivSmera.Name = "tbNazivSmera";
            tbNazivSmera.Size = new Size(139, 23);
            tbNazivSmera.TabIndex = 2;
            // 
            // tbMaxBr
            // 
            tbMaxBr.Location = new Point(39, 92);
            tbMaxBr.Name = "tbMaxBr";
            tbMaxBr.Size = new Size(139, 23);
            tbMaxBr.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Naziv Smera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 74);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 5;
            label2.Text = "Maksimalan broj ucenika";
            // 
            // SmerDodajForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 228);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbMaxBr);
            Controls.Add(tbNazivSmera);
            Controls.Add(btnDodaj);
            MaximumSize = new Size(245, 267);
            MinimumSize = new Size(245, 267);
            Name = "SmerDodajForma";
            Text = "SmerDodajForma";
            Load += SmerDodajForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodaj;
        private TextBox tbNazivSmera;
        private TextBox tbMaxBr;
        private Label label1;
        private Label label2;
    }
}