using System.Collections.Generic;

namespace SudentskaMenzaUWP.ViewModel
{
    internal class AbstraktniKorisnickiViewModel
    {
        public TipKorisnika OdabraniTipKorisnika { get; set; }

        private string _identifikacijskoPolje = "Identifikacija";

        public string IdentifikacijskoPolje { get { return _identifikacijskoPolje; } }

        public List<TipKorisnika> _tipoviKorisnika = new List<TipKorisnika>() {
            new TipKorisnika {
                Naziv = "Student",
                Oznaka = "STUDENT"
            },
            new TipKorisnika {
                Naziv = "Voditelj menze",
                Oznaka = "VODITELJ_MENZE"
            }
        };

        public List<TipKorisnika> TipoviKorisnika { get { return _tipoviKorisnika;  } }

        public void OdabirTipaKorisnikaPromjenjen(TipKorisnika tipKorisnika)
        {
            this.OdabraniTipKorisnika = tipKorisnika;
            switch (OdabraniTipKorisnika.Oznaka)
            {
                case "VODITELJ_MENZE":
                    _identifikacijskoPolje = "Korisničko ime:";
                    break;
                case "STUDENT":
                    _identifikacijskoPolje = "Broj X-ice:";
                    break;
            }
        }
    }
}
