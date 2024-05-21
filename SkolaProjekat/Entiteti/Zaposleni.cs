using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Entiteti
{
    public abstract class Zaposleni
    {
        public virtual required string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string AdresaStanovanja { get; set; }
        //public virtual DateTime DatumRodjenja { get; set; }
        public Zaposleni() { }
    }
}
