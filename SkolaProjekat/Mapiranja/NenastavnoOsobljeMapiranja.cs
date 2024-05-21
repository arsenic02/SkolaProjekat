using NHibernate.Mapping;
using FluentNHibernate.Mapping;
using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class NenastavnoOsobljeMapiranja: SubclassMap<NenastavnoOsoblje>
    {
        public NenastavnoOsobljeMapiranja()
        {
            Table("NENASTAVNO_OSOBLJE");
            Abstract();

            Map(p => p.ImeSektora).Column("IME_SEKTORA");
            Map(p => p.StrucnaSprema).Column("STRUCNA_SPREMA");
        }
    }
}
