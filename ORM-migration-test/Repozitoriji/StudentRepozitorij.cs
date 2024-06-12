using Dapper;
using Microsoft.Data.SqlClient;
using StudentskaMenza.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORM_migration_test.Repozitoriji
{
    public class StudentRepozitorij : IRepozitorij<Student>
    {
        private readonly SqlConnection _dbConnection;

        public StudentRepozitorij(SqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Student? dohvatiJedan()
        {
            var studenti = new List<Student>();
            return studenti.FirstOrDefault();
        }

        public List<Student> dohvatiSve()
        {
            return _dbConnection.Query<Student>("SELECT s.id, s.puno_ime PunoIme, s.xica, s.bodovi, s.lozinka_hash LozinkaHash FROM STUDENT s").AsList();
        }

        public void spremi(Student t)
        {
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
            var count = _dbConnection.Execute(sql, t);
            if (count != 1)
            {
                throw new Exception("Spremanje neuspjesno");
            }
        }
    }
}
