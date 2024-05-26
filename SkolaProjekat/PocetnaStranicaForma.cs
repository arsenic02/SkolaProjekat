/*using NHibernate;
using SkolaProjekat.Entiteti;*/
//ovde je nepotrebno valjda
using NHibernate;
using NHibernate.Linq;
using ProjekatSkola.Entiteti;
using SkolaProjekat.Entiteti;
using System.Text;
using SkolaProjekat.Forme;

namespace SkolaProjekat
{
    public partial class PocetnaStranicaForma : Form
    {
        public PocetnaStranicaForma()
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


                    //MessageBox.Show($"Angazovanje sa delom norme sa ID: 4567890123456 \"{p.NazivPredmeta}\" je pronađeno.");

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
            /*
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
            }*/
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
                        MaksimalanBrojUcenika = "100"
                    };

                    Ucenik u = new()
                    {
                        JedinstveniUpisniBroj = "145",
                        Ime = "Stefan",
                        Prezime = "Stefanovic",
                        AdresaStanovanja = "Niska 22",
                        //NazivSmera= "Arhitektura",
                        //DatumUpisa = DateTime.Now,
                        DatumUpisa = new DateTime(2021, 3, 3),
                        //RedniBrojRazreda = 3,//zamenjeno sa svojstvomPohadja
                        JeUpisan = s
                    };

                    s.Ucenici.Add(u);

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
            //ja nzm zasto ne radi lepo
            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Predmet predmet = await session.LoadAsync<Predmet>("Matematika");

                    StringBuilder sb = new();
                    sb.AppendLine($"{predmet.NazivPredmeta} se slusa na smerovima:");

                    foreach (Smer smer in predmet.Smerovi)
                    {
                        //sb.AppendLine(smer.ToString());//zasto prazan string
                        sb.AppendLine(smer.NazivSmera);
                    }

                    MessageBox.Show(sb.ToString());

                    Smer s = await session.LoadAsync<Smer>("Elektrotehnika");

                    sb.Clear();
                    sb.AppendLine($"Smer sa nazivom {s.NazivSmera} ima predmete:");//zasto prazan string

