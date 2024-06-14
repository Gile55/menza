namespace SudentskaMenzaUWP.Repozitoriji
{
    using Dapper;
    using System.Data.SqlClient;
    using StudentskaMenza.Entiteti;
    using SudentskaMenza.Repozitoriji;
    using System;
    using System.Collections.Generic;
    using SudentskaMenzaUWP.Common;


    internal class VoditeljMenzeRepozitorij : IRepozitorij<VoditeljMenze>
    {
        private readonly IAppSettings appSettings;

        public VoditeljMenzeRepozitorij(IAppSettings appSettings)
        {
            this.appSettings = appSettings;
        }

        public VoditeljMenze dohvatiJedan()
        {
            throw new NotImplementedException();
        }

        public List<VoditeljMenze> dohvatiSve()
        {
            throw new NotImplementedException();
        }

        public void spremi(VoditeljMenze t)
        {
            using var connection = new SqlConnection(this.appSettings.ConnectionString);

            const string sql = @"INSERT	INTO STUDENT(
            puno_ime,
		    korisnicko_ime,
		    lozinka_hash
		    )
            VALUES(
                @PunoIme,
		        @KorisnickoIme,
		        @LozinkaHash
		    );";


            var count = connection.Execute(sql, t);
            if (count != 1)
            {
                throw new Exception("Spremanje neuspjesno");
            }
        }
    }
}
