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
            Map(p => p.RedniBrojRazreda, "REDNI_BROJ_RAZREDA");//STRANI KLJUC, KADA SE IZMODELUJE VEZA RAZRED PREMA UCENIK, BICE UBACENA  U REFERENCES
            Map(p => p.AdresaStanovanja, "ADRESA_STANOVANJA");
            Map(p => p.DatumUpisa, "DATUM_UPISA");

            // 1:N Smer-Ucenik
            References(p => p.JeUpisan).Column("NAZIV_SMERA").LazyLoad();
        }
    }
}
