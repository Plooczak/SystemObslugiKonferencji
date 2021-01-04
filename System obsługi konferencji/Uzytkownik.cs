using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    public abstract class Uzytkownik
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

        public Uzytkownik(string login, string haslo)
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
