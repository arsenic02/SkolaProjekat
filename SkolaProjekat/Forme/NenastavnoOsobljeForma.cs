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
    public partial class NenastavnoOsobljeForma : Form
    {
        public NenastavnoOsobljeForma()
        {
            InitializeComponent();
        }
        public void NenastavnoOsobljeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            listaZaposlenih.Items.Clear();
            List<NenastavnoOsobljePregled> podaci = DTOManager.vratiSvoNenastavnoOsoblje();

            foreach (NenastavnoOsobljePregled n in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { n.JMBG, n.Ime, n.ImeRoditelja, n.Prezime, n.AdresaStanovanja, n.StrucnaSprema, n.ImeSektora });
                listaZaposlenih.Items.Add(item);
            }
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            NenastavnoOsobljeDodajForma forma = new NenastavnoOsobljeDodajForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listaZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog cije podatke zelite da izmenite!");
                return;
            }
            string jmbg = listaZaposlenih.SelectedItems[0].SubItems[0].Text;
            NenastavnoOsobljeBasic nastavnik = DTOManager.vratiNenastavnoOsoblje(jmbg);
            NenastavnoOsobljeAzurirajForma forma = new NenastavnoOsobljeAzurirajForma(nastavnik);
            forma.ShowDialog();
            this.popuniPodacima();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zapslenog koga zelite da obrisete!");
                return;
            }
            string jmbg = listaZaposlenih.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiNenastavnoOsoblje(jmbg);
                MessageBox.Show("Brisanje je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void NenastavnoOsobljeForma_Load_1(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] {"1234567891234", "Petar", "Nikola", "Sofornijevic","Sokobanja, Svetozara Markovica 10/7","Domar","Ljudski resursi" });
            listaZaposlenih.Items.Add(item);
        }
    }
}
