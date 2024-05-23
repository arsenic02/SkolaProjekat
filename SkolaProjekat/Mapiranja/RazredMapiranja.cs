using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace SkolaProjekat.Mapiranja
{
    public class RazredMapiranja:ClassMap<Razred>
    {
        public RazredMapiranja()
        {
            Table("RAZRED");

            Id(p => p.RedniBrojRazreda, "REDNI_BROJ_RAZREDA").GeneratedBy.Assigned();

            //Map(p => p.RedniBrojRazreda, "REDNI_BROJ_RAZREDA");
            HasMany(x => x.Ucenici).KeyColumn("REDNI_BROJ_RAZREDA").LazyLoad().Cascade.All().Inverse();
        }
       
    }
}
