using FluentNHibernate.Testing.Values;
using NHibernate;
using NHibernate.Criterion;
using ProjekatSkola.Entiteti;
using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat
{
    public class DTOManager
    {

        /*
          try
            {
                ISession s = DataLayer.GetSession();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dohvatanja Strucnog predmeta: " + ec.Message);
            }
         */
        #region Ucenik
        public static List<UcenikPregled> vratiSveUcenike()
        {
            List<UcenikPregled> ucenici = new List<UcenikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProjekatSkola.Entiteti.Ucenik> sviUcenici = from o in s.Query<ProjekatSkola.Entiteti.Ucenik>()
                                                                        select o;

                foreach (ProjekatSkola.Entiteti.Ucenik u in sviUcenici)
                {
                    ucenici.Add(new UcenikPregled(u.JedinstveniUpisniBroj, u.Ime, u.Prezime, u.AdresaStanovanja, u.DatumUpisa, u.PohadjaRazred, u.JeUpisan));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // handle exceptions
            }

            return ucenici;
        }
        public static void dodajUcenika(UcenikBasic u)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSkola.Entiteti.Ucenik o = new ProjekatSkola.Entiteti.Ucenik();


                o.JedinstveniUpisniBroj = u.JedinstveniUpisniBroj;
                o.Ime = u.Ime;
                o.Prezime = u.Prezime;
                o.AdresaStanovanja = u.AdresaStanovanja;
                o.DatumUpisa = u.DatumUpisa;
                  ProjekatSkola.Entiteti.Razred razred = s.Load<ProjekatSkola.Entiteti.Razred>(u.PohadjaRazred.RedniBrojRazreda);
                  o.PohadjaRazred = razred;
                  ProjekatSkola.Entiteti.Smer smer = s.Load<ProjekatSkola.Entiteti.Smer>(u.JeUpisan.NazivSmera);
                  o.JeUpisan = smer;

                s.SaveOrUpdate(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                // handle exceptions
            }
        }
        public static UcenikBasic azurirajUcenika(UcenikBasic u)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSkola.Entiteti.Ucenik o = s.Load<ProjekatSkola.Entiteti.Ucenik>(u.JedinstveniUpisniBroj);
                o.Ime = u.Ime;
                o.Prezime = u.Prezime;
                o.AdresaStanovanja = u.AdresaStanovanja;
                o.DatumUpisa = u.DatumUpisa;
                ProjekatSkola.Entiteti.Razred razred = s.Load<ProjekatSkola.Entiteti.Razred>(u.PohadjaRazred.RedniBrojRazreda);
                o.PohadjaRazred = razred;
                ProjekatSkola.Entiteti.Smer smer = s.Load<ProjekatSkola.Entiteti.Smer>(u.JeUpisan.NazivSmera);
                o.JeUpisan = smer;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                // handle exceptions
            }

            return u;
        }
        public static UcenikBasic vratiUcenika(string jbu)
        {
            UcenikBasic ub = new UcenikBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSkola.Entiteti.Ucenik o = s.Load<ProjekatSkola.Entiteti.Ucenik>(jbu);
                ProjekatSkola.Entiteti.Razred razred = s.Load<ProjekatSkola.Entiteti.Razred>(o.PohadjaRazred.RedniBrojRazreda);
                ProjekatSkola.Entiteti.Smer smer = s.Load<ProjekatSkola.Entiteti.Smer>(o.JeUpisan.NazivSmera);

                RazredBasic razredBasic = new RazredBasic(o.PohadjaRazred.RedniBrojRazreda);
                SmerBasic smerBasic = new SmerBasic(o.JeUpisan.NazivSmera, o.JeUpisan.MaksimalanBrojUcenika);
                ub = new UcenikBasic(o.JedinstveniUpisniBroj, o.Ime, o.Prezime, o.AdresaStanovanja, o.DatumUpisa, razredBasic, smerBasic);

                s.Close();
            }
            catch (Exception ec)
            {
                // handle exceptions
            }

            return ub;
        }
        public static void obrisiUcenika(string jbu)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProjekatSkola.Entiteti.Ucenik o = s.Load<ProjekatSkola.Entiteti.Ucenik>(jbu);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                // handle exceptions
            }
        }
        #endregion


        #region Smer

        public static SmerBasic vratiSmer(string nazivSmera)
        {
            SmerBasic smer = new SmerBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Smer sm = s.Load<Smer>(nazivSmera);
                smer.NazivSmera = sm.NazivSmera;
                smer.MaksimalanBrojUcenika = sm.MaksimalanBrojUcenika;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja smera: " + nazivSmera + ";\n Greska:" + ec.Message);
            }
            return smer;
        }
        public static List<SmerPregled> vratiSveSmerove()
        {
            List<SmerPregled> smerovi = new List<SmerPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Smer> sviSmerovi = s.Query<Smer>().ToList();

                // Pretvara svaki Predmet u PredmetPregled objekat i dodaje u listu
                foreach (Smer sm in sviSmerovi)
                {
                    smerovi.Add(new SmerPregled(sm.NazivSmera, sm.MaksimalanBrojUcenika));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja svih smerova: " + ec.Message);
            }
            return smerovi;
        }
        public static void dodajSmer(SmerBasic smer)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smer sm = new Smer();
                sm.NazivSmera = smer.NazivSmera;
                sm.MaksimalanBrojUcenika = smer.MaksimalanBrojUcenika;
                s.SaveOrUpdate(sm);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja smera: " + smer.NazivSmera + ";\n Greska:" + ec.Message);
            }
        }
        public static void obrisiSmer(string nazivSmera)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Smer sm = s.Load<Smer>(nazivSmera);

                s.Delete(sm);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom brisanja smera: " + nazivSmera + ";\n Greska:" + ec.Message);
            }
        }
        public static void azurirajSmer(SmerBasic smer)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Smer sm = s.Load<Smer>(smer.NazivSmera);
                sm.NazivSmera = smer.NazivSmera;
                sm.MaksimalanBrojUcenika = smer.MaksimalanBrojUcenika;
                s.SaveOrUpdate(sm);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom azuriranja smera: " + smer.NazivSmera + ";\n Greska: " + ec.Message);
            }
        }
        #endregion

        #region RoditeljskoVece
        public static RoditeljskoVeceBasic vratiRoditelja(string JMBG)
        {
            RoditeljskoVeceBasic vece = new RoditeljskoVeceBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                RoditeljskoVece rv = s.Load<RoditeljskoVece>(JMBG);
                vece.JMBG = rv.JMBG;
                vece.ImeRoditelja = rv.ImeRoditelja;
                vece.PrezimeRoditelja = rv.PrezimeRoditelja;
                vece.Telefon = rv.Telefon;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja roditelja: " + JMBG + ";\n Greska:" + ec.Message);
            }
            return vece;
        }
        public static List<RoditeljskoVecePregled> vratiCeloRoditeljskoVece()
        {
            List<RoditeljskoVecePregled> roditelji = new List<RoditeljskoVecePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IList<RoditeljskoVece> sviRoditelji = s.Query<RoditeljskoVece>().ToList();

                // Pretvara svaki Predmet u PredmetPregled objekat i dodaje u listu
                foreach (RoditeljskoVece rv in sviRoditelji)
                {
                    roditelji.Add(new RoditeljskoVecePregled(rv.JMBG, rv.ImeRoditelja, rv.PrezimeRoditelja, rv.Telefon));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja svih roditelja: " + ec.Message);
            }
            return roditelji;
        }
        public static void dodajRoditelja(RoditeljskoVeceBasic roditelj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RoditeljskoVece novRoditelj = new RoditeljskoVece
                {
                    JMBG = roditelj.JMBG,
                    ImeRoditelja = roditelj.ImeRoditelja,
                    PrezimeRoditelja = roditelj.PrezimeRoditelja,
                    Telefon = roditelj.Telefon
                };
                s.SaveOrUpdate(novRoditelj);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja roditelja: " + roditelj.JMBG + ";\n Greska:" + ec.Message);
            }
        }
        public static void obrisiRoditelja(RoditeljskoVece roditelj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RoditeljskoVece r = s.Load<RoditeljskoVece>(roditelj.JMBG);
                s.Delete(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom brisanja roditelja: " + roditelj.JMBG + ";\n Greska:" + ec.Message);
            }
        }
        public static void azurirajRoditelja(RoditeljskoVeceBasic roditelj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RoditeljskoVece o = s.Load<RoditeljskoVece>(roditelj.JMBG);

                o.JMBG = roditelj.JMBG;
                o.ImeRoditelja = roditelj.ImeRoditelja;
                o.PrezimeRoditelja = roditelj.PrezimeRoditelja;
                o.Telefon = roditelj.Telefon;               

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom azuriranja roditelja: " + roditelj.JMBG + ";\n Greska: " + ec.Message);
            }
        }
        #endregion

        #region Razred
        public static RazredBasic vratiRazred(int redniBrojRazreda)
        {
            RazredBasic razred = new RazredBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Razred rv = s.Load<Razred>(redniBrojRazreda);
                razred.RedniBrojRazreda = rv.RedniBrojRazreda;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja razreda: " + redniBrojRazreda + ";\n Greska:" + ec.Message);
            }
            return razred;

        }
        public static List<RazredPregled> vratiSveRazrede()
        {
            List<RazredPregled> razredi = new List<RazredPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Razred> sviRazredi = s.Query<Razred>().ToList();

                // Pretvara svaki Predmet u PredmetPregled objekat i dodaje u listu
                foreach (Razred rv in sviRazredi)
                {
                    razredi.Add(new RazredPregled(rv.RedniBrojRazreda));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja svih razreda: " + ec.Message);
            }
            return razredi;
        }
        public static void dodajRazred(RazredBasic razred)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Razred r = new Razred
                {
                    RedniBrojRazreda = razred.RedniBrojRazreda
                };
                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja razreda: " + razred.RedniBrojRazreda + ";\n Greska:" + ec.Message);
            }
        }
        public static void obrisiRazred(Razred razred)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Razred o = s.Load<Razred>(razred.RedniBrojRazreda);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom brisanja razreda: " + razred.RedniBrojRazreda + ";\n Greska:" + ec.Message);
            }
        }
        public static void azurirajRazred(RazredBasic razred) 
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Razred o = s.Load<Razred>(razred.RedniBrojRazreda);
                o.RedniBrojRazreda = razred.RedniBrojRazreda;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom azuriranja razreda: " + razred.RedniBrojRazreda + ";\n Greska: " + ec.Message);
            }
        }
        #endregion

        #region Predmet
        public static List<PredmetPregled> vratiSvePredmeteSaSmeraUcenika(string jbu)
        {
            List<PredmetPregled> predmeti = new List<PredmetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                Ucenik ucenik = s.Load<Ucenik>(jbu);     
                //Vraca sve predmete koji su sa smera gde je ucenik
                IList<Predmet> predmets = s.Query<Predmet>().Where(o => o.NazivSmera == ucenik.JeUpisan.NazivSmera).ToList();

               // IList<Predmet> predmets = s.Query<Predmet>().ToList();
                /*
                  IEnumerable<Predmet> predmets = from o in s.Query<Predmet>()
                                           where o.NazivSmera == nazivSmera
                                           select o;
                */

                foreach (Predmet p in predmets)
                {
                   predmeti.Add(new PredmetPregled(p.NazivPredmeta, p.TipPredmeta, p.NazivSmera));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja predmeta sa smera: " + ec.Message);
            }
            return predmeti;

        }
        public static List<StrucniPredmetPregled> vratiStrucnePredmeteSaSmera(string nazivSmera)
        {
            List<StrucniPredmetPregled> predmeti = new List<StrucniPredmetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IList<StrucniPredmet> predmets = s.Query<StrucniPredmet>().ToList();
                
                foreach (StrucniPredmet p in predmets)
                {
                    if (p.NazivSmera == nazivSmera)
                        predmeti.Add(new StrucniPredmetPregled(p.NazivPredmeta, p.TipPredmeta, p.NazivSmera));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja predmeta sa smera: " + ec.Message);
            }
            return predmeti;
        }
        public static List<OpsteobrazovniPredmetPregled> vratiOpsteobrazovnePredmeteSaSmera(string nazivSmera)
        {
            List<OpsteobrazovniPredmetPregled> predmeti = new List<OpsteobrazovniPredmetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IList<OpsteobrazovniPredmet> predmets = s.Query<OpsteobrazovniPredmet>().ToList();
              
                foreach (OpsteobrazovniPredmet p in predmets)
                {
                    if (p.NazivSmera == nazivSmera)
                        predmeti.Add(new OpsteobrazovniPredmetPregled(p.NazivPredmeta, p.TipPredmeta, p.NazivSmera));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja predmeta sa smera: " + ec.Message);
            }
            return predmeti;
        }
        public static List<PredmetPregled> vratiPredmeteSaSmera(string nazivSmera)
        {
            List<PredmetPregled> predmeti = new List<PredmetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Predmet> predmets = s.Query<Predmet>().ToList();
              /*
                IEnumerable<Predmet> predmets = from o in s.Query<Predmet>()
                                         where o.NazivSmera == nazivSmera
                                         select o;
              */

                foreach (Predmet p in predmets)
                {
                    if(p.NazivSmera==nazivSmera)
                    predmeti.Add(new PredmetPregled(p.NazivPredmeta,  p.TipPredmeta, p.NazivSmera));
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom vracanja predmeta sa smera: " + ec.Message);
            }
           return predmeti;

        }
        public static List<PredmetPregled> vratiSvePredmete()
        {
            List<PredmetPregled> sviPredmetiPregled = new List<PredmetPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Dohvata sve predmete iz baze podataka
                    IList<Predmet> sviPredmeti = s.Query<Predmet>().ToList();

                    // Pretvara svaki Predmet u PredmetPregled objekat i dodaje u listu
                    foreach (Predmet predmet in sviPredmeti)
                    {
                        sviPredmetiPregled.Add(new PredmetPregled(predmet.NazivPredmeta,predmet.TipPredmeta,predmet.NazivSmera));
                    }
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom dohvatanja svih predmeta: " + ec.Message);
            }
            return sviPredmetiPregled;
        }
        public static List<StrucniPredmetPregled> vratiSveStrucnePredmete() 
        {
            List<StrucniPredmetPregled> sviPredmetiPregled = new List<StrucniPredmetPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Dohvata sve predmete iz baze podataka
                    IEnumerable<StrucniPredmet> sviPredmeti = s.Query<StrucniPredmet>().ToList();

                    // Pretvara svaki Predmet u PredmetPregled objekat i dodaje u listu
                    foreach (StrucniPredmet predmet in sviPredmeti)
                    {
                        sviPredmetiPregled.Add(new StrucniPredmetPregled(predmet.NazivPredmeta, predmet.TipPredmeta, predmet.NazivSmera));
                    }
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom pribavljanja svih strucnih predmeta: " + ec.Message);
            }
            return sviPredmetiPregled;
        }
        public static List<OpsteobrazovniPredmetPregled> vratiSveOpsteobrazovnePredmete() 
        {
            List<OpsteobrazovniPredmetPregled> sviPredmetiPregled = new List<OpsteobrazovniPredmetPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Dohvata sve predmete iz baze podataka
                    IEnumerable<OpsteobrazovniPredmet> sviPredmeti = s.Query<OpsteobrazovniPredmet>().ToList();

                    // Pretvara svaki Predmet u PredmetPregled objekat i dodaje u listu
                    foreach (OpsteobrazovniPredmet predmet in sviPredmeti)
                    {
                        sviPredmetiPregled.Add(new OpsteobrazovniPredmetPregled(predmet.NazivPredmeta, predmet.TipPredmeta, predmet.NazivSmera));
                    }
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom pribavljanja svih opsteobrazovnih predmeta: " + ec.Message);
            }
            return sviPredmetiPregled;
        }
        public static OpsteobrazovniPredmetBasic vrtatiOpsteobrazovniPredmet(string naziv)
        {
            OpsteobrazovniPredmetBasic oop = new OpsteobrazovniPredmetBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                OpsteobrazovniPredmet p = s.Load<OpsteobrazovniPredmet>(naziv);
                oop.NazivPredmeta = p.NazivPredmeta;
                oop.NazivSmera = p.NazivSmera;
                oop.TipPredmeta = "OOP";

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dohvatanja opsteobrazovnog predmeta: "+naziv +";\n Greska:"+ ec.Message);
            }
            return oop;
        }     
        public static StrucniPredmetBasic vratiStrucniPredmet(string naziv)
        {
            StrucniPredmetBasic oop = new StrucniPredmetBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StrucniPredmet p = s.Load<StrucniPredmet>(naziv);
                oop.NazivPredmeta = p.NazivPredmeta;
                oop.NazivSmera = p.NazivSmera;
                oop.TipPredmeta = "STR";

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dohvatanja strucnog predmeta: " + naziv + ";\n Greska:" + ec.Message);
            }
            return oop;
        }
        public static PredmetBasic vratiPredmet(string naziv)
        {
            PredmetBasic oop = new PredmetBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Load<Predmet>(naziv);
                oop.NazivPredmeta = p.NazivPredmeta;
                oop.NazivSmera = p.NazivSmera;
                oop.TipPredmeta = p.TipPredmeta;

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dohvatanja predmeta: " + naziv + ";\n Greska:" + ec.Message);
            }
            return oop;
        }
        public static void dodajPredmet(PredmetBasic p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {                  
                    Predmet noviPredmet = new Predmet
                    {
                        NazivPredmeta = p.NazivPredmeta,
                        TipPredmeta = p.TipPredmeta,
                        NazivSmera = p.NazivSmera
                    };
                    s.SaveOrUpdate(noviPredmet);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja predmeta: " + ec.Message);
            }
        }
        public static void dodajStrucniPredmet(StrucniPredmetBasic STR)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StrucniPredmet sp = new StrucniPredmet();
                sp.NazivPredmeta = STR.NazivPredmeta;
                sp.TipPredmeta = STR.TipPredmeta;
                sp.NazivSmera = STR.NazivSmera;

                s.Save(sp);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja Strucnog predmeta: " + ec.Message);
            }

        }
        public static void dodajOpsteobrazovniPredmet(OpsteobrazovniPredmetBasic OOP)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                OpsteobrazovniPredmet sp = new OpsteobrazovniPredmet();
                sp.NazivPredmeta = OOP.NazivPredmeta;
                sp.TipPredmeta = OOP.TipPredmeta;
                sp.NazivSmera = OOP.NazivSmera;

                s.Save(sp);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja opsteobrazovnog predmeta: " + ec.Message);
            }
        }
        public static void obrisiPredmet(string nazivPredmeta)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Predmet p = s.Load<Predmet>(nazivPredmeta);
                    s.Delete(p);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom brisanja predmeta: " + ec.Message);
            }
        }
        public static void azurirajPredmet(PredmetBasic predmet) 
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet o = s.Load<Predmet>(predmet.NazivPredmeta);
                o.NazivPredmeta = predmet.NazivPredmeta;
                o.TipPredmeta = predmet.TipPredmeta;
                o.NazivSmera = predmet.NazivSmera;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom azuriranja predmeta: " + predmet.NazivPredmeta + ";\n Greska: " + ec.Message);
            }
        }
        public static void azurirajOpsteobrazovniPredmet(OpsteobrazovniPredmetBasic OOP)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                OpsteobrazovniPredmet o = s.Load<OpsteobrazovniPredmet>(OOP.NazivPredmeta);
                o.NazivPredmeta = OOP.NazivPredmeta;
                o.TipPredmeta = OOP.TipPredmeta;
                o.NazivSmera = OOP.NazivSmera;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom azuriranja opsteobrazovnog predmeta: " + OOP.NazivPredmeta +";\n Greska: "+ ec.Message);
            }
        }
        public static void azurirajStrucniPredmet(StrucniPredmetBasic STR)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StrucniPredmet o = s.Load<StrucniPredmet>(STR.NazivPredmeta);
                o.NazivPredmeta = STR.NazivPredmeta;
                o.TipPredmeta = STR.TipPredmeta;
                o.NazivSmera = STR.NazivSmera;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom azuriranja strucnog predmeta predmeta: " + STR.NazivPredmeta + ";\n Greska: " + ec.Message);
            }
        }
        #endregion

        #region Ocena
        public static List<OcenaPregled> vratiSveOceneUcenika(string ucenikID)
        {
           List<OcenaPregled> oceneUcenikaPregled = new List<OcenaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                List<Ocena> ocene = s.Query<Ocena>().Where(o => o.JeDobio.JedinstveniUpisniBroj == ucenikID).ToList();

                foreach (Ocena ocena in ocene)
                {
                    oceneUcenikaPregled.Add(new OcenaPregled(ocena.Id,ocena.JeIz.NazivPredmeta, ocena.JeDobio.JedinstveniUpisniBroj, ocena.DatumDobijanjaOcene, ocena.NumerickaVrednost, ocena.TekstualniOpis));
                }

                s.Close();
            }
            catch(Exception ec) { }
            return oceneUcenikaPregled;
        }      
        public static List<OcenaPregled> vratiSveOcenePredmeta(string nazivPredmeta)
        {
            List<OcenaPregled> ocenePredmetaPregled = new List<OcenaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ocena> ocene = from o in s.Query<Ocena>()
                                           where o.NazivPredmeta == nazivPredmeta
                                           select o;
                foreach (Ocena ocena in ocene)
                {
                    ocenePredmetaPregled.Add(new OcenaPregled(ocena.Id, ocena.NazivPredmeta, ocena.JedinstveniBrojUcenika, ocena.DatumDobijanjaOcene, ocena.NumerickaVrednost, ocena.TekstualniOpis));
                }

                s.Close();
            }
            catch (Exception ec) { }
            return ocenePredmetaPregled;
        }
        public static List<OcenaPregled> vratiSveOcene()
        {
            List<OcenaPregled> sveOcenePregled = new List<OcenaPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Dohvata sve ocene iz baze podataka
                    IList<Ocena> sveOcene = s.Query<Ocena>().ToList();

                    // Pretvara svaku Ocenu u OcenaPregled objekat i dodaje u listu
                    foreach (Ocena ocena in sveOcene)
                    {
                        sveOcenePregled.Add(new OcenaPregled(ocena.Id, ocena.NazivPredmeta, ocena.JedinstveniBrojUcenika, ocena.DatumDobijanjaOcene, ocena.NumerickaVrednost, ocena.TekstualniOpis));
                    }
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom dohvatanja svih ocena: " + ec.Message);
            }
            return sveOcenePregled;
        }
        public static OcenaBasic vratiOcenu(int id)
        {
            OcenaBasic ob = new OcenaBasic();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Ocena o = s.Load<Ocena>(id);
                    ob = new OcenaBasic(o.Id, o.NazivPredmeta, o.JedinstveniBrojUcenika, o.DatumDobijanjaOcene, o.NumerickaVrednost, o.TekstualniOpis);
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom dohvatanja ocene: "+ id + ec.Message);
            }
            return ob;
        }
        public static OcenaBasic azurirajOcenu(OcenaBasic o)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {

                    Ocena ocena = s.Load<Ocena>(o.Id);

                    ocena.NazivPredmeta = o.NazivPredmeta;
                    ocena.JedinstveniBrojUcenika = o.JedinstveniBrojUcenika;
                    ocena.DatumDobijanjaOcene = o.DatumDobijanjaOcene;
                    ocena.NumerickaVrednost = o.NumerickaVrednost;
                    ocena.TekstualniOpis = o.TekstualniOpis;

                    Ucenik u = new Ucenik();
                    if (ocena.JedinstveniBrojUcenika != o.JedinstveniBrojUcenika)
                        u = s.Load<Ucenik>(o.JedinstveniBrojUcenika);


                    Predmet p = new Predmet();
                    if (ocena.NazivPredmeta != o.NazivPredmeta)
                        p = s.Load<Predmet>(o.NazivPredmeta);


                    ocena.JeDobio = u;
                    ocena.JeIz = p;

                    s.Update(ocena);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ec) { }
            return o;
        }
        public static void dodajOcenu(OcenaBasic o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ocena ocena = new Ocena();
                ocena.NazivPredmeta = o.NazivPredmeta;
                ocena.JedinstveniBrojUcenika = o.JedinstveniBrojUcenika;
                ocena.DatumDobijanjaOcene = o.DatumDobijanjaOcene;
                ocena.NumerickaVrednost = o.NumerickaVrednost;
                ocena.TekstualniOpis = o.TekstualniOpis;

                Predmet p = new Predmet();
                p = s.Load<Predmet>(o.NazivPredmeta);
                Ucenik u = new Ucenik();
                u = s.Load<Ucenik>(o.JedinstveniBrojUcenika);

                ocena.JeDobio = u;
                ocena.JeIz = p;

                s.SaveOrUpdate(ocena);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void obrisiOcenu(int id)
       {
            try
            {
                ISession s = DataLayer.GetSession();

                Ocena o = s.Load<Ocena>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion

        #region Osoblje
        public static NastavnoOsobljeSaPunomNormomBasic vratiNastavnikaSaPunomNormom(string jmbg)
        {
            NastavnoOsobljeSaPunomNormomBasic nastavnik = new NastavnoOsobljeSaPunomNormomBasic();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    OsobljeSaPunomNormom osoba = s.Load<OsobljeSaPunomNormom>(jmbg);
                    nastavnik = new NastavnoOsobljeSaPunomNormomBasic(osoba.JMBG, osoba.Ime, osoba.Prezime, osoba.ImeRoditelja, osoba.AdresaStanovanja, osoba.BrojCasova);
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom dohvatanja nastavnika sa punom normom: " + jmbg + ec.Message);
            }
            return nastavnik;

        }
        public static NastavnoOsobljeSaDelomNormeBasic vratiNastavnikaSaDelomNorme(string jmbg)
        {
            NastavnoOsobljeSaDelomNormeBasic nastavnik = new NastavnoOsobljeSaDelomNormeBasic();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    NastavnoOsobljeSaDelomCasova osoba = s.Load<NastavnoOsobljeSaDelomCasova>(jmbg);
                    nastavnik = new NastavnoOsobljeSaDelomNormeBasic(osoba.JMBG, osoba.Ime, osoba.Prezime, osoba.ImeRoditelja, osoba.AdresaStanovanja, osoba.BrojCasovaNedeljno, osoba.NazivOstalihSkola);
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom dohvatanja nastavnika sa delom norme: " + jmbg + ec.Message);
            }
            return nastavnik;

        }
        public static NenastavnoOsobljeBasic vratiNenastavnoOsoblje(string jmbg)
        {
            NenastavnoOsobljeBasic zaposleni = new NenastavnoOsobljeBasic();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    NenastavnoOsoblje osoba = s.Load<NenastavnoOsoblje>(jmbg);
                    zaposleni = new NenastavnoOsobljeBasic(osoba.JMBG, osoba.Ime, osoba.Prezime, osoba.ImeRoditelja, osoba.AdresaStanovanja, osoba.ImeSektora,osoba.StrucnaSprema);
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom dohvatanja nenastavnog osoblja: " + jmbg + ec.Message);
            }
            return zaposleni;

        }
        public static List<NastavnoOsobljeSaPunomNormomPregled> vratiSveNastavnikeSaPunomNormom()
        {
            List<NastavnoOsobljeSaPunomNormomPregled> sviNastavniciSaPunomNormom = new List<NastavnoOsobljeSaPunomNormomPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Dohvata sve predmete iz baze podataka
                   // IEnumerable<OsobljeSaPunomNormom> svoOsobljeSaPunomNormom = s.Query<OsobljeSaPunomNormom>().ToList();
                    IList<OsobljeSaPunomNormom> svoOsobljeSaPunomNormom = s.Query<OsobljeSaPunomNormom>().ToList();
                    // Pretvara svaki Predmet u PredmetPregled objekat i dodaje u listu
                    foreach (OsobljeSaPunomNormom osoba in svoOsobljeSaPunomNormom)
                    {
                        sviNastavniciSaPunomNormom.Add(new NastavnoOsobljeSaPunomNormomPregled(osoba.JMBG, osoba.Ime, osoba.Prezime, osoba.ImeRoditelja,osoba.AdresaStanovanja,osoba.BrojCasova));
                    }
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom pribavljanja svih nastavnika sa punom normom: " + ec.Message);
            }
            return sviNastavniciSaPunomNormom;
        }
        public static List<NastavnoOsobljeSaDelomNormePregled> vratiSveNastavnikeSaDelomNorme()
        {
            List<NastavnoOsobljeSaDelomNormePregled> sviNastavniciSaDelomNorme = new List<NastavnoOsobljeSaDelomNormePregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Dohvata sve predmete iz baze podataka
                    //IEnumerable<NastavnoOsobljeSaDelomCasova> svoOsobljeSaDelomNorme = s.Query<NastavnoOsobljeSaDelomCasova>().ToList();
                    IList<NastavnoOsobljeSaDelomCasova> svoOsobljeSaDelomNorme = s.Query<NastavnoOsobljeSaDelomCasova>().ToList();
                    // Pretvara svaki Predmet u PredmetPregled objekat i dodaje u listu
                    foreach (NastavnoOsobljeSaDelomCasova osoba in svoOsobljeSaDelomNorme)
                    {
                        sviNastavniciSaDelomNorme.Add(new NastavnoOsobljeSaDelomNormePregled(osoba.JMBG, osoba.Ime, osoba.Prezime, osoba.ImeRoditelja, osoba.AdresaStanovanja, osoba.BrojCasovaNedeljno,osoba.NazivOstalihSkola));
                    }
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom pribavljanja svih nastavnika sa delom norme: " + ec.Message);
            }
            return sviNastavniciSaDelomNorme;
        }
        public static List<NenastavnoOsobljePregled> vratiSvoNenastavnoOsoblje()
        {
            List<NenastavnoOsobljePregled> svoNenastavnoOsoblje = new List<NenastavnoOsobljePregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Dohvata sve predmete iz baze podataka
                    IEnumerable<NenastavnoOsoblje> svi = s.Query<NenastavnoOsoblje>().ToList();

                    // Pretvara svaki Predmet u PredmetPregled objekat i dodaje u listu
                    foreach (NenastavnoOsoblje osoba in svi)
                    {
                        svoNenastavnoOsoblje.Add(new NenastavnoOsobljePregled(osoba.JMBG, osoba.Ime, osoba.Prezime, osoba.ImeRoditelja, osoba.AdresaStanovanja, osoba.ImeSektora, osoba.StrucnaSprema));
                    }
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Logovanje izuzetka
                Console.WriteLine("Greška prilikom pribavljanja svih nenastavnih zaposlenih: " + ec.Message);
            }
            return svoNenastavnoOsoblje;
        }
        public static void dodajNastavnoOsobljeSaPunomNormom(NastavnoOsobljeSaPunomNormomBasic  nastavnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                OsobljeSaPunomNormom n = new OsobljeSaPunomNormom();
                n.JMBG = nastavnik.JMBG;
                n.Ime = nastavnik.Ime;
                n.Prezime = nastavnik.Prezime;
                n.ImeRoditelja = nastavnik.ImeRoditelja;
                n.AdresaStanovanja = nastavnik.AdresaStanovanja;
                n.BrojCasova = nastavnik.BrojCasova;

                s.SaveOrUpdate(n); 
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja nastavnika sa punom normom: " + nastavnik.JMBG +"; \nGreska:"+ ec.Message);
            }
        }
        public static void dodajNastavnoOsobljeSaDelomNorme(NastavnoOsobljeSaDelomNormeBasic nastavnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NastavnoOsobljeSaDelomCasova n = new NastavnoOsobljeSaDelomCasova();
                n.JMBG = nastavnik.JMBG;
                n.Ime = nastavnik.Ime;
                n.Prezime = nastavnik.Prezime;
                n.ImeRoditelja = nastavnik.ImeRoditelja;
                n.AdresaStanovanja = nastavnik.AdresaStanovanja;
                n.BrojCasovaNedeljno = nastavnik.BrojCasovaNedeljno;
                n.NazivOstalihSkola = nastavnik.NazivOstalihSkola;

                s.SaveOrUpdate(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja nastavnika sa delom norme: " + nastavnik.JMBG + "; \nGreska:" + ec.Message);
            }
        }
        public static void dodajNenastavnoOsoblje(NenastavnoOsobljeBasic zaposleni)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NenastavnoOsoblje n = new NenastavnoOsoblje();
                n.JMBG = zaposleni.JMBG;
                n.Ime = zaposleni.Ime;
                n.Prezime = zaposleni.Prezime;
                n.ImeRoditelja = zaposleni.ImeRoditelja;
                n.AdresaStanovanja = zaposleni.AdresaStanovanja;
                n.ImeSektora = zaposleni.ImeSektora;
                n.StrucnaSprema = zaposleni.StrucnaSprema;

                s.SaveOrUpdate(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja zaposlenog(nenastavno osoblje) : " + zaposleni.JMBG + "; \nGreska:" + ec.Message);
            }
        }
        public static void obrisiNastavnoOsobljeSaPunomNormom(string JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                OsobljeSaPunomNormom n = s.Load<OsobljeSaPunomNormom>(JMBG);
               
                s.Delete(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom brisanja nastavnika sa punom normom: " + JMBG + "; \nGreska:" + ec.Message);
            }
        }
        public static void obrisiNastavnoOsobljeDelomNorme(string JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NastavnoOsobljeSaDelomCasova n = s.Load<NastavnoOsobljeSaDelomCasova>(JMBG);

                s.Delete(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom brisanja nastavnika sa delom norme: " + JMBG + "; \nGreska:" + ec.Message);
            }
        }
        public static void obrisiNenastavnoOsoblje(string JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NenastavnoOsoblje n = s.Load<NenastavnoOsoblje>(JMBG);

                s.Delete(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom brisanja  zaposlenog (nenastavno osoblje): " + JMBG + "; \nGreska:" + ec.Message);
            }
        }
        public static void azurirajNastavnoOsobljeSaPunomNormom(NastavnoOsobljeSaPunomNormomBasic nastavnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OsobljeSaPunomNormom o = s.Load<OsobljeSaPunomNormom>(nastavnik.JMBG);
                o.JMBG = nastavnik.JMBG;
                o.Ime = nastavnik.Ime;
                o.Prezime = nastavnik.Prezime;
                o.ImeRoditelja = nastavnik.ImeRoditelja;
                o.BrojCasova = nastavnik.BrojCasova;
                o.AdresaStanovanja = nastavnik.AdresaStanovanja;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom azuriranja nastavnog osoblja sa punom normom: " + nastavnik.JMBG + ";\n Greska: " + ec.Message);
            }
        }
        public static void azurirajNastavnoOsobljeSaDelomNorme(NastavnoOsobljeSaDelomNormeBasic nastavnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NastavnoOsobljeSaDelomCasova o = s.Load<NastavnoOsobljeSaDelomCasova>(nastavnik.JMBG);
                o.JMBG = nastavnik.JMBG;
                o.Ime = nastavnik.Ime;
                o.Prezime = nastavnik.Prezime;
                o.ImeRoditelja = nastavnik.ImeRoditelja;
                o.BrojCasovaNedeljno = nastavnik.BrojCasovaNedeljno;
                o.AdresaStanovanja = nastavnik.AdresaStanovanja;
                o.NazivOstalihSkola = nastavnik.NazivOstalihSkola;
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom azuriranja nastavnog osoblja sa delom norme: " + nastavnik.JMBG + ";\n Greska: " + ec.Message);
            }
        }
        public static void azurirajNenastavnoOsoblje(NenastavnoOsobljeBasic zaposleni)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NenastavnoOsoblje o = s.Load<NenastavnoOsoblje>(zaposleni.JMBG);
                o.JMBG = zaposleni.JMBG;
                o.Ime = zaposleni.Ime;
                o.Prezime = zaposleni.Prezime;
                o.ImeRoditelja = zaposleni.ImeRoditelja;
                o.AdresaStanovanja = zaposleni.AdresaStanovanja;
                o.StrucnaSprema = zaposleni.StrucnaSprema;
                o.ImeSektora = zaposleni.ImeSektora;
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom azuriranja zaposlenog (nastavno osoblje): " + zaposleni.JMBG + ";\n Greska: " + ec.Message);
            }
        }
        #endregion

        #region AngazovanSaPunomNormom
        public static void dodajAngazovanjeSaPunomNormom(AngazovanSaPunomNormomBasic angazovan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AngazovanSaPunomNormom a = new AngazovanSaPunomNormom();
                a.Id = new AngazovanSaPunomNormomId();
                a.Id.NastavnikSaPunomNormomAngazovan = s.Load<OsobljeSaPunomNormom>(angazovan.Id.NastavnikSaPunomNormomAngazovan);
                a.Id.PredmetNaKomeAngazovanNastavnikSaPunomNormom = s.Load<Predmet>(angazovan.Id.PredmetNaKomeAngazovanNastavnikSaPunomNormom);
                a.DatumAngazovanja = angazovan.DatumAngazovanja;
                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja angazovanja sa punom normom " + ec.Message);
            }
        }
        public static void obrisiAngazovanjeSaPunomNormom(string nazivPredmeta, string jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AngazovanSaPunomNormom a = new AngazovanSaPunomNormom();
                AngazovanSaPunomNormomId aId = new AngazovanSaPunomNormomId();
                aId.NastavnikSaPunomNormomAngazovan = s.Load<OsobljeSaPunomNormom>(jmbg);
                aId.PredmetNaKomeAngazovanNastavnikSaPunomNormom = s.Load<Predmet>(nazivPredmeta);
                a = s.Load<AngazovanSaPunomNormom>(aId);

                s.Delete(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom brisanja angazovanja sa punom normom " + ec.Message);
            }

        }
        public static void azurirajAngazovanjeSaPunomNormom(AngazovanSaPunomNormomBasic angazovanje)
        {         

        }
        #endregion

        #region AngazovanSaDelomNorme

        public static void dodajAngazovanjeSaDelomNorme(AngazovanSaDelomNormeBasic angazovan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AngazovanSaDelomNorme a = new AngazovanSaDelomNorme();
                a.Id = new AngazovanSaDelomNormeId();
                a.Id.NastavnikSaDelomCasovaAngazovan = s.Load<NastavnoOsobljeSaDelomCasova>(angazovan.Id.NastavnikSaDelomCasovaAngazovan);
                a.Id.PredmetNaKomeAngazovanNastavnikSaDelomCasova = s.Load<Predmet>(angazovan.Id.PredmetNaKomeAngazovanNastavnikSaDelomCasova);
                a.DatumAngazovanja = angazovan.DatumAngazovanja;
                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom dodavanja angazovanja sa delom norme " + ec.Message);
            }
        }
        public static void obrisiAngazovanjeSaDelomNorme(string nazivPredmeta, string jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AngazovanSaDelomNorme a = new AngazovanSaDelomNorme();
                AngazovanSaDelomNormeId aId = new AngazovanSaDelomNormeId();
                aId.NastavnikSaDelomCasovaAngazovan = s.Load<NastavnoOsobljeSaDelomCasova>(jmbg);
                aId.PredmetNaKomeAngazovanNastavnikSaDelomCasova = s.Load<Predmet>(nazivPredmeta);
                a = s.Load<AngazovanSaDelomNorme>(aId);

                s.Delete(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Greška prilikom brisanja angazovanja sa delom norme " + ec.Message);
            }

        }
        public static void azurirajAngazovanjeSaDelomNorme()
        {

        }
        #endregion
    }
}
