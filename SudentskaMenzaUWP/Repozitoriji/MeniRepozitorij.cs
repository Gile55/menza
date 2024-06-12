using Dapper;
using System.Data.SqlClient;
using StudentskaMenza.Entiteti;
using SudentskaMenza.Repozitoriji;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ORM_migration_test.Repozitoriji
{
    internal class MeniRepozitorij : IRepozitorij<Meni>
    {
        private readonly SqlConnection _dbConnection;

        public Meni dohvatiJedan()
        {
            throw new NotImplementedException();
        }

        public MeniRepozitorij(SqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Meni> dohvatiSve()
        {
            var sql = @"SELECT m.id, m.naziv, j.naziv, j.tip
                FROM MENI m
                INNER JOIN MENI_JELO mj ON mj.meni_id = m.Id
                INNER JOIN JELO j ON j.id = mj.jelo_id";

            var meniji = _dbConnection.Query<Meni, Jelo, Meni>(sql, (meni, jelo) =>
            {
                meni.Jela.Add(jelo);
                return meni;
            }, splitOn: "jelo_id");

            var result = meniji.GroupBy(m => m.Id).Select(g =>
            {
                var grupiraniMeniji = g.First();
                grupiraniMeniji.Jela = g.Select(m => m.Jela.Single()).ToList();
                return grupiraniMeniji;
            });
            return result.AsList();
        }

        public void spremi(Meni t)
        {
            const string sql = @"INSERT	INTO MENI(
                naziv
		    )
            VALUES(
                @Naziv
		    );";
            var count = _dbConnection.Execute(sql, t);
            if (count != 1)
            {
                throw new Exception("Spremanje neuspjesno");
            }
        }
    }
}
