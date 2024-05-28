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
            Table("OSOBLJE_SA_PUNOM_NORMOM");

            Abstract();

            Map(p => p.BrojCasova).Column("BROJ_CASOVA");

            HasMany(p => p.PredmeteKojePredaje).KeyColumn("JMBG_NASTAVNIKA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
