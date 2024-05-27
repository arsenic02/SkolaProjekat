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
    public partial class UceniciForma : Form
    {
        public UceniciForma()
        {
            InitializeComponent();
        }
        private void popuniPodacima()
        {
            listaUcenika.Items.Clear();
            List<UcenikPregled> podaci = DTOManager.vratiSveUcenike();

            foreach (UcenikPregled n in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { n.JedinstveniUpisniBroj,n.Ime,n.Prezime,n.AdresaStanovanja,n.DatumUpisa.ToString()});
                listaUcenika.Items.Add(item);
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UcenikDodajForma forma = new UcenikDodajForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listaUcenika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ucenika cije podatke zelite da izmenite!");
                return;
            }
            string jub = listaUcenika.SelectedItems[0].SubItems[0].Text;
            UcenikBasic ucenik = DTOManager.vratiUcenika(jub);
            UcenikAzurirajForma forma = new UcenikAzurirajForma(ucenik);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnVidiOcene_Click(object sender, EventArgs e)
        {
            if (listaUcenika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ucenika kojeg zelite da pogledate!");
                return;
            }
            string jub = listaUcenika.SelectedItems[0].SubItems[0].Text;
            OceneForma form = new OceneForma(jub);
            form.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaUcenika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ucenika kojeg zelite da obrisete!");
                return;
            }
            string jub = listaUcenika.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog ucenika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiUcenika(jub);
                MessageBox.Show("Brisanje ucenika je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
