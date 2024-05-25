//using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Predmet
    {
        public virtual string NazivPredmeta { get; set; }
        public virtual string TipPredmeta { get; set; }
        public virtual string NazivSmera { get; set; }

        public virtual IList<AngazovanSaDelomNorme> PredmeteKojePredajeNastavnikSaDelomCasova { get; set; }
        public virtual IList<AngazovanSaPunomNormom> PredmeteKojePredajeNastavnikSaPunomNormomCasova { get; set;}
        public virtual IList<Smer> Smerovi { get; set; } = new List<Smer>();//Posledica veze Ima N-M 
        public virtual IList<Ocena> Ocene { get; set; } //[];
        public virtual IList<Razred> Na { get; set; }
        public virtual Ucenik SlusaPredmet { get; set; }  


        public Predmet()
        {
            PredmeteKojePredajeNastavnikSaDelomCasova = new List<AngazovanSaDelomNorme>();
            PredmeteKojePredajeNastavnikSaPunomNormomCasova = new List<AngazovanSaPunomNormom>();
            Smerovi = new List<Smer>();
            Ocene = new List<Ocena>();
            Na = new List<Razred>();
        }
    }
    //Posledica prevodjenja alternative 8C
    public class OpsteobrazovniPredmet : Predmet
    {

    }
    public class StrucniPredmet: Predmet
    {

    }
}
