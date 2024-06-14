namespace SudentskaMenzaUWP.Common
{
    public interface IAppSettings
    {
        string ConnectionString { get; }
    }

    public class AppSettings : IAppSettings
    {

        public string ConnectionString { get; } = "Server=localhost; Database=Menza;User Id=SA;Password=yourStrong(!)Password;TrustServerCertificate=Yes;";
    }
}
