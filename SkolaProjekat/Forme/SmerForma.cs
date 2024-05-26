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
    public partial class SmerForma : Form
    {
        public SmerForma()
        {
            InitializeComponent();
        }
        private void popuniPodacima()
        {
            listaSmerova.Items.Clear();
            List<SmerPregled> podaci = DTOManager.vratiSveSmerove();

            foreach (SmerPregled n in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {n.NazivSmera,n.MaksimalanBrojUcenika.ToString() });
                listaSmerova.Items.Add(item);
            }
        }
        private void SmerForma_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajSmer_Click(object sender, EventArgs e)
        {
            SmerDodajForma forma = new SmerDodajForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listaSmerova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite smer cije podatke zelite da izmenite!");
                return;
            }
            string naziv = listaSmerova.SelectedItems[0].SubItems[0].Text;          
            SmerBasic smerBasic = DTOManager.vratiSmer(naziv);
            SmerAzurirajForma forma = new SmerAzurirajForma(smerBasic);
            forma.ShowDialog();

            this.popuniPodacima();
        }

        private void btnVidiPredmet_Click(object sender, EventArgs e)
        {
            if (listaSmerova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite smer koji zelite da pogledate!");
                return;
            }
            string naziv = listaSmerova.SelectedItems[0].SubItems[0].Text;            
            PredmetiForma form = new PredmetiForma(naziv);
            form.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaSmerova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite smer koji zelite da obrisete!");
                return;
            }
            string naziv = listaSmerova.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabrani smer?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiSmer(naziv);
                MessageBox.Show("Brisanje smera je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
