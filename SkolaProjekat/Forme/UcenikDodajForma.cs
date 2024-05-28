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
    public partial class UcenikDodajForma : Form
    {
        UcenikBasic ucenik;
        List<SmerPregled> smerovi;
        List<RazredPregled> razredi;
        public UcenikDodajForma()
        {
            InitializeComponent();
            ucenik = new UcenikBasic();
        }

        private void UcenikDodajForma_Load(object sender, EventArgs e)
        {
            razredi = DTOManager.vratiSveRazrede();
            smerovi = DTOManager.vratiSveSmerove();
            popuniCB();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog ucenika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                if(cbSmer.SelectedIndex != -1)
                {
                   ucenik.JeUpisan.NazivSmera = cbSmer.SelectedItem.ToString();
                }
                if (cbRazred.SelectedIndex != -1)
                { 
                    ucenik.PohadjaRazred.RedniBrojRazreda = Int32.Parse(cbRazred.SelectedItem.ToString());
                }
                ucenik.JedinstveniUpisniBroj = tbJUB.Text;
                ucenik.Ime = tbIme.Text;
                ucenik.Prezime = tbPrezime.Text;
                ucenik.AdresaStanovanja=tbAdresa.Text;
                ucenik.DatumUpisa = dtpDatum.Value;

                DTOManager.dodajUcenika(ucenik);
                this.Close();
            }
        }
        private void popuniCB()
        {
            foreach(RazredPregled r in razredi)
            {
                cbRazred.Items.Add(r.RedniBrojRazreda);
            }
            foreach(SmerPregled s in smerovi)
            {
                cbSmer.Items.Add(s.NazivSmera);
            }
        }
        private int proveriCB()
        {
            int rbRazreda = -1;
            if (cbRazred.SelectedIndex == -1)
            {            
                cbSmer.Enabled = false;
            }
            else
            {                
                cbSmer.Enabled = true;
                rbRazreda = Int32.Parse(cbSmer.SelectedItem.ToString());
            }
            return rbRazreda;
        }
    }
}
