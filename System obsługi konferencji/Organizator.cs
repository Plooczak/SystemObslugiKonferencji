using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    public class Organizator : Uzytkownik, IComparable, IEquatable<Organizator>
    {
        private string imie;
        private string nazwisko;
        private string plec;
        private DateTime dataUrodzenia;
        private string nrTelefonu;
        private string email;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Plec { get => plec; set => plec = value; }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public string NrTelefonu { get => nrTelefonu; set => nrTelefonu = value; }
        public string Email { get => email; set => email = value; }


        public Organizator()
        {
            imie = null;
            nazwisko = null;
            plec = null;
            dataUrodzenia = DateTime.MinValue;
            nrTelefonu = null;
            email = null;
        }

        public Organizator(string login, string haslo, string imie, string nazwisko, string plec, string data_Urodzenia, string nrTelefonu, string email, string stopienNaukowy, string opis) : base(login, haslo)
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

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                Organizator o = (Organizator)obj;
                int pom = this.Login.CompareTo(o.Login);

                if (pom != 0)
                {
                    return pom;
                }

                else
                {
                    return this.Haslo.CompareTo(o.Haslo);
                }
            }

            else
                return 1;
        }

        public bool Equals(Organizator other)
        {
            return (login.Equals(other.Login));
        }

    }
}
