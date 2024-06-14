namespace ORM_migration_test.Repozitoriji
{
    using Dapper;
    using StudentskaMenza.Entiteti;
    using SudentskaMenza.Repozitoriji;
    using SudentskaMenzaUWP.Common;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    internal class MeniRepozitorij : IRepozitorij<Meni>
    {
        private readonly IAppSettings appSettings;
        public Meni dohvatiJedan()
        {
            throw new NotImplementedException();
        }

        public MeniRepozitorij(IAppSettings settings)
        {
            this.appSettings = settings;
        }

        public List<Meni> dohvatiSve()
        {
            using var connection = new SqlConnection(this.appSettings.ConnectionString);

            var sql = @"SELECT m.id, m.naziv, j.naziv, j.tip
                FROM MENI m
                INNER JOIN MENI_JELO mj ON mj.meni_id = m.Id
                INNER JOIN JELO j ON j.id = mj.jelo_id";


            var meniji = connection.Query<Meni, Jelo, Meni>(sql, (meni, jelo) =>
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
            using var connection = new SqlConnection(this.appSettings.ConnectionString);

            const string sql = @"INSERT	INTO MENI(
                naziv
		    )
            VALUES(
                @Naziv
		    );";
            var count = connection.Execute(sql, t);
            if (count != 1)
            {
                throw new Exception("Spremanje neuspjesno");
            }
        }
    }
}
