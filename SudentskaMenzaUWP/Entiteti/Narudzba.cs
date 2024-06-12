using System;
using System.ComponentModel.DataAnnotations;

namespace StudentskaMenza.Entiteti
{
    public class Narudzba
    {
        public long Id { get; set; }

        public long MeniId { get; set; }

        public long StudentId { get; set; }

        public DateTime VrijemeIzdavanja { get; set; }

        public int OcjenaOkus { get; set; }

        public int OcjenaKolicina { get; set; }

        public string Komentar { get; set; }

        public StatusNarudzbe Status { get; set; }
        [Required]
        public TipNarudzbe Tip { get; set; }


        public enum StatusNarudzbe
        {
            ZADANO, U_OBRADI, SPREMNO, POSLUZENO
        }

        public enum TipNarudzbe
        {
            APLIKACIJA, UZIVO
        }
    }
}
