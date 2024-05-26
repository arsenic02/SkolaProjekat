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
    public partial class ZaposleniForma : Form
    {
        public ZaposleniForma()
        {
            InitializeComponent();
        }

        private void btnNastavnoOsobljeSaPunomNormomForma_Click(object sender, EventArgs e)
        {
            NOSaPunomNormomForma forma = new NOSaPunomNormomForma();
            forma.ShowDialog();
        }

        private void btnNastavnoOsobljeSaDelomNormeForma_Click(object sender, EventArgs e)
        {
            NOSaDelomNormeForma forma = new NOSaDelomNormeForma();
            forma.ShowDialog();
        }

        private void btnNenastavnoOsobljeForma_Click(object sender, EventArgs e)
        {
            NenastavnoOsobljeForma forma = new NenastavnoOsobljeForma();
            forma.ShowDialog();
        }
    }
}
