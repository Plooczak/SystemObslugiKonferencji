using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    class Organizator : Uzytkownik
    {

        private string imie;
        private string nazwisko;
        private string plec;
        private DateTime dataUrodzenia;
        private string nrTelefonu;
        private string email;


        public Organizator()
        {

        }

        public Organizator(string imie, string nazwisko, string plec, string data_Urodzenia, string nrTelefonu, string email, string stopienNaukowy, string opis) : base(login, haslo)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            DateTime.TryParseExact(data_Urodzenia, new[] { "dd-MM-yyyy" }, null, DateTimeStyles.None, out dataUrodzenia);
            this.nrTelefonu = nrTelefonu;
            this.email = email;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
