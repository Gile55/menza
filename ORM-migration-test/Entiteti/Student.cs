using System.ComponentModel.DataAnnotations;

namespace StudentskaMenza.Entiteti

{
    public class Student
    {
        public long Id { get; set; }

        public required string PunoIme { get; set; }

        public required int Bodovi { get; set; }
        
        public required string Xica { get; set; }

        public required string LozinkaHash { get; set; }

        public override string ToString()
        {
            return $"ime: {PunoIme}\nxica: {Xica}\nbodovi: {Bodovi}";
        }
    }
}
