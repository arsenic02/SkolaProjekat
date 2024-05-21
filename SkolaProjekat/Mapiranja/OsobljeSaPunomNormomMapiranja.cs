using FluentNHibernate.Mapping;
using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjekatSkola.Entiteti;

namespace SkolaProjekat.Mapiranja
{
    public class OsobljeSaPunomNormomMapiranja:SubclassMap<OsobljeSaPunomNormom>
    {
        public OsobljeSaPunomNormomMapiranja()
        {
            Table("Osoblje_sa_punom_normom");

            Abstract();

            Map(p => p.BrojCasova).Column("BROJ_CASOVA_NEDELJNO");

            HasMany(p => p.PredmeteKojePredaje).KeyColumn("JMBG_NASTAVNIKA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
