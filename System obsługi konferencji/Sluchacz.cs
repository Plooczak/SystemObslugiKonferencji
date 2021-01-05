using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    class Sluchacz : Uzytkownik, IComparable, IEquatable<Sluchacz>
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


        public Sluchacz()
        {
            imie = null;
            nazwisko = null;
            plec = null;
            dataUrodzenia = DateTime.MinValue;
            nrTelefonu = null;
            email = null;
        }

        public Sluchacz(string login, string haslo, string imie, string nazwisko, string plec, string data_Urodzenia, string nrTelefonu, string email) : base(login, haslo)
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
                Sluchacz s = (Sluchacz)obj;
                int pom = this.Login.CompareTo(s.login);

                if (pom != 0)
                {
                    return pom;
                }

                else
                {
                    return this.haslo.CompareTo(s.Haslo);
                }
            }

            else
                return 1;
        }

        public bool Equals(Sluchacz other)
        {
            return (login.Equals(other.Login));
        }

    }
}
