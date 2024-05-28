using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatSkola.Entiteti;
using FluentNHibernate.Mapping;

namespace SkolaProjekat.Mapiranja
{
    public class OcenaMapiranja: ClassMap<Ocena>
    {
        public OcenaMapiranja()
        {
            Table("Ocena");

            Id(x => x.Id).Column("Jedinstveni_kod_ocene").GeneratedBy.Identity();

            //Map(x => x.JedinstveniBrojUcenika).Column("JBU");
            // 1:N Ucenik-Ocena
            References(p => p.JeDobio).Column("JBU").LazyLoad();
            References(p => p.JeIz).Column("NAZIV_PREDMETA").LazyLoad();

            Map(x => x.NumerickaVrednost).Column("NUMERICKA_VREDNOST");
            Map(x => x.TekstualniOpis).Column("TEKSTUALNI_OPIS");
            Map(x => x.DatumDobijanjaOcene).Column("DATUM_DOBIJANJA_OCENE");
         
        }
    }
}
