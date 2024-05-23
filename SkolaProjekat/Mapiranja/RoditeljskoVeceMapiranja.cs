using FluentNHibernate.Mapping;
using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class RoditeljskoVeceMapiranja:ClassMap<RoditeljskoVece>
    {
        public RoditeljskoVeceMapiranja()
        {
            Table("RODITELJSKO_VECE");

            Id(p => p.JMBG, "JMBG").GeneratedBy.Assigned();

            Map(p => p.ImeRoditelja, "IME_RODITELJA");
            Map(p => p.PrezimeRoditelja, "PREZIME_RODITELJA");
            Map(p => p.Telefon, "TELEFON");

           HasManyToMany(p => p.SuUcenici)
          .Table("JE_RODITELJ")
          .ParentKeyColumn("JMBG_RODITELJA")
          .ChildKeyColumn("JBU")
          .Cascade.All();
        }
    }
}
