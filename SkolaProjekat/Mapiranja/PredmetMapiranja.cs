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

            //Kod mapiranja alternative 8C koristi se ova metoda, koja definise
            //kolonu na osnovu koje se odredjuje pripadnost konkretnoj podklasi
            DiscriminateSubClassesOnColumn("TipPredmeta");

            // Primarni ključ koji se generiše korišćenjem trigger-a
            Id(p => p.NazivPredmeta, "NAZIV_PREDMETA").GeneratedBy.Assigned();

           

            // Sva ostala svojstva
            // Map(p => p.NazivPredmeta, "NAZIV_PREDMETA");
           
            //Map(p => p.JedinstveniBrojUcenika, "JBU");
            References(p => p.SlusaPredmet).Column("JBU").LazyLoad();

            Map(p => p.NazivSmera, "NAZIV_SMERA");

            HasManyToMany(p => p.Smerovi)
            .Table("POSEDUJE")
            .ParentKeyColumn("NAZIV_PREDMETA")//BROJP
            .ChildKeyColumn("NAZIV_SMERA")
            .Cascade.All();

            // Dok ovakav kada imamo dodatni entitet RadiU
            HasMany(p => p.PredmeteKojePredajeNastavnikSaDelomCasova).KeyColumn("NAZIV_PREDMETA").LazyLoad().Cascade.All().Inverse();

            //U KEY COLUMN IDE STRANI KLJUC IZ OCENE
            HasMany(p => p.Ocene).KeyColumn("NAZIV_PREDMETA").LazyLoad().Cascade.All().Inverse();

            
        }
    }
    class OpsteobrazovniPredmetMapiranja: SubclassMap<OpsteobrazovniPredmet>
    {
        public OpsteobrazovniPredmetMapiranja()
        {
            DiscriminatorValue("OOP");//OpsteObrazovniPredmet
        }
    }
}
