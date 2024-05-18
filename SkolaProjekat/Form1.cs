﻿/*using NHibernate;
using SkolaProjekat.Entiteti;*/
//ovde je nepotrebno valjda
using NHibernate;
using ProjekatSkola.Entiteti;
using System.Text;

namespace SkolaProjekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnUcitavanje_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();//ovde baca exception

                if (session != null)
                {
                    AngazovanSaDelomNorme? p = await session.LoadAsync<AngazovanSaDelomNorme>("4567890123456");//jmbg nastavnika
                                                                                                               // MessageBox.Show($"Angazovanje sa delom norme sa ID: 61 \"{p.NazivPredmeta}\" je pronađena.");


                    MessageBox.Show($"Angazovanje sa delom norme sa ID: 4567890123456 \"{p.NazivPredmeta}\" je pronađeno.");

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                session?.Close();//ovo i finally blok sam ja dodao
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    AngazovanSaDelomNorme angSaDelomNorme = new()
                    {
                        NazivPredmeta = "Matematika",
                        JMBGNastavnika = "2102000436511",
                        DatumAngazovanja = DateTime.Now
                    };

                    //await session.SaveAsync(p);
                    await session.SaveOrUpdateAsync(angSaDelomNorme);
                    await session.FlushAsync();//sve modifikacije koje imamo budu prosledjene bazi
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
            }
        }

        private async void btnManyToOne_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Ucenik u = await session.LoadAsync<Ucenik>("124");

                    MessageBox.Show($"Ucenik sa jedinstvenim upisnim brojem: {u.JedinstveniUpisniBroj} je upisan na smeru: {u.JeUpisan?.NazivSmera ?? ""}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
            }
        }

        private async void btnOneToMany_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Smer s = await session.LoadAsync<Smer>("Elektrotehnika");

                    StringBuilder sb = new();

                    sb.AppendLine($"Smer sa ID Elektrotehnika naziva: {s.NazivSmera} ima ucenike:");

                    foreach (Ucenik u in s.Ucenici)
                    {
                        sb.AppendLine($"  Ucenik sa ID: {u.JedinstveniUpisniBroj} i imenom: {u.Ime} i prezimenom: {u.Prezime}");
                    }

                    MessageBox.Show(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
            }
        }

        private async void btnUcitavanjeRazreda_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();//ovde baca exception

                if (session != null)
                {
                    Razred? p = await session.LoadAsync<Razred>(1);
                    // MessageBox.Show($"Angazovanje sa delom norme sa ID: 61 \"{p.NazivPredmeta}\" je pronađena.");


                    MessageBox.Show($"Redni broj razreda je {p.RedniBrojRazreda}");

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                session?.Close();//ovo i finally blok sam ja dodao
            }
        }

        private async void btnDodavanjeUcenika_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Smer s = new()
                    {
                        NazivSmera = "Arhitektura",
                        MaksimalanBrojUcenika = 100
                    };

                    Ucenik u = new()
                    {
                        JedinstveniUpisniBroj = "145",
                        Ime = "Stefan",
                        Prezime = "Stefanovic",
                        AdresaStanovanja = "Niska 22",
                        //NazivSmera= "Arhitektura",
                        DatumUpisa = DateTime.Now,
                        RedniBrojRazreda = 3,
                        JeUpisan = s
                    };

                    // Ako ne koristimo Cascade, onda moramo ručno da dodamo Odeljenje u bazu
                    // Pre nego što sačuvamo prodavnicu sa kojom je povezano
                    // ova linija je mogla da bude i ispod, sve dok je pre Save za Prodavnicu
                    // await session.SaveAsync(o);

                    // U slučaju da čuvamo svaki objekat ponaosob, pre povezivanja, onda nam nisu neophodne
                    // Cascade i Inverse

                    s.Ucenici.Add(u);

                    // Takođe je neophodno Odeljenju podesiti Prodavnicu kojoj pripada.
                    // Ukoliko to ne uradimo, Odeljenje će imati BROJP postavljen na NULL (FK ka Prodavnici)
                    // što ne želimo (BROJP bi trebalo da je NOT NULL)
                    // da u bazi ne bi imali Odeljenja koja nisu povezana ni sa jednom prodavnicom.
                    // Dodeljivanje Prodavnice Odeljenju ovde nije potrebno, zato što je urađeno kroz inicijalizaciju Odeljenja
                    // o.PripadaProdavnici = p;

                    // Na primer, može da bude i ovde
                    // await session.SaveAsync(o);

                    await session.SaveAsync(s);
                    await session.FlushAsync();

                    StringBuilder sb = new();
                    sb.AppendLine($"Upisan je smer sa ucenicima:");
                    sb.AppendLine(s.ToString());
                    sb.AppendLine();
                    sb.AppendLine($"Takođe, upisano je i ucenik ovog smera sa podacima:");
                    sb.AppendLine(u.ToString());

                    MessageBox.Show(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void btnManyToMany_Click(object sender, EventArgs e)
        {
            ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (session != null)
            {
                Predmet predmet = await session.LoadAsync<Predmet>("Matematika");

                StringBuilder sb = new();
                sb.AppendLine($"Radnik sa ID: 81 i imenom: {predmet.NazivPredmeta} se slusa na smerovima:");

                foreach (Smer smer in predmet.Smerovi)
                {
                    sb.AppendLine(smer.ToString());
                }

                MessageBox.Show(sb.ToString());

                Smer s = await session.LoadAsync<Smer>("Elektrotehnika");

                sb.Clear();
                sb.AppendLine($"Smer sa nazivom: {s.NazivSmera} ima predmete:");

                foreach (Predmet p in s.Predmeti)
                {
                    sb.AppendLine(p.ToString());
                }

                MessageBox.Show(sb.ToString());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session?.Close();
        }
        }
    }
}
    
    
