namespace StudentskaMenza.Entiteti
{
    public class Jelo
    {
        public int? Id { get; set; }

        public string Naziv { get; set; }

        public decimal Cijena { get; set; }

        public TipJela Tip { get; set; }


        public enum TipJela
        {
            JUHA, GLAVNO_JELO, PRILOG, DESERT
        }
    }
}
