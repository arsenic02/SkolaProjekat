using FluentNHibernate.Mapping;
using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class NastavnoOsobljeSaDelomCasovaMapiranja: ClassMap<NastavnoOsobljeSaDelomCasova>
    {
        public NastavnoOsobljeSaDelomCasovaMapiranja()
        {
            Table("OSOBLJE_SA_DELOM_CASOVA");

            Id(p => p.JMBG, "JMBG").GeneratedBy.Assigned();

            Map(p => p.Ime, "IME");
            Map(p => p.ImeRoditelja, "IME_RODITELJA");
            Map(p => p.AdresaStanovanja, "ADRESA_STANOVANJA");
            Map(p => p.Prezime, "PREZIME");
            Map(p => p.BrojCasovaNedeljno, "BROJ_CASOVA_NEDELJNO");
            Map(p => p.NazivOstalihSkola, "NAZIV_OSTALIH_SKOLA");

            // Ovo se koristi kada imamo RadiU entitet, tj. kada postoje dodatni atributi u tabeli veze
        HasMany(p => p.PredmeteKojePredaje).KeyColumn("JMBG_NASTAVNIKA").LazyLoad().Cascade.All().Inverse();
        }
        
    }
}
