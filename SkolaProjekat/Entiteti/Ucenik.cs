﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjekatSkola.Entiteti
{
    public class Ucenik
    {
       // public virtual int Id { get; protected set; }
        public virtual required string JedinstveniUpisniBroj { get; set; }
        public virtual string? Ime { get; set; }
        public virtual string? Prezime { get; set; }
        public virtual string? AdresaStanovanja { get; set; }
       // public virtual string? NazivSmera { get; set; } //vrv ne trebas
        public virtual DateTime DatumUpisa { get; set; }
        public virtual int RedniBrojRazreda { get; set; }
        public Ucenik() { }

        public virtual required Smer JeUpisan { get; set; }// ili mozda?
        public virtual required Ocena JeDobio { get; set; }// ili mozda?
    }
}
