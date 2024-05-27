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
    public partial class PredmetDodajForma : Form
    {
        PredmetBasic predmet;
        OpsteobrazovniPredmetBasic ooPredmet;
        StrucniPredmetBasic strPredmet;

        string NazivSmera;
        public PredmetDodajForma()
        {
            InitializeComponent();
            predmet = new PredmetBasic();
            ooPredmet = new OpsteobrazovniPredmetBasic();
            strPredmet = new StrucniPredmetBasic();
        }
        public PredmetDodajForma(string nazivSmera)
        {
            InitializeComponent();
            predmet = new PredmetBasic();
            ooPredmet = new OpsteobrazovniPredmetBasic();
            strPredmet = new StrucniPredmetBasic();
            NazivSmera = nazivSmera;
        }

        private void PredmetDodajForma_Load(object sender, EventArgs e)
        {

        }
        private void tbnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da azurirate predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                
                string s = cbTipPredmeta.SelectedItem.ToString();
                switch (s)
                {
                    case "Opšteobrazovni Predmet":
                        ooPredmet.TipPredmeta = "OOP";
                        ooPredmet.NazivPredmeta = tbNazivPredmeta.Text;
                        ooPredmet.NazivSmera = NazivSmera;
                        DTOManager.dodajOpsteobrazovniPredmet(ooPredmet);
                        break;
                    case "Stručni Predmet":
                        strPredmet.TipPredmeta = "STR";
                        strPredmet.NazivPredmeta = tbNazivPredmeta.Text;
                        strPredmet.NazivSmera = NazivSmera;
                        DTOManager.dodajStrucniPredmet(strPredmet);
                        break;
                }
                this.Close();
            }
        }
    }
}
