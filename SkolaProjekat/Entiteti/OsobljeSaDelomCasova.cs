using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class OsobljeSaDelomCasova
    {
        public string NazivOsttalihSkola { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string AdresaStanovanja { get; set; }
        public virtual int BrojCasovaNedeljno { get; set; }
        public OsobljeSaDelomCasova()
        {
        }
    }
}
