using FluentNHibernate.Mapping;
using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    internal class AngazovanSaPunomNormomMapiranja : ClassMap<AngazovanSaPunomNormom>
    {
        public AngazovanSaPunomNormomMapiranja()
        {
            Table("ANGAZOVAN_SA_PUNOM_NORMOM");

            CompositeId(p => p.Id)
                .KeyReference(p => p.NastavnikSaPunomNormomAngazovan, "JMBG_NASTAVNIKA")
                .KeyReference(p => p.PredmetNaKomeAngazovanNastavnikSaPunomNormom, "NAZIV_PREDMETA");

            Map(p => p.DatumAngazovanja, "DATUM_ANGAZOVANJA");
        }
    }
}
