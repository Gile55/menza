using Dapper;
using System.Data.SqlClient;
using StudentskaMenza.Entiteti;
using SudentskaMenza.Repozitoriji;
using System;
using System.Collections.Generic;


namespace SudentskaMenzaUWP.Repozitoriji
{
    internal class VoditeljMenzeRepozitorij : IRepozitorij<VoditeljMenze>
    {
        private readonly SqlConnection _dbConnection;

        public VoditeljMenzeRepozitorij(SqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
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
            var count = _dbConnection.Execute(sql, t);
            if (count != 1)
            {
                throw new Exception("Spremanje neuspjesno");
            }
        }
    }
}
