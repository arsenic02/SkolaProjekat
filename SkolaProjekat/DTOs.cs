using ProjekatSkola.Entiteti;
using SkolaProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaProjekat
{
    #region Ucenik
    #endregion

    #region Smer
    #endregion

    #region RoditeljskoVece

    #endregion

    #region Razred
    public class RazredBasic
    {
        public RazredBasic() 
        { }
    }
    public class RazredPregled
    {
        public RazredPregled()
        { }
    }
    #endregion

    #region Predmet
    public class PredmetBasic
    {
        public PredmetBasic() { }
    }
    public class PredmetPregled
    {
        public PredmetPregled() { }
    }
    #endregion

    #region Ocena
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

    #region NastavnoOsobljeSaDelomCasova
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