﻿using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Entiteti
{
    public class AngazovanSaDelomNormeId
    {
        public virtual NastavnoOsobljeSaDelomCasova NastavnikSaDelomCasovaAngazovan { get; set; }
        public virtual Predmet PredmetNaKomeAngazovanNastavnikSaDelomCasova { get; set; }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj?.GetType() != typeof(AngazovanSaDelomNormeId))
            {
                return false;
            }

            AngazovanSaDelomNormeId compare = (AngazovanSaDelomNormeId)obj;

            return NastavnikSaDelomCasovaAngazovan?.JMBG == compare.NastavnikSaDelomCasovaAngazovan?.JMBG &&
                   PredmetNaKomeAngazovanNastavnikSaDelomCasova?.NazivPredmeta == compare.PredmetNaKomeAngazovanNastavnikSaDelomCasova?.NazivPredmeta;

            /*
             * Drugi pristup, ali problem može da bude nasleđivanje.
             * Ova metoda vraća true i kada je obj tipa koji nasleđuje RadiUId
             * Provera da li je obj?.GetType() == typeof(RadiUId) može da reši i tu situaciju
             * Mada, za tim nema potrebe, pošto svakako ne bismo uspeli da upišemo u bazu ni objekat
             * koji je nasledio našu klasu, zato što bi se CompositeKey sastojao od istih vrednosti
             * 
             if (obj is RadiUId temp)
            {
                return temp.RadnikRadiU?.JBR == RadnikRadiU?.JBR &&
                    temp.ProdavnicaRadiU?.Broj == ProdavnicaRadiU?.Broj;
            }

            return false;
            */
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
