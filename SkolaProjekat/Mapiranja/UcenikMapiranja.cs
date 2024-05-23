using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjekatSkola.Entiteti;

namespace SkolaProjekat.Mapiranja
{
    public class UcenikMapiranja: ClassMap<Ucenik>
    {
        public UcenikMapiranja()
        {
            Table("UCENIK");

            Id(p => p.JedinstveniUpisniBroj, "JBU").GeneratedBy.Assigned();

            Map(p => p.Ime, "IME");
            //Map(p => p.NazivSmera, "NAZIV_SMERA"); //STRANI KLJUC 
            Map(p => p.Prezime, "PREZIME");
            
            Map(p => p.AdresaStanovanja, "ADRESA_STANOVANJA");
           // Map(p => p.NazivSmera, "NAZIV_SMERA");// definitivno ovo ne treba
            Map(p => p.DatumUpisa, "DATUM_UPISA");
           
           // Map(p => p.RedniBrojRazreda, "REDNI_BROJ_RAZREDA");//STRANI KLJUC, KADA SE IZMODELUJE VEZA RAZRED PREMA UCENIK, BICE UBACENA  U REFERENCES
            //Column se odnosi na kolonu u tabeli ucenik
            References(x => x.PohadjaRazred).Column("REDNI_BROJ_RAZREDA").LazyLoad();

            // 1:N Smer-Ucenik
            References(p => p.JeUpisan).Column("NAZIV_SMERA").LazyLoad();


            // 1:N SMER-UCENIK
            //U KEY COLUMN IDE STRANI KLJUC IZ OCENA
            HasMany(p => p.Ocene).KeyColumn("JBU").LazyLoad().Cascade.All().Inverse();

            HasMany(p => p.Predmeti).KeyColumn("NAZIV_PREDMETA").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(p => p.SuRoditelji)
           .Table("JE_RODITELJ")
           .ParentKeyColumn("JBU")
           .ChildKeyColumn("JMBG_RODITELJA")
           .Cascade.All();

        }
    }
}
