﻿using FluentNHibernate.Mapping;
using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class SmerMapiranja:ClassMap<Smer>
    {
        public SmerMapiranja()
        {
            // Naziv tabele u bazi podataka
            Table("SMER");

            // Primarni ključ koji se generiše korišćenjem trigger-a
            Id(p => p.NazivSmera, "NAZIV_SMERA").GeneratedBy.Assigned();

            // Sva ostala svojstva
            Map(p => p.MaksimalanBrojUcenika, "MAKSIMALNI_BROJ_UCENIKA");
           

            // 1:N SMER-UCENIK
            //U KEY COLUMN IDE STRANI KLJUC IZ UCENIK
            HasMany(p => p.Ucenici).KeyColumn("NAZIV_SMERA").LazyLoad().Cascade.All().Inverse();

            //ZA OSTALE VEZE
            // Inverse mora da bude samo na jednoj strani. Znači prepuštamo tabeli Predmet da vodi računa o ovoj vezi
            // Ovakav pristup sa Table("RADI_U") se koristi kada nemamo dodatnih atributa u tabeli veze!
            HasManyToMany(p => p.Predmeti)
               .Table("IMA")
               .ParentKeyColumn("NAZIV_SMERA")
               .ChildKeyColumn("NAZIV_PREDMETA")
               .Cascade.All()
               .Inverse();
            // Dok ovakav kada imamo dodatni entitet RadiU
            // HasMany(p => p.RadniciRadeU).KeyColumn("BROJP").LazyLoad().Cascade.All().Inverse();
        }
    }
}
