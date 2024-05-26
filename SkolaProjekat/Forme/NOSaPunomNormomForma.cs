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
    public partial class NOSaPunomNormomForma : Form
    {
        public NOSaPunomNormomForma()
        {
            InitializeComponent();
        }

        private void NOSaPunomNormomForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listaZaposlenih.Items.Clear();
            List<NastavnoOsobljeSaPunomNormomPregled> podaci = DTOManager.vratiSveNastavnikeSaPunomNormom();

            foreach (NastavnoOsobljeSaPunomNormomPregled n in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { n.JMBG, n.Ime, n.ImeRoditelja, n.Prezime, n.AdresaStanovanja, n.BrojCasova.ToString() });
                listaZaposlenih.Items.Add(item);
            }

        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            NOSaPunomNormomDodajForma forma = new NOSaPunomNormomDodajForma();
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
            NastavnoOsobljeSaPunomNormomBasic nastavnik = DTOManager.vratiNastavnikaSaPunomNormom(jmbg);
            NOSaPunomNormomAzurirajForma forma = new NOSaPunomNormomAzurirajForma(nastavnik);
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
                DTOManager.obrisiNastavnoOsobljeSaPunomNormom(jmbg);
                MessageBox.Show("Brisanje nastavnika je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void listaZaposlenih_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NOSaPunomNormomForma_Load_1(object sender, EventArgs e)
        {

        }
    }
}
