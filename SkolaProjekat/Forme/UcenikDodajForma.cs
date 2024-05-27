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
    public partial class UcenikDodajForma : Form
    {
        UcenikBasic ucenik;
        public UcenikDodajForma()
        {
            InitializeComponent();
            ucenik = new UcenikBasic();
        }

        private void UcenikDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog ucenika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                ucenik.JedinstveniUpisniBroj = tbJUB.Text;
                ucenik.Ime = tbIme.Text;
                ucenik.Prezime = tbPrezime.Text;
                ucenik.AdresaStanovanja=tbAdresa.Text;
                ucenik.DatumUpisa = dtpDatum.Value;

                DTOManager.dodajUcenika(ucenik);
                this.Close();
            }
        }
    }
}
