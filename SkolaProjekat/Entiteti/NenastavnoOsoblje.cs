using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class NenastavnoOsoblje
    {
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string AdresaStanovanja { get; set; }
        public virtual string ImeSektora { get; set; }
        public virtual string StrucnaSprema { get; set; }
        public NenastavnoOsoblje()
        {
        }
    }
}
