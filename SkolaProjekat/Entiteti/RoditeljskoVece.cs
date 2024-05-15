using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class RoditeljskoVece
    {
        public virtual string JMBG { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string PrezimeRoditelja { get; set; }
        public virtual string Telefon { get; set; }
        public RoditeljskoVece()
        {
        }
    }
}
