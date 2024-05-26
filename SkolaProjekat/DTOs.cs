using ProjekatSkola.Entiteti;
using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SkolaProjekat
{
    #region Ucenik
    public class UcenikBasic
    {
        public string JedinstveniUpisniBroj { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? AdresaStanovanja { get; set; }
        public DateTime DatumUpisa { get; set; }
        public RazredBasic PohadjaRazred { get; set; }
        public SmerBasic JeUpisan { get; set; }

        public  IList<OcenaBasic> Ocene { get; set; }
        public  IList<PredmetBasic> Predmeti { get; set; }      
        public  IList<RoditeljskoVeceBasic> SuRoditelji { get; set; }
    
        public UcenikBasic()
        {
            Ocene = new List<OcenaBasic>();
            Predmeti = new List<PredmetBasic>();
            SuRoditelji = new List<RoditeljskoVeceBasic>();
        }

        public UcenikBasic(string jbu, string ime,string prezime, string adresa,DateTime datumUpisa, RazredBasic razred,SmerBasic smer)
        {
            JedinstveniUpisniBroj = jbu;
            Ime = ime;
            Prezime = prezime;
            AdresaStanovanja = adresa;
            DatumUpisa = datumUpisa;
            PohadjaRazred = razred;
            JeUpisan = smer;

            Ocene = new List<OcenaBasic>();
            Predmeti = new List<PredmetBasic>();
            SuRoditelji = new List<RoditeljskoVeceBasic>();   
        }
    }
    public class UcenikPregled
    {
        public string JedinstveniUpisniBroj { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? AdresaStanovanja { get; set; }
        public DateTime DatumUpisa { get; set; }
        public Razred PohadjaRazred { get; set; }
        public Smer JeUpisan { get; set; }

        public UcenikPregled() 
        { }

        public UcenikPregled(string jbu, string ime, string prezime, string adresa, DateTime datumUpisa, Razred razred, Smer smer)
        {
            JedinstveniUpisniBroj = jbu;
            Ime = ime;
            Prezime = prezime;
            AdresaStanovanja = adresa;
            DatumUpisa = datumUpisa;
            PohadjaRazred = razred;
            JeUpisan = smer;
        }
    }
    #endregion

    #region Smer
    public class SmerBasic 
    {
        public  int Id { get; protected set; }
        public   string NazivSmera { get; set; }
        public  string MaksimalanBrojUcenika { get; set; }
        public  IList<UcenikBasic> Ucenici { get; set; } = [];//new List<Ucenik>(); //[];
        public  IList<PredmetBasic> Predmeti { get; set; }//Posledica veze Ima N-M

        public SmerBasic()
        {
            Ucenici = new List<UcenikBasic>();
            Predmeti = new List<PredmetBasic>();
        }
        public SmerBasic(int id, string nazivSmera, string maxBrUcenika)
        {
            Id = id;
            NazivSmera = nazivSmera;
            MaksimalanBrojUcenika = maxBrUcenika;

            Ucenici = new List<UcenikBasic>();
            Predmeti = new List<PredmetBasic>();
        }
    }
    public class SmerPregled
    {
        public  int Id { get; protected set; }
        public   string NazivSmera { get; set; }
        public  string MaksimalanBrojUcenika { get; set; }

        public SmerPregled()
        {

        }

        public SmerPregled(string nazivSmera, string maxBrUcenika)
        {           
            NazivSmera = nazivSmera;
            MaksimalanBrojUcenika = maxBrUcenika;
        }
    }
    #endregion

    #region RoditeljskoVece
    public class RoditeljskoVeceBasic
    {
        public  string JMBG { get; set; }
        public  string ImeRoditelja { get; set; }
        public  string PrezimeRoditelja { get; set; }
        public  string Telefon { get; set; }
        public IList<UcenikBasic> SuUcenici { get; set; }

        public RoditeljskoVeceBasic() 
        {
            SuUcenici = new List<UcenikBasic>();
        }
        public RoditeljskoVeceBasic(string jmbg, string imeR, string prezime, string tel) 
        {
            JMBG = jmbg;
            ImeRoditelja = imeR;
            PrezimeRoditelja = prezime;
            Telefon = tel;

            SuUcenici = new List<UcenikBasic>();   
        }
    }
    public class RoditeljskoVecePregled
    {
        public  string JMBG { get; set; }
        public  string ImeRoditelja { get; set; }
        public  string PrezimeRoditelja { get; set; }
        public  string Telefon { get; set; }

        public RoditeljskoVecePregled() { }

        public RoditeljskoVecePregled(string jmbg, string imeR, string prezime, string tel)
        {
            JMBG = jmbg;
            ImeRoditelja = imeR;
            PrezimeRoditelja = prezime;
            Telefon = tel;
        }
    }


    #endregion

    #region Razred
    public class RazredBasic
    {
        public int RedniBrojRazreda { get; set; }
        public IList<UcenikBasic> Ucenici { get; set; }
        public IList<PredmetBasic> Na { get; set; }
        public RazredBasic() 
        { 
            Ucenici = new List<UcenikBasic>();
            Na = new List<PredmetBasic>();
        }
        public RazredBasic(int rbr)
        {
            RedniBrojRazreda = rbr;
            Ucenici = new List<UcenikBasic>();
            Na = new List<PredmetBasic>();
        }
    }
    public class RazredPregled
    {
        public int RedniBrojRazreda { get; set; }
        public RazredPregled()
        { }
        public RazredPregled(int rbr)
        {
            RedniBrojRazreda = rbr;
        }
    }
    #endregion

    #region Predmet
    public class PredmetBasic
    {
        public  string NazivPredmeta { get; set; }
        public  string TipPredmeta { get; set; }
        public  string NazivSmera { get; set; }

        public  IList<AngazovanSaDelomNormeBasic> PredmeteKojePredajeNastavnikSaDelomCasova { get; set; }
        public  IList<AngazovanSaPunomNormomBasic> PredmeteKojePredajeNastavnikSaPunomNormomCasova { get; set; }
        public  IList<SmerBasic> Smerovi { get; set; } //Posledica veze Ima N-M 
        public  IList<OcenaBasic> Ocene { get; set; } //[];
        public  IList<RazredBasic> Na { get; set; }
        public PredmetBasic()
        {
            PredmeteKojePredajeNastavnikSaDelomCasova = new List<AngazovanSaDelomNormeBasic>();
            PredmeteKojePredajeNastavnikSaPunomNormomCasova = new List<AngazovanSaPunomNormomBasic>();
            Smerovi = new List<SmerBasic>();
            Ocene = new List<OcenaBasic>();
            Na = new List<RazredBasic>();
        }
        public PredmetBasic(string nazivPredmeta, string tip, string nazivSmera)
        {
            PredmeteKojePredajeNastavnikSaDelomCasova = new List<AngazovanSaDelomNormeBasic>();
            PredmeteKojePredajeNastavnikSaPunomNormomCasova = new List<AngazovanSaPunomNormomBasic>();
            Smerovi = new List<SmerBasic>();
            Ocene = new List<OcenaBasic>();
            Na = new List<RazredBasic>();

            NazivPredmeta = nazivPredmeta;
            TipPredmeta = tip;
            NazivSmera = nazivSmera;
        }
    }

    public class OpsteobrazovniPredmetBasic : PredmetBasic
    {
        public OpsteobrazovniPredmetBasic()
        { }

        public OpsteobrazovniPredmetBasic(string nazivPredmeta, string tip, int JBU, string nazivSmera, UcenikBasic ucenik) : base(nazivPredmeta, tip,nazivSmera)
        {

        }
    }

    public class StrucniPredmetBasic: PredmetBasic
    {
        public StrucniPredmetBasic()
        { }

        public StrucniPredmetBasic(string nazivPredmeta, string tip, int JBU, string nazivSmera, UcenikBasic ucenik) : base(nazivPredmeta, tip, nazivSmera)
        {

        }
    }

    public class PredmetPregled
    {
        public  string NazivPredmeta { get; set; }
        public  string TipPredmeta { get; set; }
        public  string NazivSmera { get; set; }      
        public PredmetPregled()
        {
           
        }
        public PredmetPregled(string nazivPredmeta, string tip, string nazivSmera)
        {
            NazivPredmeta = nazivPredmeta;
            TipPredmeta = tip;
            NazivSmera = nazivSmera;
        }      
    }

    public class OpsteobrazovniPredmetPregled : PredmetPregled
    {
        public OpsteobrazovniPredmetPregled()
        { }

        public OpsteobrazovniPredmetPregled(string nazivPredmeta, string tip, string nazivSmera) : base(nazivPredmeta, tip, nazivSmera)
        {

        }
    }

    public class StrucniPredmetPregled : PredmetPregled
    {
        public StrucniPredmetPregled()
        { }

        public StrucniPredmetPregled(string nazivPredmeta, string tip, string nazivSmera) : base(nazivPredmeta, tip, nazivSmera)
        {

        }
    }
    #endregion

    #region Ocena
    public class OcenaBasic
    {
        public int Id { get; set; }
        public  string NazivPredmeta { get; set; }
        public  string JedinstveniBrojUcenika { get; set; }
        public  DateTime DatumDobijanjaOcene { get; set; }
        public  int NumerickaVrednost { get; set; }
        public  string TekstualniOpis { get; set; }

        public   UcenikBasic JeDobio { get; set; }
        public   PredmetBasic JeIz { get; set; }
      
        public OcenaBasic() { }
        public OcenaBasic(string nazivPredmeta, string JBU, DateTime datumDobijanjaOcene, int numerickaVrednost, string tekstualniOpis) 
        {
            NazivPredmeta = nazivPredmeta;
            JedinstveniBrojUcenika = JBU;
            DatumDobijanjaOcene = datumDobijanjaOcene;
            NumerickaVrednost = numerickaVrednost;
            TekstualniOpis = tekstualniOpis;
        }
    }
    public class OcenaPregled
    {
        public int Id { get; set; }
        public string NazivPredmeta { get; set; }
        public string JedinstveniBrojUcenika { get; set; }
        public DateTime DatumDobijanjaOcene { get; set; }
        public int NumerickaVrednost { get; set; }
        public string TekstualniOpis { get; set; }
        public OcenaPregled() { }
        public OcenaPregled(string nazivPredmeta, string JBU, DateTime datumDobijanjaOcene, int numerickaVrednost, string tekstualniOpis)
        {
            NazivPredmeta = nazivPredmeta;
            JedinstveniBrojUcenika = JBU;
            DatumDobijanjaOcene = datumDobijanjaOcene;
            NumerickaVrednost = numerickaVrednost;
            TekstualniOpis = tekstualniOpis;
        }
    }

    #endregion

    #region Osoblje
    public class OsobljeBasic
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImeRoditelja { get; set; }
        public string AdresaStanovanja { get; set; }

        public OsobljeBasic(string jmbg, string ime, string prezime, string imeRoditelja, string adresa)
        {
            JMBG = jmbg;
            Ime = ime;
            Prezime = prezime;
            ImeRoditelja = imeRoditelja;
            AdresaStanovanja = adresa;

        }
        public OsobljeBasic() { }
        public override string ToString()
        {
            return Ime + " " + ImeRoditelja + " " + Prezime;
        }
    }

    public class NastavnoOsobljeSaDelomNormeBasic : OsobljeBasic
    {
        public int BrojCasovaNedeljno { get; set; }
        public string? NazivOstalihSkola { get; set; }
        public IList<AngazovanSaDelomNormeBasic> PredmeteKojePredaje { get; set; }

        public NastavnoOsobljeSaDelomNormeBasic()
        {
            PredmeteKojePredaje = new List<AngazovanSaDelomNormeBasic>();
        }
        public NastavnoOsobljeSaDelomNormeBasic(string jmbg, string ime, string prezime, string imeRoditelja, string adresa, int brojCasovaNedeljno, string nazivOstalihSkola) : base(jmbg, ime, prezime, imeRoditelja, adresa)
        {
            this.BrojCasovaNedeljno = brojCasovaNedeljno;
            this.NazivOstalihSkola = nazivOstalihSkola;
            PredmeteKojePredaje = new List<AngazovanSaDelomNormeBasic>();
        }
    }

    public class NastavnoOsobljeSaPunomNormomBasic : OsobljeBasic
    {
        public int BrojCasova { get; set; }
        public IList<AngazovanSaPunomNormomBasic> PredmeteKojePredaje { get; set; }

        public NastavnoOsobljeSaPunomNormomBasic()
        {
            PredmeteKojePredaje = new List<AngazovanSaPunomNormomBasic>();
        }
        public NastavnoOsobljeSaPunomNormomBasic(string jmbg, string ime, string prezime, string imeRoditelja, string adresa, int brojCasova) : base(jmbg, ime, prezime, imeRoditelja, adresa)
        {
            this.BrojCasova = brojCasova;
            PredmeteKojePredaje = new List<AngazovanSaPunomNormomBasic>();
        }
    }

    public class NenastavnoOsobljeBasic : OsobljeBasic
    {
        public string ImeSektora { get; set; }
        public string StrucnaSprema { get; set; }

        public NenastavnoOsobljeBasic()
        {

        }
        public NenastavnoOsobljeBasic(string jmbg, string ime, string prezime, string imeRoditelja, string adresa,string imeSektora, string strucnaSprema): base(jmbg, ime, prezime, imeRoditelja, adresa)
        {
            this.ImeSektora = imeSektora;
            this.StrucnaSprema = strucnaSprema;
        }
    }


    //------------------------------PREGLED-----------------------------------------//
    public class OsobljePregled
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImeRoditelja { get; set; }
        public string AdresaStanovanja { get; set; }

        public OsobljePregled(string jmbg, string ime, string prezime, string imeRoditelja, string adresa)
        {
            JMBG = jmbg;
            Ime = ime;
            Prezime = prezime;
            ImeRoditelja = imeRoditelja;
            AdresaStanovanja = adresa;

        }
        public OsobljePregled() { }
    }

    public class NastavnoOsobljeSaDelomNormePregled : OsobljePregled
    {
        public int BrojCasovaNedeljno { get; set; }
        public string? NazivOstalihSkola { get; set; }     

        public NastavnoOsobljeSaDelomNormePregled()
        { }

        public NastavnoOsobljeSaDelomNormePregled(string jmbg, string ime, string prezime, string imeRoditelja, string adresa, int brojCasovaNedeljno, string nazivOstalihSkola) : base(jmbg, ime, prezime, imeRoditelja, adresa)
        {
            this.BrojCasovaNedeljno = brojCasovaNedeljno;
            this.NazivOstalihSkola = nazivOstalihSkola;          
        }
    }

    public class NastavnoOsobljeSaPunomNormomPregled:OsobljePregled
    {

        public int BrojCasova { get; set; }

        public NastavnoOsobljeSaPunomNormomPregled()
        { }

        public NastavnoOsobljeSaPunomNormomPregled(string jmbg, string ime, string prezime, string imeRoditelja, string adresa, int brojCasova): base(jmbg, ime, prezime, imeRoditelja, adresa)
        {
            this.BrojCasova = brojCasova;
        }            
    }

    public class NenastavnoOsobljePregled : OsobljeBasic
    {
        public string ImeSektora { get; set; }
        public string StrucnaSprema { get; set; }

        public NenastavnoOsobljePregled()
        { }

        public NenastavnoOsobljePregled(string jmbg, string ime, string prezime, string imeRoditelja, string adresa, string imeSektora, string strucnaSprema) : base(jmbg, ime, prezime, imeRoditelja, adresa)
        {
            this.ImeSektora = imeSektora;
            this.StrucnaSprema = strucnaSprema;
        }
    }
    #endregion

    #region AngazovanSaPunomNormom
    public class AngazovanSaPunomNormomBasic
    {
        public AngazovanSaPunomNormomIdBasic Id { get; set; }
        public DateTime DatumAngazovanja { get; set; }

        public AngazovanSaPunomNormomBasic()
        { }
        public AngazovanSaPunomNormomBasic(AngazovanSaPunomNormomIdBasic id, DateTime datumAngazovanja)
        {
            Id = id;
            DatumAngazovanja = datumAngazovanja;
        }
    }

    public class AngazovanSaPunomNormomPregled
    {
        public AngazovanSaPunomNormomId Id { get; set; }
        public DateTime DatumAngazovanja { get; set; }

        public AngazovanSaPunomNormomPregled()
        { }
        public AngazovanSaPunomNormomPregled(AngazovanSaPunomNormomId id, DateTime datumAngazovanja)
        {
            Id = id;
            DatumAngazovanja = datumAngazovanja;
        }
    }
    #endregion

    #region AngazovanSaPunomNormomId
    public class AngazovanSaPunomNormomIdBasic
    {
        public NastavnoOsobljeSaPunomNormomBasic NastavnikSaPunomNormomAngazovan { get; set; }
        public Predmet PredmetNaKomeAngazovanNastavnikSaPunomNormom { get; set; }
        public AngazovanSaPunomNormomIdBasic() { }
        public AngazovanSaPunomNormomIdBasic(NastavnoOsobljeSaPunomNormomBasic nastavnikSaPunomNormomAngazovan, Predmet predmetNaKomeAngazovanNastavnikSaPunomNormom)
        {
            this.NastavnikSaPunomNormomAngazovan = nastavnikSaPunomNormomAngazovan;
            this.PredmetNaKomeAngazovanNastavnikSaPunomNormom = predmetNaKomeAngazovanNastavnikSaPunomNormom;
        }
    }
    #endregion

    #region AngazovanSaDelomNorme
    public class AngazovanSaDelomNormeBasic
    {
        public AngazovanSaDelomNormeIdBasic Id { get; set; }
        public DateTime? DatumAngazovanja { get; set; }
        public AngazovanSaDelomNormeBasic()
        { }
        public AngazovanSaDelomNormeBasic(AngazovanSaDelomNormeIdBasic id, DateTime datumAngazovanja)
        {
            this.Id = id;
            this.DatumAngazovanja = datumAngazovanja;
        }
    }

    public class AngazovanSaDelomNormePregled
    {
        public AngazovanSaDelomNormeId Id { get; set; }
        public DateTime? DatumAngazovanja { get; set; }
        public AngazovanSaDelomNormePregled()
        { }
        public AngazovanSaDelomNormePregled(AngazovanSaDelomNormeId id, DateTime datumAngazovanja)
        {
            this.Id = id;
            this.DatumAngazovanja = datumAngazovanja;
        }
    }

    #endregion

    #region AngazovanSaDelomNormeId
    public class AngazovanSaDelomNormeIdBasic
    {
        public NastavnoOsobljeSaDelomNormeBasic NastavnikSaDelomCasovaAngazovan { get; set; }
        public PredmetBasic PredmetNaKomeAngazovanNastavnikSaDelomCasova { get; set; }
        public AngazovanSaDelomNormeIdBasic()
        {}
        public AngazovanSaDelomNormeIdBasic(NastavnoOsobljeSaDelomNormeBasic nastavnikSaDelomCasovaAngazovan, PredmetBasic predmetNaKomeAngazovanNastavnikSaDelomCasova)
        {
            this.NastavnikSaDelomCasovaAngazovan = nastavnikSaDelomCasovaAngazovan;
            this.PredmetNaKomeAngazovanNastavnikSaDelomCasova = predmetNaKomeAngazovanNastavnikSaDelomCasova;
        }
    }
    #endregion
}