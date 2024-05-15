using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Smer
    {
        public virtual string NazivSmera { get; set; }
        public virtual uint MaksimalanBrojUcenika { get; set; }
        public Smer()
        {
        }
    }
}
