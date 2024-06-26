﻿//using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Smer
    {
        public virtual string NazivSmera { get; set; }
        public virtual int MaksimalanBrojUcenika { get; set; }
        public virtual IList<Ucenik> Ucenici { get; set; }//new List<Ucenik>(); //[];
        public virtual IList<Predmet> Predmeti { get; set; }//Posledica veze Ima N-M

       // public virtual IList<Poseduje> SmerPoseduje { get; set; } = [];

        public Smer()
        {
            Ucenici = new List<Ucenik>();
            Predmeti = new List<Predmet>(); 
        }
    }
}
