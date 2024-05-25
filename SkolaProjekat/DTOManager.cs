using NHibernate;
using ProjekatSkola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat
{
    public class DTOManager
    {
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
                SmerBasic smerBasic = new SmerBasic(o.JeUpisan.Id, o.JeUpisan.NazivSmera, o.JeUpisan.MaksimalanBrojUcenika);
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
        #endregion

        #region RoditeljskoVece
        #endregion

        #region Razred
        #endregion

        #region Predmet
        #endregion

        #region Ocena
        public static List<OcenaPregled> vratiSveOceneUcenika(string ucenikID)
        {
           List<OcenaPregled> oceneUcenikaPregled = new List<OcenaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ocena> ocene = from o in s.Query<Ocena>()
                                                      where o.JedinstveniBrojUcenika == ucenikID
                                                      select o;
                foreach (Ocena ocena in ocene)
                {
                    oceneUcenikaPregled.Add(new OcenaPregled(ocena.NazivPredmeta, ocena.JedinstveniBrojUcenika, ocena.DatumDobijanjaOcene, ocena.NumerickaVrednost, ocena.TekstualniOpis));
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
                    ocenePredmetaPregled.Add(new OcenaPregled(ocena.NazivPredmeta, ocena.JedinstveniBrojUcenika, ocena.DatumDobijanjaOcene, ocena.NumerickaVrednost, ocena.TekstualniOpis));
                }

                s.Close();
            }
            catch (Exception ec) { }
            return ocenePredmetaPregled;
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
        #endregion

        #region AngazovanSaPunomNormom
        #endregion

        #region AngazovanSaDelomNorme
        #endregion
    }
}
