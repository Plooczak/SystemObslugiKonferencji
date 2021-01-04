using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgramoProjekt
{
    public class Uzytkownik: Osoba
    {
        private string login;
        private string haslo;

        public string Login
        {
            get => login;
            set => login = value;
        }

        public string Haslo
        {
            get => haslo;
            set => haslo = value;
        }

        public Uzytkownik()
        {
            login = null;
            haslo = null;
        }

        public Uzytkownik(string imie, string nazwisko, string plec, string data_Urodzenia, string nrTelefonu, string email, string login, string haslo) : base(imie, nazwisko, plec, data_Urodzenia, nrTelefonu, email)
        {
            this.login = login;
            this.haslo = haslo;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
