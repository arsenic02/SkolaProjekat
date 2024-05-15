using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Ocena
    {
        public virtual string NazivPredmeta { get; set; }
        public virtual int JedinstveniBrojUcenika { get; set; }
        public virtual DateTime DatumDobijanjaOcene { get; set; }
        public virtual int NumerickaVrednost { get; set; }
        public virtual string TekstualniOpis { get; set; }
        public Ocena()
        {
        }
    }
}
