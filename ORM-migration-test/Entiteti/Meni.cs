namespace StudentskaMenza.Entiteti
{
    public class Meni
    {
        public int? Id { get; set; }

        public required string Naziv { get; set; }

        public IList<Jelo> Jela = new List<Jelo>();
    }
}
