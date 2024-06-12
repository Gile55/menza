using Serilog;
using SudentskaMenzaUWP.Servisi;

namespace SudentskaMenzaUWP.ViewModel
{
    internal class PrijavaViewModel : AbstraktniKorisnickiViewModel
    {
        private KorisnickiServis _korisnickiServis;

        public PrijavaViewModel(KorisnickiServis korisnickiServis)
        {
            _korisnickiServis = korisnickiServis;
        }

        internal void Prijava(string oznaka, string identifikacija, string lozinka)
        {
            switch (oznaka)
            {
                case "VODITELJ_MENZE":
                    Log.Information("prijava - voditelj menze");
                    if (_korisnickiServis.prijavaVoditeljMenze(identifikacija, lozinka))
                    {

                    }
                    break;
                case "STUDENT":
                    Log.Information("prijava - student");
                    if (_korisnickiServis.prijavaStudent(identifikacija, lozinka))
                    {

                    }
                    break;
            }
        }
    }
}
