﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class AngazovanSaPunomNormom
    {
        public virtual string NazivPredmeta { get; set; }
        public virtual string JMBGNastavnika { get; set; }
        public virtual DateTime DatumAngazovanja { get; set; }
        public AngazovanSaPunomNormom()
        {
        }
    }
}
