using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Ocena
    {
        public int Id { get; set; }
        public virtual string NazivPredmeta { get; set; }
        public virtual string JedinstveniBrojUcenika { get; set; }
        public virtual DateTime DatumDobijanjaOcene { get; set; }
        public virtual int NumerickaVrednost { get; set; }
        public virtual string TekstualniOpis { get; set; }

        public virtual Ucenik JeDobio { get; set; }
        public virtual Predmet JeIz { get; set; }

        public Ocena()
        {
        }    
    }
}
