﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Razred
    {
        //public virtual int Id { get; protected set; }
        public virtual int RedniBrojRazreda { get; set; }
        public virtual IList<Ucenik> Ucenici { get; set; }
        public virtual IList<Predmet> Na { get; set; }
        public Razred()
        {
            Ucenici = new List<Ucenik>();
            Na = new List<Predmet>();
        }
       
    }
}
