using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class JeRoditelj
    {
        public virtual int JedinstveniUpisniBrojUcenika { get; set; }
        public virtual string JMBGRoditelja { get; set; }
        public JeRoditelj()
        {
        }
    }
}
