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
    public partial class NOSaDelomNormeForma : Form
    {
        public NOSaDelomNormeForma()
        {
            InitializeComponent();
        }


        private void popuniPodacima()
        {
            listaZaposlenih.Items.Clear();
            List<NastavnoOsobljeSaDelomNormePregled> podaci = DTOManager.vratiSveNastavnikeSaDelomNorme();

            foreach (NastavnoOsobljeSaDelomNormePregled n in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { n.JMBG, n.Ime, n.ImeRoditelja, n.Prezime, n.AdresaStanovanja, n.BrojCasovaNedeljno.ToString() });
                listaZaposlenih.Items.Add(item);
            }
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {

            NOSaDelomNormeDodajForma forma = new NOSaDelomNormeDodajForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listaZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nastavnika cije podatke zelite da izmenite!");
                return;
            }
            string jmbg = listaZaposlenih.SelectedItems[0].SubItems[0].Text;
            NastavnoOsobljeSaDelomNormeBasic nastavnik = DTOManager.vratiNastavnikaSaDelomNorme(jmbg);
            NOSaDelomNormeAzurirajForma forma = new NOSaDelomNormeAzurirajForma(nastavnik);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nastavnika koga zelite da obrisete!");
                return;
            }
            string jmbg = listaZaposlenih.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog nastavnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiNastavnoOsobljeDelomNorme(jmbg);
                MessageBox.Show("Brisanje nastavnika je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void NOSaDelomNormeForma_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
