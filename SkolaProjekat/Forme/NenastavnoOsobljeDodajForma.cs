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
    public partial class NenastavnoOsobljeDodajForma : Form
    {
        NenastavnoOsobljeBasic zaposleni;
        public NenastavnoOsobljeDodajForma()
        {
            InitializeComponent();
            zaposleni = new NenastavnoOsobljeBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog zaposlenog?";
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
                DTOManager.dodajNenastavnoOsoblje(this.zaposleni);
                MessageBox.Show("Azuriranje zaposlenog je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
