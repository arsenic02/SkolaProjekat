using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkolaProjekat.Forme
{
    public partial class SmerAzurirajForma : Form
    {
        SmerBasic smer;
        public SmerAzurirajForma()
        {
            InitializeComponent();
        }
        public SmerAzurirajForma(SmerBasic s)
        {
            InitializeComponent();
            smer = s;
        }

        private void popuniPodacima()
        {
            tbNazivSmera.Text = this.smer.NazivSmera;
            tbMaxBr.Text = this.smer.MaksimalanBrojUcenika.ToString();
        }
        private void SmerAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE SMERA{smer.NazivSmera.ToUpper()}";
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da azurirate smer?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.smer.NazivSmera = tbNazivSmera.Text;
                this.smer.MaksimalanBrojUcenika = Int32.Parse(tbMaxBr.Text);
                DTOManager.azurirajSmer(smer);
                this.Close();
            }
        }
    }
}
