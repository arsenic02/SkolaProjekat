using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class NenastavnoOsoblje: Zaposleni
    {     
        public virtual string ImeSektora { get; set; }
        public virtual string StrucnaSprema { get; set; }
        public NenastavnoOsoblje(){}
    }
}
