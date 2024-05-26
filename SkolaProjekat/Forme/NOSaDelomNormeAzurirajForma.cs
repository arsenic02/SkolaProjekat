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
    public partial class NOSaDelomNormeAzurirajForma : Form
    {
        NastavnoOsobljeSaDelomNormeBasic nastavnik;
        public NOSaDelomNormeAzurirajForma()
        {
            InitializeComponent();
        }

        public NOSaDelomNormeAzurirajForma(NastavnoOsobljeSaDelomNormeBasic n)
        {
            InitializeComponent();
            this.nastavnik = n;
        }

        private void NOSaDelomNormeAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE NASTAVNIKA {nastavnik.Ime.ToUpper()} {nastavnik.Prezime.ToUpper()}";
        }
        private void popuniPodacima()
        {
            tbIme.Text = this.nastavnik.Ime;
            tbImeRoditelja.Text = this.nastavnik.ImeRoditelja;
            tbPrezime.Text = this.nastavnik.Prezime;
            tbJMBG.Text = this.nastavnik.JMBG;
            tbAdresa.Text = this.nastavnik.AdresaStanovanja;
            tbBrojCasova.Text = this.nastavnik.BrojCasovaNedeljno.ToString();
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene nastavnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.nastavnik.Ime = tbIme.Text;
                this.nastavnik.ImeRoditelja = tbImeRoditelja.Text;
                this.nastavnik.Prezime = tbPrezime.Text;
                this.nastavnik.JMBG = tbJMBG.Text;
                this.nastavnik.AdresaStanovanja = tbAdresa.Text;
                this.nastavnik.BrojCasovaNedeljno = Int32.Parse(tbBrojCasova.Text);
                DTOManager.azurirajNastavnoOsobljeSaDelomNorme(this.nastavnik);
                MessageBox.Show("Azuriranje nastavnika je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
