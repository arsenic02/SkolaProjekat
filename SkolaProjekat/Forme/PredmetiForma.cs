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
            this.Text = $"SMER: {nazivSmera.ToUpper()}";
        }

        private void PredmetiForma_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}
