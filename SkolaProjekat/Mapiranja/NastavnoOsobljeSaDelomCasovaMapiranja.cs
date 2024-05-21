using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class NastavnoOsobljeSaDelomCasovaMapiranja: SubclassMap<NastavnoOsobljeSaDelomCasova>
    {
        public NastavnoOsobljeSaDelomCasovaMapiranja()
        {
            Table("OSOBLJE_SA_DELOM_CASOVA");
            Abstract();
            
            Map(p => p.BrojCasovaNedeljno).Column("BROJ_CASOVA_NEDELJNO");       
            Map(p => p.NazivOstalihSkola).Column("NAZIV_OSTALIH_SKOLA");

            // Ovo se koristi kada imamo RadiU entitet, tj. kada postoje dodatni atributi u tabeli veze
            HasMany(p => p.PredmeteKojePredaje).KeyColumn("JMBG_NASTAVNIKA").LazyLoad().Cascade.All().Inverse();
        }
        
    }
}
