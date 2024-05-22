using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSkola.Entiteti
{
    public class Ocena
    {
        public virtual string NazivPredmeta { get; set; }
        public virtual int JedinstveniBrojUcenika { get; set; }
        public virtual DateTime DatumDobijanjaOcene { get; set; }
        public virtual int NumerickaVrednost { get; set; }
        public virtual string TekstualniOpis { get; set; }
        public Ocena()
        {
        }
        public override bool Equals(object obj)
        {
            var other = obj as Ocena;
            if (other == null) return false;

            return DatumDobijanjaOcene == other.DatumDobijanjaOcene &&
                   NazivPredmeta == other.NazivPredmeta;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + DatumDobijanjaOcene.GetHashCode();
                hash = hash * 23 + (NazivPredmeta != null ? NazivPredmeta.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
