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
    public partial class PredmetiForma : Form
    {
        SmerBasic smer;
        public PredmetiForma()
        {
            InitializeComponent();
        }
        public PredmetiForma(string nazivSmera)
        {
            InitializeComponent();
            smer = DTOManager.vratiSmer(nazivSmera);
            this.Text = $"PREDMETI SA SMERA: {nazivSmera.ToUpper()}";
        }
        private void popuniPodacima()
        {
            listaPredmeta.Items.Clear();
            List<StrucniPredmetPregled> sp = DTOManager.vratiStrucnePredmeteSaSmera(smer.NazivSmera);
            List<OpsteobrazovniPredmetPregled> oop = DTOManager.vratiOpsteobrazovnePredmeteSaSmera(smer.NazivSmera);
            //List<PredmetPregled> podaci = DTOManager.vratiPredmeteSaSmera(smer.NazivSmera);
            foreach (StrucniPredmetPregled n in sp)
            {
                ListViewItem item = new ListViewItem(new string[] { n.NazivPredmeta, "STR" });
                listaPredmeta.Items.Add(item);
            }
            foreach (OpsteobrazovniPredmetPregled n in oop)
            {
                ListViewItem item = new ListViewItem(new string[] { n.NazivPredmeta, "OOP" });
                listaPredmeta.Items.Add(item);
            }
        }
        private void PredmetiForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PredmetDodajForma forma = new PredmetDodajForma(smer.NazivSmera);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite predmet cije podatke zelite da izmenite!");
                return;
            }
            string naziv = listaPredmeta.SelectedItems[0].SubItems[0].Text;
            string tip = listaPredmeta.SelectedItems[0].SubItems[1].Text;
            switch(tip)
            {
                case "OOP":
                    OpsteobrazovniPredmetBasic oop = DTOManager.vrtatiOpsteobrazovniPredmet(naziv);
                    PredmetAzurirajForma forma1 = new PredmetAzurirajForma(oop);
                    forma1.ShowDialog();
                    break;
                case "STR":
                    StrucniPredmetBasic str = DTOManager.vratiStrucniPredmet(naziv);
                    PredmetAzurirajForma forma2 = new PredmetAzurirajForma(str);
                    forma2.ShowDialog();
                    break;
            }           
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite predmet koji zelite da obrisete!");
                return;
            }
            string naziv = listaPredmeta.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabrani predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiSmer(naziv);
                MessageBox.Show("Brisanje predmeta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