                    foreach (Predmet p in s.Predmeti)
                    {
                        //sb.AppendLine(p.ToString());
                        sb.AppendLine(p.NazivPredmeta);
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

        private async void btnDodavanjePredmeta_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Smer smer = new()
                    {
                        NazivSmera = "Medicinski tehnicar",
                        MaksimalanBrojUcenika = "30"
                    };

                    Predmet predmet = new()
                    {

                        NazivPredmeta = "Anatomija",
                        TipPredmeta = "Osnovni",
                        //JedinstveniBrojUcenika = 123,
                        NazivSmera = "Medicinski tehnicar" //i ovako i onako greska
                    };

                    // Radik upisuje koja je Prodavnica u kojoj radi,
                    // Prodavnica upisuje Radnika koji radi, a posle upisivanja, ta veza se smešta
                    // u tabelu RADI_U
                    predmet.Smerovi.Add(smer);
                    smer.Predmeti.Add(predmet);

                    await session.SaveAsync(smer);
                    await session.SaveAsync(predmet);

                    await session.FlushAsync();

                    MessageBox.Show($"""
                    Radnik:
                    {predmet.ToString()}
                    radi u prodavnici:
                    {smer.ToString()}.
                    """);
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

        private async void AbtnAngazovanSaDelomCasova_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    // Učitavanje postojećih entiteta iz baze
                    NastavnoOsobljeSaDelomCasova nastavnoOsobljeSaDelomCasova = await session.LoadAsync<NastavnoOsobljeSaDelomCasova>("4567890123456");
                    Predmet predmet = await session.LoadAsync<Predmet>("Matematika");

                    // Proveravanje da li veza već postoji
                    var existingRecord = await session.Query<AngazovanSaDelomNorme>()
                        .Where(a => a.Id.NastavnikSaDelomCasovaAngazovan.JMBG == nastavnoOsobljeSaDelomCasova.JMBG &&
                                    a.Id.PredmetNaKomeAngazovanNastavnikSaDelomCasova.NazivPredmeta == predmet.NazivPredmeta)
                        .FirstOrDefaultAsync();

                    if (existingRecord == null)
                    {
                        // Kreiranje novog zapisa u tabeli ANGAZOVAN_SA_DELOM_NORME
                        AngazovanSaDelomNorme angazovan = new()
                        {
                            Id = new AngazovanSaDelomNormeId()
                            {
                                PredmetNaKomeAngazovanNastavnikSaDelomCasova = predmet,
                                NastavnikSaDelomCasovaAngazovan = nastavnoOsobljeSaDelomCasova
                            },
                            DatumAngazovanja = new DateTime(2011, 10, 12)
                        };

                        await session.SaveAsync(angazovan);
                        await session.FlushAsync();

                        MessageBox.Show($"""
                          Radnik:
                          {predmet.NazivPredmeta}
                          se predaje od strane
                          {nastavnoOsobljeSaDelomCasova.Ime} {nastavnoOsobljeSaDelomCasova.Prezime}
                          od: {angazovan.DatumAngazovanja}
                          """);
                    }
                    else
                    {
                        MessageBox.Show("Veza između nastavnika i predmeta već postoji u bazi.");
                    }
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


        /*
        private async void AbtnAngazovanSaDelomCasova_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            //radila je metoda i kako sad ne radi??
            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    NastavnoOsobljeSaDelomCasova nastavnoOsobljeSaDelomCasova = await session.LoadAsync<NastavnoOsobljeSaDelomCasova>("4567890123456");
                    Predmet predmet = await session.LoadAsync<Predmet>("Matematika");

                    AngazovanSaDelomNorme angazovan = new()
                    {
                        Id = new AngazovanSaDelomNormeId()
                        {
                            PredmetNaKomeAngazovanNastavnikSaDelomCasova = predmet,
                            NastavnikSaDelomCasovaAngazovan = nastavnoOsobljeSaDelomCasova
                        },
                        DatumAngazovanja = new DateTime(2011, 10, 12)
                    };

                    // radiU.Id.RadnikRadiU = radnik;
                    // radiU.Id.ProdavnicaRadiU = prodavnica;

                    await session.SaveAsync(angazovan);
                    await session.FlushAsync();

                    MessageBox.Show($"""
                                 Radnik:
                                 {predmet.ToString()}
                                 se predaje od strane
                                 {nastavnoOsobljeSaDelomCasova.ToString()}
                                 od: {angazovan.DatumAngazovanja}
                                 
                                 """);
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
        } */

        private async void btnDodavanjeRazreda_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Razred r = new()
                    {
                        RedniBrojRazreda = 77
                    };

                    //await session?.SaveAsync(p);
                    await session.SaveOrUpdateAsync(r);
                    await session.FlushAsync();

                    MessageBox.Show($"Dodat je razred sa rednim brojem {r.RedniBrojRazreda}");


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

        private async void btnUcitavanjeRazrednogVeca_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    RoditeljskoVece? rv = await session.LoadAsync<RoditeljskoVece>("2345678901234");
                    MessageBox.Show($"Roditlejsko vece sa JMBG:  \"{rv.JMBG}\" je pronađeno");
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

        private async void btnDodavanjeRazrednogVeca_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    RoditeljskoVece rv = new()
                    {
                        JMBG = "1209348576381",
                        ImeRoditelja = "Vladimir",
                        PrezimeRoditelja = "Vladimirovic",
                        Telefon = "0647722123"
                    };

                    //await session?.SaveAsync(p);
                    await session.SaveOrUpdateAsync(rv);
                    await session.FlushAsync();

                    MessageBox.Show($"Dodato je roditeljsko vece sa roditeljem koji se zove: {rv.ImeRoditelja} {rv.PrezimeRoditelja}");
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

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnZaposleniForm_Click(object sender, EventArgs e)
        {
             ZaposleniForma zaposleniForma = new ZaposleniForma();
            zaposleniForma.ShowDialog();
        }

        private void btnSmerForma_Click(object sender, EventArgs e)
        {
            SmerForma smer = new SmerForma();
            smer.ShowDialog();
        }

        private void btnUceniciForma_Click(object sender, EventArgs e)
        {
            UceniciForma uceniciForma = new UceniciForma();
            uceniciForma.ShowDialog();
        }
    }
}

    
    
