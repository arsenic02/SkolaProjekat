using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjekatSkola.Entiteti
{
    public class Ucenik
    {
       // public virtual int Id { get; protected set; }
        public virtual required string JedinstveniUpisniBroj { get; set; }
        public virtual string? Ime { get; set; }
        public virtual string? Prezime { get; set; }
        public virtual string? AdresaStanovanja { get; set; }
       // public virtual string? NazivSmera { get; set; } //vrv ne trebas
        public virtual DateTime DatumUpisa { get; set; }
       /* 
        * Izbačeno usled postojanja veze PojadjaRazred koja zamenjuje ovo
        * public virtual int RedniBrojRazreda { get; set; }
        */
        public Ucenik() {
            Ocene = new List<Ocena>();
        }

        public virtual required Smer JeUpisan { get; set; }// ili mozda?
        public virtual IList<Ocena> Ocene { get; set; }
        public virtual IList<Predmet> Predmeti { get; set; }
        public virtual Razred PohadjaRazred { get; set; }

    }
}
