using StudentskaMenza.Repozitoriji;
using System;
using StudentskaMenza.Entiteti;
using SudentskaMenzaUWP.Repozitoriji;

namespace SudentskaMenzaUWP.Servisi
{
    internal class KorisnickiServis
    {
        private StudentRepozitorij studentRepozitorij;
        private VoditeljMenzeRepozitorij voditeljMenzeRepozitorij;

        public KorisnickiServis(
            StudentRepozitorij studentRepozitorij,
            VoditeljMenzeRepozitorij voditeljMenzeRepozitorij
        )
        {
            this.studentRepozitorij = studentRepozitorij;
            this.voditeljMenzeRepozitorij = voditeljMenzeRepozitorij;
        }

        internal bool prijavaStudent(string identifikacija, string lozinka)
        {
            throw new NotImplementedException();
        }

        internal bool prijavaVoditeljMenze(string identifikacija, string lozinka)
        {
            throw new NotImplementedException();
        }

        internal bool registracijaStudent(string xica, string punoIme, string lozinka)
        {
            var lozinkaHash = BCrypt.Net.BCrypt.HashPassword(lozinka);
            studentRepozitorij.spremi(new Student
            {
                Xica = xica,
                PunoIme = punoIme,
                LozinkaHash = lozinkaHash,
                Bodovi = 0
            });
            return true;
        }
        
        internal bool registracijaVoditeljMenze(string korisnickoIme, string punoIme, string lozinka)
        {
            var lozinkaHash = BCrypt.Net.BCrypt.HashPassword(lozinka);
            voditeljMenzeRepozitorij.spremi(new VoditeljMenze
            {
                KorisnickoIme = korisnickoIme,
                PunoIme = punoIme,
                LozinkaHash = lozinkaHash
            });
            return true;
        }
    }
}
