namespace SkolaProjekat.Forme
{
    partial class PredmetAzurirajForma
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
            tbNazivPredmeta = new TextBox();
            cbTipPredmeta = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            btnAzuriraj = new Button();
            SuspendLayout();
            // 
            // tbNazivPredmeta
            // 
            tbNazivPredmeta.Location = new Point(12, 32);
            tbNazivPredmeta.Name = "tbNazivPredmeta";
            tbNazivPredmeta.Size = new Size(127, 23);
            tbNazivPredmeta.TabIndex = 0;
            // 
            // cbTipPredmeta
            // 
            cbTipPredmeta.FormattingEnabled = true;
            cbTipPredmeta.Items.AddRange(new object[] { "Opšteobrazovni Predmet", "Stručni Predmet" });
            cbTipPredmeta.Location = new Point(12, 86);
            cbTipPredmeta.Name = "cbTipPredmeta";
            cbTipPredmeta.Size = new Size(157, 23);
            cbTipPredmeta.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Naizv Predmeta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "Tip Predmeta";
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(12, 157);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(75, 29);
            btnAzuriraj.TabIndex = 6;
            btnAzuriraj.Text = "Ažuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // PredmetAzurirajForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 198);
            Controls.Add(btnAzuriraj);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbTipPredmeta);
            Controls.Add(tbNazivPredmeta);
            MaximumSize = new Size(222, 237);
            MinimumSize = new Size(222, 237);
            Name = "PredmetAzurirajForma";
            Text = "PredmetAzurirajForma";
            Load += PredmetAzurirajForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNazivPredmeta;
        private ComboBox cbTipPredmeta;
        private Label label1;
        private Label label3;
        private Button btnAzuriraj;
    }
}