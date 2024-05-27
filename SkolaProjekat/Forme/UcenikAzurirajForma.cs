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
    public partial class UcenikAzurirajForma : Form
    {
        UcenikBasic ucenik;
        public UcenikAzurirajForma()
        {
            InitializeComponent();
        }
        public UcenikAzurirajForma(UcenikBasic u)
        {
            InitializeComponent();
            ucenik = u;
        }
        private void popuniPodacima()
        {
            tbJUB.Text = ucenik.JedinstveniUpisniBroj;
            tbIme.Text = ucenik.Ime;
            tbPrezime.Text = ucenik.Prezime;
            tbAdresa.Text = ucenik.AdresaStanovanja;
            dtpDatum.Value = ucenik.DatumUpisa;
        }
        private void UcenikAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE UCENIKA {ucenik.JedinstveniUpisniBroj}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da azurirate ucenika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                ucenik.JedinstveniUpisniBroj = tbJUB.Text;
                ucenik.Ime = tbIme.Text;
                ucenik.Prezime = tbPrezime.Text;
                ucenik.AdresaStanovanja = tbAdresa.Text;
                ucenik.DatumUpisa = dtpDatum.Value;
                DTOManager.azurirajUcenika(ucenik);
                this.Close();
            }
        }
    }
}
