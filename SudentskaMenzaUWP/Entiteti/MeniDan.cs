namespace StudentskaMenza.Entiteti
{
    public class MeniDan
    {
        public long MeniId { get; set; }

        public virtual Dan Dan { get; set; }
    }

    public enum Dan
    {
        PONEDJELJAK, UTORAK, SRIJEDA, CETVRTAK, PETAK, SUBOTA, NEDJELJA
    }
}
