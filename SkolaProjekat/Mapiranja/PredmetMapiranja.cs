using FluentNHibernate.Mapping;
using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class PredmetMapiranja: ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("PREDMET");

            // Primarni ključ koji se generiše korišćenjem trigger-a
            Id(p => p.NazivPredmeta, "NAZIV_PREDMETA").GeneratedBy.Assigned();

            // Sva ostala svojstva
           // Map(p => p.NazivPredmeta, "NAZIV_PREDMETA");
            Map(p => p.TipPredmeta, "TIPPREDMETA");
            Map(p => p.JedinstveniBrojUcenika, "JBU");
            Map(p => p.NazivSmera, "NAZIV_SMERA");

            // Ovakav pristup sa Table("RADI_U") se koristi kada nemamo dodatnih atributa u tabeli veze!
            HasManyToMany(p => p.Smerovi)
            .Table("POSEDUJE")
            .ParentKeyColumn("NAZIV_PREDMETA")//BROJP
            .ChildKeyColumn("NAZIV_SMERA")
            .Cascade.All();
            //.Inverse();

            // Dok ovakav kada imamo dodatni entitet RadiU
            HasMany(p => p.PredmeteKojePredajeNastavnikSaDelomCasova).KeyColumn("NAZIV_PREDMETA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
