using System.Collections.Generic;

namespace StudentskaMenza.Entiteti
{
    public class Meni
    {
        public int? Id { get; set; }

        public string Naziv { get; set; }

        public IList<Jelo> Jela = new List<Jelo>();
    }
}
