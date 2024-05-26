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
    public partial class SmerDodajForma : Form
    {
        SmerBasic smer;
        public SmerDodajForma()
        {
            InitializeComponent();
            smer = new SmerBasic();
        }
      
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi smer?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.smer.NazivSmera = tbNazivSmera.Text;
                this.smer.MaksimalanBrojUcenika = Int32.Parse(tbMaxBr.Text);
                DTOManager.dodajSmer(this.smer);
                this.Close();
            }
        }

        private void SmerDodajForma_Load(object sender, EventArgs e)
        {
        }
    }
}
