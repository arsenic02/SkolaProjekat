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
            Table("Ocene");

            // Definisanje kompozitnog ključa
            CompositeId()
                .KeyProperty(x => x.DatumDobijanjaOcene, "DatumDobijanjaOcene")
                .KeyProperty(x => x.NazivPredmeta, "NazivPredmeta");

            CompositeId()
           .KeyProperty(x => x.NazivPredmeta, "NazivPredmeta")
           .KeyProperty(x => x.DatumDobijanjaOcene, "DatumDobijanjaOcene");

            Map(x => x.JedinstveniBrojUcenika).Column("JedinstveniBrojUcenika");

            Map(x => x.NumerickaVrednost).Column("NumerickaVrednost");

            Map(x => x.TekstualniOpis).Column("TekstualniOpis");
        }
    }
}
