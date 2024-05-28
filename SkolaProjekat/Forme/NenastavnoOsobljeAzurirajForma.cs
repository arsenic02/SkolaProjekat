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
    public partial class NenastavnoOsobljeAzurirajForma : Form
    {
        NenastavnoOsobljeBasic zaposleni;
        public NenastavnoOsobljeAzurirajForma()
        {
            InitializeComponent();
        }
        public NenastavnoOsobljeAzurirajForma(NenastavnoOsobljeBasic n)
        {
            InitializeComponent();
            this.zaposleni = n;
        }

        private void NenastavnoOsobljeAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE NASTAVNIKA {zaposleni.Ime.ToUpper()} {zaposleni.Prezime.ToUpper()}";
            tbJMBG.Enabled = false;
        }
        private void popuniPodacima()
        {
            tbIme.Text = this.zaposleni.Ime;
            tbImeRoditelja.Text = this.zaposleni.ImeRoditelja;
            tbPrezime.Text = this.zaposleni.Prezime;
            tbJMBG.Text = this.zaposleni.JMBG;
            tbAdresa.Text = this.zaposleni.AdresaStanovanja;
            tbStrucnaSprema.Text = this.zaposleni.StrucnaSprema;
            tbImeSektora.Text = this.zaposleni.ImeSektora;
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.zaposleni.Ime = tbIme.Text;
                this.zaposleni.ImeRoditelja = tbImeRoditelja.Text;
                this.zaposleni.Prezime = tbPrezime.Text;
                this.zaposleni.JMBG = tbJMBG.Text;
                this.zaposleni.AdresaStanovanja = tbAdresa.Text;
                this.zaposleni.ImeSektora = tbImeSektora.Text;
                this.zaposleni.StrucnaSprema = tbStrucnaSprema.Text;
                DTOManager.azurirajNenastavnoOsoblje(this.zaposleni);
                MessageBox.Show("Azuriranje zaposlenog je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
