using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkolaProjekat.Forme
{
    public partial class PredmetAzurirajForma : Form
    {
        PredmetBasic predmet;
        public PredmetAzurirajForma()
        {
            InitializeComponent();
        }
        public PredmetAzurirajForma(PredmetBasic p)
        {
            InitializeComponent();
            predmet = p;
            popuniPodacima();
            this.Text = $"AZURIRANJE PREDMETA{predmet.NazivSmera.ToUpper()}";
        }

        private void PredmetAzurirajForma_Load(object sender, EventArgs e)
        {

        }
        private void popuniPodacima()
        {
            tbNazivPredmeta.Text = this.predmet.NazivPredmeta;
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string nazivPredmeta = tbNazivPredmeta.Text;
            string tipPredmeta = cbTipPredmeta.SelectedItem.ToString();
            string poruka = "Da li zelite da azurirate predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                predmet.NazivPredmeta = nazivPredmeta;
                predmet.TipPredmeta = tipPredmeta;
                DTOManager.azurirajPredmet(predmet);
                this.Close();
            }

        }
    }
}
