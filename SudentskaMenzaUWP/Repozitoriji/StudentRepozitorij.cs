namespace StudentskaMenza.Repozitoriji
{
    using Dapper;
    using StudentskaMenza.Entiteti;
    using SudentskaMenza.Repozitoriji;
    using SudentskaMenzaUWP.Common;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    public class StudentRepozitorij : IRepozitorij<Student>
    {
        private readonly IAppSettings appSettings;

        public StudentRepozitorij(IAppSettings appSettings)
        {
            this.appSettings = appSettings;
        }

        public Student dohvatiJedan()
        {
            var studenti = new List<Student>();
            return studenti.FirstOrDefault();
        }

        public List<Student> dohvatiSve()
        {
            using var connection = new SqlConnection(this.appSettings.ConnectionString);

            return connection.Query<Student>("SELECT s.id, s.puno_ime PunoIme, s.xica, s.bodovi, s.lozinka_hash LozinkaHash FROM STUDENT s").AsList();
        }

        public void spremi(Student t)
        {
            using var connection = new SqlConnection(this.appSettings.ConnectionString);

            const string sql = @"INSERT	INTO STUDENT(
            puno_ime,
		    xica,
		    bodovi,
		    lozinka_hash
		    )
            VALUES(
                @PunoIme,
		        @Xica,
		        @Bodovi, 
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
