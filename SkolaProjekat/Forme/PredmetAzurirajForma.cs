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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkolaProjekat.Forme
{
    public partial class PredmetAzurirajForma : Form
    {
        OpsteobrazovniPredmetBasic ooPredmet;
        StrucniPredmetBasic strPredmet;
        string tip;
        public PredmetAzurirajForma()
        {
            InitializeComponent();
        }
        public PredmetAzurirajForma(OpsteobrazovniPredmetBasic p)
        {
            InitializeComponent();
            ooPredmet = p;
            tip = p.TipPredmeta;
            popuniPodacima();
            this.Text = $"AZURIRANJE PREDMETA{p.NazivSmera.ToUpper()}";
        }
        public PredmetAzurirajForma(StrucniPredmetBasic p)
        {
            InitializeComponent();
            strPredmet = p;
            tip = p.TipPredmeta;
            popuniPodacima();
            this.Text = $"AZURIRANJE PREDMETA{p.NazivSmera.ToUpper()}";
        }      

        private void PredmetAzurirajForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {         
            switch (tip)
            {
                case "OOP":
                    tbNazivPredmeta.Text = this.ooPredmet.NazivPredmeta;
                    break;
                case "STR":
                    tbNazivPredmeta.Text = this.strPredmet.NazivPredmeta;
                    break;
            }            
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string nazivPredmeta = tbNazivPredmeta.Text;
            string tipPredmeta = cbTipPredmeta.SelectedItem.ToString();
            string poruka = "Da li zelite da azurirate predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                switch (tip)
                {
                    case "OOP":
                        this.ooPredmet.NazivPredmeta = tbNazivPredmeta.Text;
                        this.ooPredmet.NazivPredmeta = tipPredmeta;
                        DTOManager.azurirajOpsteobrazovniPredmet(ooPredmet);
                        break;
                    case "STR":
                       this.strPredmet.NazivPredmeta = tbNazivPredmeta.Text;
                        this.strPredmet.NazivPredmeta = tipPredmeta;
                        DTOManager.azurirajStrucniPredmet(strPredmet);
                        break;
                }             
                this.Close();
            }
        }
    }
}
