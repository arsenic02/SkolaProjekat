using FluentNHibernate.Mapping;
using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class ZaposleniMapiranja: ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            // Indikuje da je ovo osnovna klasa za TPC strategiju
            UseUnionSubclassForInheritanceMapping();

            // Mapiranje JMBG svojstva
            Id(x => x.JMBG).Column("JMBG");       

            // Mapiranje zajedničkih svojstava
            Map(x => x.Ime).Column("IME");

            Map(x => x.Prezime).Column("PREZIME");


            Map(x => x.ImeRoditelja).Column("IME_RODITELJA");

            Map(x => x.AdresaStanovanja).Column("ADRESA_STANOVANJA");
        }
       
    }
}
