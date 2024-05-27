namespace SkolaProjekat.Forme
{
    partial class PredmetDodajForma
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
            tbnDodaj = new Button();
            label3 = new Label();
            label1 = new Label();
            cbTipPredmeta = new ComboBox();
            tbNazivPredmeta = new TextBox();
            SuspendLayout();
            // 
            // tbnDodaj
            // 
            tbnDodaj.Location = new Point(12, 152);
            tbnDodaj.Name = "tbnDodaj";
            tbnDodaj.Size = new Size(75, 29);
            tbnDodaj.TabIndex = 11;
            tbnDodaj.Text = "Dodaj";
            tbnDodaj.UseVisualStyleBackColor = true;
            tbnDodaj.Click += tbnDodaj_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 10;
            label3.Text = "Tip Predmeta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 9;
            label1.Text = "Naizv Predmeta";
            // 
            // cbTipPredmeta
            // 
            cbTipPredmeta.FormattingEnabled = true;
            cbTipPredmeta.Items.AddRange(new object[] { "Opšteobrazovni Predmet", "Stručni Predmet" });
            cbTipPredmeta.Location = new Point(12, 81);
            cbTipPredmeta.Name = "cbTipPredmeta";
            cbTipPredmeta.Size = new Size(157, 23);
            cbTipPredmeta.TabIndex = 8;
            // 
            // tbNazivPredmeta
            // 
            tbNazivPredmeta.Location = new Point(12, 27);
            tbNazivPredmeta.Name = "tbNazivPredmeta";
            tbNazivPredmeta.Size = new Size(127, 23);
            tbNazivPredmeta.TabIndex = 7;
            // 
            // PredmetDodajForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 198);
            Controls.Add(tbnDodaj);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbTipPredmeta);
            Controls.Add(tbNazivPredmeta);
            MaximumSize = new Size(222, 237);
            MinimumSize = new Size(222, 237);
            Name = "PredmetDodajForma";
            Text = "PredmetDodajForma";
            Load += PredmetDodajForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tbnDodaj;
        private Label label3;
        private Label label1;
        private ComboBox cbTipPredmeta;
        private TextBox tbNazivPredmeta;
    }
}