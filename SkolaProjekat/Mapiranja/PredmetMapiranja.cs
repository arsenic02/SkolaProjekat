﻿using FluentNHibernate.Mapping;
using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat.Mapiranja
{
    public class PredmetMapiranja : ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("PREDMET");

            //Kod mapiranja alternative 8C koristi se ova metoda, koja definise
            //kolonu na osnovu koje se odredjuje pripadnost konkretnoj podklasi
            DiscriminateSubClassesOnColumn("TipPredmeta");//Tako se zapravo u bazi zove

            // Primarni ključ koji se generiše korišćenjem trigger-a
            Id(p => p.NazivPredmeta, "NAZIV_PREDMETA").GeneratedBy.Assigned();

            // Sva ostala svojstva
            // Map(p => p.NazivPredmeta, "NAZIV_PREDMETA");

            Map(p => p.NazivSmera, "NAZIV_SMERA");

            HasManyToMany(p => p.Smerovi)
            .Table("IMA")
            .ParentKeyColumn("NAZIV_PREDMETA")//BROJP
            .ChildKeyColumn("NAZIV_SMERA")
            .Cascade.All();

            HasManyToMany(p => p.Na)
           .Table("NA")
           .ParentKeyColumn("NAZIV_PREDMETA")//BROJP
           .ChildKeyColumn("REDNI_BROJ_RAZREDA")
           .Cascade.All();

            // Dok ovakav kada imamo dodatni entitet RadiU
            HasMany(p => p.PredmeteKojePredajeNastavnikSaDelomCasova).KeyColumn("NAZIV_PREDMETA").LazyLoad().Cascade.All().Inverse();

            HasMany(p => p.PredmeteKojePredajeNastavnikSaPunomNormomCasova).KeyColumn("NAZIV_PREDMETA").LazyLoad().Cascade.All().Inverse();

            //U KEY COLUMN IDE STRANI KLJUC IZ OCENE
            HasMany(p => p.Ocene).KeyColumn("NAZIV_PREDMETA").LazyLoad().Cascade.All().Inverse();

        }
    }
    class OpsteobrazovniPredmetMapiranja : SubclassMap<OpsteobrazovniPredmet>
    {
        public OpsteobrazovniPredmetMapiranja()
        {
            DiscriminatorValue("OOP");//OpsteObrazovniPredmet
        }
    }

    class StrucniPredmetMapiranja : SubclassMap<StrucniPredmet>
    {
        public StrucniPredmetMapiranja() 
        {
            DiscriminatorValue("STR");//OpsteObrazovniPredmet
        }
    }
}
