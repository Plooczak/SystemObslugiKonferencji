using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgramoProjekt
{
    public abstract class Osoba
    {

        private string imie;
        private string nazwisko;
        private string plec;
        private DateTime dataUrodzenia;
        private string nrTelefonu;
        private string email;

        public string Imie
        {
            get => imie;
            set => imie = value;
        }

        public string Nazwisko
        {
            get => nazwisko;
            set => nazwisko = value;
        }

        public string Plec
        {
            get => plec;
            set => plec = value;
        }

        public DateTime DataUrodzenia
        {
            get => dataUrodzenia;
            set => dataUrodzenia = value;
        }
        public string NrTelefonu
        {
            get => nrTelefonu;
            set => nrTelefonu = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public Osoba()
        {
            imie = null;
            nazwisko = null;
            plec = null;
            dataUrodzenia = DateTime.MinValue;
            nrTelefonu = null;
            email = null;
        }

        public Osoba(string imie, string nazwisko, string plec, string data_Urodzenia, string nrTelefonu, string email) : this()
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            this.nrTelefonu = nrTelefonu;
            this.email = email;
            DateTime.TryParseExact(data_Urodzenia, new[] { "dd-MM-yyyy" }, null, DateTimeStyles.None, out dataUrodzenia);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
