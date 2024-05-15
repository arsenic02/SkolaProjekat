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
            SuspendLayout();
            // 
            // btnUcitavanje
            // 
            btnUcitavanje.Location = new Point(55, 55);
            btnUcitavanje.Name = "btnUcitavanje";
            btnUcitavanje.Size = new Size(112, 34);
            btnUcitavanje.TabIndex = 0;
            btnUcitavanje.Text = "Ucitavanje";
            btnUcitavanje.UseVisualStyleBackColor = true;
            btnUcitavanje.Click += btnUcitavanje_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(58, 137);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 34);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodaj);
            Controls.Add(btnUcitavanje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUcitavanje;
        private Button btnDodaj;
    }
}