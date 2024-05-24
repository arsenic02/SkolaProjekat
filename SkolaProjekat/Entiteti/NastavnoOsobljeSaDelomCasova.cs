using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Entiteti
{
    public class NastavnoOsobljeSaDelomCasova : Zaposleni
    {
        public virtual int BrojCasovaNedeljno { get; set; }
        public virtual string? NazivOstalihSkola { get; set; }
        public NastavnoOsobljeSaDelomCasova() 
        {
            PredmeteKojePredaje = new List<AngazovanSaDelomNorme>();
        }
        public virtual IList<AngazovanSaDelomNorme> PredmeteKojePredaje { get; set; }
    }
}
