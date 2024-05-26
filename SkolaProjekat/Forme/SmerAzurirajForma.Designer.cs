namespace SkolaProjekat.Forme
{
    partial class SmerAzurirajForma
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
            label2 = new Label();
            label1 = new Label();
            tbMaxBr = new TextBox();
            tbNazivSmera = new TextBox();
            btnAzuriraj = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 82);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 10;
            label2.Text = "Maksimalan broj ucenika";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 9;
            label1.Text = "Naziv Smera";
            // 
            // tbMaxBr
            // 
            tbMaxBr.Location = new Point(21, 100);
            tbMaxBr.Name = "tbMaxBr";
            tbMaxBr.Size = new Size(139, 23);
            tbMaxBr.TabIndex = 8;
            // 
            // tbNazivSmera
            // 
            tbNazivSmera.Location = new Point(21, 38);
            tbNazivSmera.Name = "tbNazivSmera";
            tbNazivSmera.Size = new Size(139, 23);
            tbNazivSmera.TabIndex = 7;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(21, 151);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(139, 48);
            btnAzuriraj.TabIndex = 6;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // SmerAzurirajForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(182, 213);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbMaxBr);
            Controls.Add(tbNazivSmera);
            Controls.Add(btnAzuriraj);
            Name = "SmerAzurirajForma";
            Text = "SmerAzurirajForma";
            Load += SmerAzurirajForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox tbMaxBr;
        private TextBox tbNazivSmera;
        private Button btnAzuriraj;
    }
}