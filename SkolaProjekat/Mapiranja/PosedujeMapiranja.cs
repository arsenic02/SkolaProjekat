using FluentNHibernate.Mapping;
using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class PosedujeMapiranja:ClassMap<Poseduje>
    {
        public PosedujeMapiranja()
        {
            Table("POSEDUJE");
            /*
            CompositeId(p => p.Id)
                .KeyReference(p => p.PredmetPosedujeSmerove, "NAZIV_PREDMETA")
                .KeyReference(p => p.SmerPosedujePredmete, "NAZIV_SMERA"); */
        }
    }
}
