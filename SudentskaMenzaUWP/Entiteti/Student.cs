namespace StudentskaMenza.Entiteti

{
    public class Student
    {
        public long Id { get; set; }

        public string PunoIme { get; set; }

        public int Bodovi { get; set; }
        
        public string Xica { get; set; }

        public string LozinkaHash { get; set; }

        public override string ToString()
        {
            return $"ime: {PunoIme}\nxica: {Xica}\nbodovi: {Bodovi}";
        }
    }
}
