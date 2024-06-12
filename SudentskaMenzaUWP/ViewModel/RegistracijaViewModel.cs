using Serilog;
using SudentskaMenzaUWP.Servisi;
using Windows.UI.Xaml.Controls;

namespace SudentskaMenzaUWP.ViewModel
{
    internal class RegistracijaViewModel : AbstraktniKorisnickiViewModel
    {
        private KorisnickiServis _korisnickiServis;

        public RegistracijaViewModel(KorisnickiServis korisnickiServis)
        {
            _korisnickiServis = korisnickiServis;
        }

        internal void Registracija(string oznaka, string identifikacija, string punoIme, string lozinka)
        {
            switch (oznaka)
            {
                case "VODITELJ_MENZE":
                    Log.Information("registracija - voditelj menze");
                    if (_korisnickiServis.registracijaVoditeljMenze(identifikacija, punoIme, lozinka))
                    {
                        // TODO NAVIGATE
                        // TODO SET USER ICON AND NAME
                    }
                    break;
                case "STUDENT":
                    Log.Information("registracija- student");
                    if (_korisnickiServis.registracijaStudent(identifikacija, punoIme, lozinka))
                    {
                        // TODO NAVIGATE
                        // TODO SET USER ICON AND NAME
                    }
                    break;
            }
        }
    }
}
