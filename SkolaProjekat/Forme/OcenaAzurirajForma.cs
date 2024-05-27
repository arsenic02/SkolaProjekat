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

namespace SkolaProjekat.Forme
{
    public partial class OcenaAzurirajForma : Form
    {
        OcenaBasic ocena;
        public OcenaAzurirajForma()
        {
            InitializeComponent();
        }
        public OcenaAzurirajForma(OcenaBasic o)
        {
            InitializeComponent();
            ocena = o;
            popuniPodacima();
            this.Text = $"AZURIRANJE OCENE {ocena.Id.ToString().ToUpper()}";
        }

        private void popuniPodacima()
        {
            tbId.Text = ocena.Id.ToString();
            tbNazivPredmeta.Text = ocena.NazivPredmeta;
            tbNumerickaVrednost.Text = ocena.NumerickaVrednost.ToString();
            tbOpis.Text = ocena.TekstualniOpis;
            dtpDatum.Value = ocena.DatumDobijanjaOcene;
        }

        private void OcenaAzurirajForma_Load(object sender, EventArgs e)
        {

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da azurirate ocenu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                ocena.Id = Int32.Parse(tbId.Text);
                ocena.NazivPredmeta = tbNazivPredmeta.Text;
                ocena.NumerickaVrednost = Int32.Parse(tbNumerickaVrednost.Text);
                ocena.TekstualniOpis = tbOpis.Text;
                ocena.DatumDobijanjaOcene = dtpDatum.Value;
                DTOManager.azurirajOcenu(ocena);
                this.Close();
            }
        }
    }
}
