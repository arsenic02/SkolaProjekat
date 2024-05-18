namespace SkolaProjekat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUcitavanje = new Button();
            btnDodaj = new Button();
            btnManyToOne = new Button();
            btnOneToMany = new Button();
            btnUcitavanjeRazreda = new Button();
            btnDodavanjeUcenika = new Button();
            btnManyToMany = new Button();
            SuspendLayout();
            // 
            // btnUcitavanje
            // 
            btnUcitavanje.Location = new Point(55, 55);
            btnUcitavanje.Name = "btnUcitavanje";
            btnUcitavanje.Size = new Size(148, 34);
            btnUcitavanje.TabIndex = 0;
            btnUcitavanje.Text = "Ucitavanje";
            btnUcitavanje.UseVisualStyleBackColor = true;
            btnUcitavanje.Click += btnUcitavanje_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(58, 137);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(145, 34);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnManyToOne
            // 
            btnManyToOne.Location = new Point(61, 204);
            btnManyToOne.Name = "btnManyToOne";
            btnManyToOne.Size = new Size(142, 34);
            btnManyToOne.TabIndex = 2;
            btnManyToOne.Text = "Many-to-one";
            btnManyToOne.UseVisualStyleBackColor = true;
            btnManyToOne.Click += btnManyToOne_Click;
            // 
            // btnOneToMany
            // 
            btnOneToMany.Location = new Point(60, 271);
            btnOneToMany.Name = "btnOneToMany";
            btnOneToMany.Size = new Size(143, 34);
            btnOneToMany.TabIndex = 3;
            btnOneToMany.Text = "One-to-many";
            btnOneToMany.UseVisualStyleBackColor = true;
            btnOneToMany.Click += btnOneToMany_Click;
            // 
            // btnUcitavanjeRazreda
            // 
            btnUcitavanjeRazreda.Location = new Point(310, 59);
            btnUcitavanjeRazreda.Name = "btnUcitavanjeRazreda";
            btnUcitavanjeRazreda.Size = new Size(217, 71);
            btnUcitavanjeRazreda.TabIndex = 4;
            btnUcitavanjeRazreda.Text = "Ucitavanje razreda";
            btnUcitavanjeRazreda.UseVisualStyleBackColor = true;
            btnUcitavanjeRazreda.Click += btnUcitavanjeRazreda_Click;
            // 
            // btnDodavanjeUcenika
            // 
            btnDodavanjeUcenika.Location = new Point(308, 170);
            btnDodavanjeUcenika.Name = "btnDodavanjeUcenika";
            btnDodavanjeUcenika.Size = new Size(219, 34);
            btnDodavanjeUcenika.TabIndex = 5;
            btnDodavanjeUcenika.Text = "Dodavanje ucenika";
            btnDodavanjeUcenika.UseVisualStyleBackColor = true;
            btnDodavanjeUcenika.Click += btnDodavanjeUcenika_Click;
            // 
            // btnManyToMany
            // 
            btnManyToMany.Location = new Point(310, 251);
            btnManyToMany.Name = "btnManyToMany";
            btnManyToMany.Size = new Size(226, 34);
            btnManyToMany.TabIndex = 6;
            btnManyToMany.Text = "Many-to-many";
            btnManyToMany.UseVisualStyleBackColor = true;
            btnManyToMany.Click += btnManyToMany_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnManyToMany);
            Controls.Add(btnDodavanjeUcenika);
            Controls.Add(btnUcitavanjeRazreda);
            Controls.Add(btnOneToMany);
            Controls.Add(btnManyToOne);
            Controls.Add(btnDodaj);
            Controls.Add(btnUcitavanje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUcitavanje;
        private Button btnDodaj;
        private Button btnManyToOne;
        private Button btnOneToMany;
        private Button btnUcitavanjeRazreda;
        private Button btnDodavanjeUcenika;
        private Button btnManyToMany;
    }
}