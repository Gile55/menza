namespace ORM_migration_test.Entiteti
{
    internal class VoditeljMenze
    {
        public long Id { get; set; }
        
        public required string PunoIme { get; set; }

        public required string KorisnickoIme { get; set; }

        public required string LozinkaHash { get; set; }
    }
}
