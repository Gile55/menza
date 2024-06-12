// See https://aka.ms/new-console-template for more information

using EvolveDb;
using Microsoft.Data.SqlClient;
using ORM_migration_test.Repozitoriji;
using Serilog;
using StudentskaMenza.Entiteti;

Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
var databaseName = "menza_1";
var connectionString = $"Server=localhost\\SQLEXPRESS;Database={databaseName};Trusted_Connection=True;Trust Server Certificate=True";

using (var connection = new SqlConnection(connectionString))
{
    try
    {
        var evolve = new Evolve(connection, Log.Information)
        {
            Locations = new List<String>() {
                "db/migrations"
            },
            IsEraseDisabled = true,
        };
        evolve.Migrate();
        /*
        var student = new Student
        {
            PunoIme = "test student",
            Xica = "1234567890",
            LozinkaHash = BCrypt.Net.BCrypt.HashPassword("test-pass"),
            Bodovi = 0,
        };
        */
        var studentRepozitorij = new StudentRepozitorij(connection);

        // studentRepozitorij.spremi(student);

        foreach (Student s in studentRepozitorij.dohvatiSve())
        {
            Log.Information(s.ToString());
        }
    }
    catch (Exception ex)
    {
        Log.Error("Database migration failed.", ex);
        throw;
    }
}