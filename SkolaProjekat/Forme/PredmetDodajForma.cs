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
    public partial class PredmetDodajForma : Form
    {
        PredmetBasic predmet;
        string NazivSmera;
        public PredmetDodajForma()
        {
            InitializeComponent();
            predmet = new PredmetBasic();
        }
        public PredmetDodajForma(string nazivSmera)
        {
            InitializeComponent();
            predmet = new PredmetBasic();
            NazivSmera = nazivSmera;
        }

        private void PredmetDodajForma_Load(object sender, EventArgs e)
        {

        }
        private void tbnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da azurirate predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                predmet.NazivPredmeta = tbNazivPredmeta.Text;
                predmet.TipPredmeta = cbTipPredmeta.SelectedItem.ToString();
                predmet.NazivSmera = NazivSmera;
                DTOManager.azurirajPredmet(predmet);
                this.Close();
            }
        }
    }
}
