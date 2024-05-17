﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Smer
    {
        public virtual int Id { get; protected set; }
        public virtual string NazivSmera { get; set; }
        public virtual uint MaksimalanBrojUcenika { get; set; }
        public virtual IList<Ucenik> Ucenici { get; set; }
        public Smer()
        {
            Ucenici = new List<Ucenik>();
        }
    }
}
