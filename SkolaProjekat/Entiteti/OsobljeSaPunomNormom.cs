using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class OsobljeSaPunomNormom
    {
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string AdresaStanovanja { get; set; }
        public virtual int BrojCasova { get; set; }
        public OsobljeSaPunomNormom()
        {
        }
    }
}
