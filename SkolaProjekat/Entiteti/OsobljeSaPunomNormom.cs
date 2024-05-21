using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class OsobljeSaPunomNormom:Zaposleni
    {
        public virtual int BrojCasova { get; set; }
        public OsobljeSaPunomNormom() { }
        public virtual IList<AngazovanSaPunomNormom> PredmeteKojePredaje { get; set; } = [];
    }
}
