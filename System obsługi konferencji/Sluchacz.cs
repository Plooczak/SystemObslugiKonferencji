using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    public class Sluchacz : Uzytkownik, IEquatable<Sluchacz>
    {
        private string imie;
        private string nazwisko;
        private string plec;
        private string dataUrodzenia;
        private string nrTelefonu;
        private string email;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Plec { get => plec; set => plec = value; }
        public string DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public string NrTelefonu { get => nrTelefonu; set => nrTelefonu = value; }
        public string Email { get => email; set => email = value; }

        public Sluchacz()
        {
            imie = null;
            nazwisko = null;
            plec = null;
            dataUrodzenia = null;
            nrTelefonu = null;
            email = null;
        }
        public Sluchacz(string login, string haslo):base(login,haslo)
        {
            imie = null;
            nazwisko = null;
            plec = null;
            dataUrodzenia = null;
            nrTelefonu = null;
            email = null;
        }

        public Sluchacz(string login, string haslo, string imie, string nazwisko, string plec, string dataUrodzenia, string nrTelefonu, string email) : base(login, haslo)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            this.dataUrodzenia = dataUrodzenia;
            this.nrTelefonu = nrTelefonu;
            this.email = email;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //public int CompareTo(object obj)
        //{
        //    if (obj != null)
        //    {
        //        Sluchacz s = obj as Sluchacz;
        //        int pom = this.Login.CompareTo(s.login);

        //        if (pom != 0)
        //        {
        //            return pom;
        //        }

        //        else
        //        {
        //            return this.haslo.CompareTo(s.Haslo);
        //        }
        //    }

        //    else
        //        return 1;
        //}

        public bool Equals(Sluchacz other)
        {
            if (login.Equals(other.Login))
                return (haslo.Equals(other.Haslo));
            else return false;
        }

    }
}
