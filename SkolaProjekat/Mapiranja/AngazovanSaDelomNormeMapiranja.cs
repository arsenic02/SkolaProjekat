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
        //nzm kako sa 2 primarna kljuca, vrv u nekom narednom klipu
        /*
         * 
        Id(p => p.JMBGNastavnika, "JMBG_NASTAVNIKA").GeneratedBy.Assigned();
        Map(p => p.NazivPredmeta, "NAZIV_PREDMETA");
        
         */
        Id(p => p.JMBGNastavnika, "JMBG_NASTAVNIKA").GeneratedBy.Assigned();
        Map(p => p.NazivPredmeta, "NAZIV_PREDMETA");//iako je NazivPredmeta primarni kljuc, bolje ovako radi
        /*
        Id(p => p.NazivPredmeta, "NAZIV_PREDMETA").GeneratedBy.Assigned();
        Map(p => p.JMBGNastavnika, "JMBG_NASTAVNIKA");
        */
        //Map(p => p.DatumAngazovanja, "DATUM_ANGAZOVANJA");
        
    }
}
