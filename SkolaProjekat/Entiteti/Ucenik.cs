using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Ucenik
    {
        public virtual int JedinstveniUpisniBroj { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string AdresaStanovanja { get; set; }
        public virtual string NazivSmera { get; set; }
        public virtual DateTime DatumUpisa { get; set; }
        public virtual int RedniBrojRazreda { get; set; }
        public Ucenik() { }
    }
}
