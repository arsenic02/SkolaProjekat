namespace SkolaProjekat.Forme
{
    partial class ZaposleniForma
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
            btnNastavnoOsobljeSaPunomNormomForma = new Button();
            btnNastavnoOsobljeSaDelomNormeForma = new Button();
            btnNenastavnoOsobljeForma = new Button();
            SuspendLayout();
            // 
            // btnNastavnoOsobljeSaPunomNormomForma
            // 
            btnNastavnoOsobljeSaPunomNormomForma.Location = new Point(94, 85);
            btnNastavnoOsobljeSaPunomNormomForma.Name = "btnNastavnoOsobljeSaPunomNormomForma";
            btnNastavnoOsobljeSaPunomNormomForma.Size = new Size(187, 72);
            btnNastavnoOsobljeSaPunomNormomForma.TabIndex = 0;
            btnNastavnoOsobljeSaPunomNormomForma.Text = "Nastavno osoblje sa punom normom";
            btnNastavnoOsobljeSaPunomNormomForma.UseVisualStyleBackColor = true;
            btnNastavnoOsobljeSaPunomNormomForma.Click += btnNastavnoOsobljeSaPunomNormomForma_Click;
            // 
            // btnNastavnoOsobljeSaDelomNormeForma
            // 
            btnNastavnoOsobljeSaDelomNormeForma.Location = new Point(94, 163);
            btnNastavnoOsobljeSaDelomNormeForma.Name = "btnNastavnoOsobljeSaDelomNormeForma";
            btnNastavnoOsobljeSaDelomNormeForma.Size = new Size(187, 72);
            btnNastavnoOsobljeSaDelomNormeForma.TabIndex = 1;
            btnNastavnoOsobljeSaDelomNormeForma.Text = "Nastavno osoblje sa delom norme";
            btnNastavnoOsobljeSaDelomNormeForma.UseVisualStyleBackColor = true;
            btnNastavnoOsobljeSaDelomNormeForma.Click += btnNastavnoOsobljeSaDelomNormeForma_Click;
            // 
            // btnNenastavnoOsobljeForma
            // 
            btnNenastavnoOsobljeForma.Location = new Point(94, 241);
            btnNenastavnoOsobljeForma.Name = "btnNenastavnoOsobljeForma";
            btnNenastavnoOsobljeForma.Size = new Size(187, 72);
            btnNenastavnoOsobljeForma.TabIndex = 2;
            btnNenastavnoOsobljeForma.Text = "Nenastavno osoblje";
            btnNenastavnoOsobljeForma.UseVisualStyleBackColor = true;
            btnNenastavnoOsobljeForma.Click += btnNenastavnoOsobljeForma_Click;
            // 
            // ZaposleniForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 433);
            Controls.Add(btnNenastavnoOsobljeForma);
            Controls.Add(btnNastavnoOsobljeSaDelomNormeForma);
            Controls.Add(btnNastavnoOsobljeSaPunomNormomForma);
            MaximumSize = new Size(400, 472);
            MinimumSize = new Size(400, 472);
            Name = "ZaposleniForma";
            Text = "ZaposleniForma";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNastavnoOsobljeSaPunomNormomForma;
        private Button btnNastavnoOsobljeSaDelomNormeForma;
        private Button btnNenastavnoOsobljeForma;
    }
}