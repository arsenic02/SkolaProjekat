using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Entiteti
{
    public class Poseduje
    {
        public virtual int Id { get; set; }
        /*
        public virtual required string NazivPredmeta { get; set; }
        public virtual required string NazivSmera { get; set; } */

        public virtual Predmet PredmetPosedujeSmerove { get; set; } // Dodajte ovo
        public virtual Smer SmerPosedujePredmete { get; set; } // Dodajte ovo
        public Poseduje()
        {
        }
    }
}
