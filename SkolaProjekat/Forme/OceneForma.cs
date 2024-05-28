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
    public partial class OceneForma : Form
    {
        string ucenikJBU;
        public OceneForma()
        {
            InitializeComponent();
        }
        public OceneForma(string jmbg)
        {
            InitializeComponent();
            ucenikJBU = jmbg;
            this.Text = $"OCENE ucenikJBUA: {ucenikJBU.ToUpper()}";
        }
        private void popuniPodacima()
        {
            listaOcena.Items.Clear();
            List<OcenaPregled> ocene = DTOManager.vratiSveOceneUcenika(ucenikJBU);
            foreach (OcenaPregled n in ocene)
            {
                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.NazivPredmeta,n.JedinstveniBrojUcenika,n.DatumDobijanjaOcene.ToString(),n.NumerickaVrednost.ToString(),n.TekstualniOpis});
                listaOcena.Items.Add(item);
            }
        }
        private void OceneForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OcenaDodajForma forma = new OcenaDodajForma(ucenikJBU);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (listaOcena.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ocenu cije podatke zelite da izmenite!");
                return;
            }
            int id = Int32.Parse(listaOcena.SelectedItems[0].SubItems[0].Text);
            OcenaBasic ocena = DTOManager.vratiOcenu(id);
            OcenaAzurirajForma forma = new OcenaAzurirajForma(ocena);           
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaOcena.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ocenu koju zelite da obrisete!");
                return;
            }
            int id = Int32.Parse(listaOcena.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu ocenu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiOcenu(id);
                MessageBox.Show("Brisanje ocene je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
