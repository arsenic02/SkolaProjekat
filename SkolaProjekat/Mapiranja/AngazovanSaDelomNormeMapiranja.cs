using FluentNHibernate.Mapping;
using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja;

public class AngazovanSaDelomNormeMapiranja: ClassMap<AngazovanSaDelomNorme>
{
    public AngazovanSaDelomNormeMapiranja()
    {
        Table("ANGAZOVAN_SA_DELOM_NORME");
       
        CompositeId(p => p.Id)
            .KeyReference(p => p.NastavnikSaDelomCasovaAngazovan, "JMBG_NASTAVNIKA")
            .KeyReference(p => p.PredmetNaKomeAngazovanNastavnikSaDelomCasova, "NAZIV_PREDMETA");

        Map(p => p.DatumAngazovanja, "DATUM_ANGAZOVANJA");
        

    }
}
