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
    public partial class NOSaDelomNormeDodajForma : Form
    {
        NastavnoOsobljeSaDelomNormeBasic nastavnik;
        public NOSaDelomNormeDodajForma()
        {
            InitializeComponent();
            nastavnik = new NastavnoOsobljeSaDelomNormeBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog nastavnika?";
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

                DTOManager.dodajNastavnoOsobljeSaDelomNorme(this.nastavnik);
                MessageBox.Show("Uspesno ste dodali novog nastavnika!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
