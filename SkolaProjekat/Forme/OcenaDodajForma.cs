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
    public partial class OcenaDodajForma : Form
    {
        string ucenik;
        List<PredmetPregled> predmeti;
        OcenaBasic ocena;
        public OcenaDodajForma()
        {
            InitializeComponent();
            ocena = new OcenaBasic();
            predmeti = new List<PredmetPregled>();
        }
        public OcenaDodajForma(string u)
        {
            InitializeComponent();
            ucenik = u;
            ocena = new OcenaBasic();
            predmeti = new List<PredmetPregled>();
            predmeti = DTOManager.vratiSvePredmeteSaSmeraUcenika(ucenik);
            foreach (PredmetPregled p in predmeti)
            {
                cbNazivPredmeta.Items.Add(p.NazivPredmeta);
            }
        }
        private void OcenaDodajForma_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da azurirate predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                if(cbNazivPredmeta.SelectedIndex!=-1)
                {
                    ocena.NazivPredmeta = cbNazivPredmeta.SelectedItem.ToString();
                    ocena.JedinstveniBrojUcenika = ucenik;
                    ocena.NumerickaVrednost = Int32.Parse(tbNumerickaVrednost.Text);
                    ocena.TekstualniOpis = tbOpis.Text;
                    ocena.DatumDobijanjaOcene = dtpDatum.Value;
                    DTOManager.dodajOcenu(ocena);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Morate odabrati naziv predmeta!","Obavestenje", buttons );
                }              
            }
        }
    }
}
