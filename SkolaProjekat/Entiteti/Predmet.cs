using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Predmet
    {
        public virtual string NazivPredmeta { get; set; }
        public virtual string TipPredmeta { get; set; }
        public virtual int JedinstveniBrojUcenika { get; set; }
        public virtual string NazivSmera { get; set; }
        public Predmet()
        {
        }
    }
}
