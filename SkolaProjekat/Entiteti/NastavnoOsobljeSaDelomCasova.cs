using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Entiteti
{
    public class NastavnoOsobljeSaDelomCasova
    {
        public virtual string JMBG { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string AdresaStanovanja { get; set; }
        public virtual int BrojCasovaNedeljno { get; set; }
        public virtual string? NazivOstalihSkola { get; set; }
        

        
        public virtual IList<AngazovanSaDelomNorme> PredmeteKojePredaje { get; set; } = [];
    }
}
