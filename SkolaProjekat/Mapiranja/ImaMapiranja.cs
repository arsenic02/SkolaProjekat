using ProjekatSkola.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class ImaMapiranja:ClassMap<Ima>
    {
        public ImaMapiranja()
        {
            Table("IMA");

            //mapiranje veza
            CompositeId()
          .KeyProperty(x => x.Id.NazivSmera, "NAZIV_SMERA")
          .KeyProperty(x => x.Id.NazivPredmeta, "NAZIV_PREDMETA");
        }
    }
}
