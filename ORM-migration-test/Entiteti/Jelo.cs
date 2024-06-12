using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentskaMenza.Entiteti
{
    public class Jelo
    {
        public int? Id { get; set; }

        public required string Naziv { get; set; }

        public required decimal Cijena { get; set; }

        public required TipJela Tip { get; set; }


        public enum TipJela
        {
            JUHA, GLAVNO_JELO, PRILOG, DESERT
        }
    }
}
