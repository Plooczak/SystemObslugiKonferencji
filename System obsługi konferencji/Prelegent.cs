using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    public class Prelegent : Uzytkownik, IComparable, IEquatable<Prelegent>
    {
        private string stopienNaukowy { get; set; }
        private string opis { get; set; }

        public Prelegent()
        {
            stopienNaukowy = null;
            opis = null;
        }
        public Prelegent(string login, string haslo):base(login,haslo)
        {
            stopienNaukowy = null;
            opis = null;
        }

        public Prelegent(string login, string haslo, string stopienNaukowy, string opis) : base(login, haslo)
        {
            this.stopienNaukowy = stopienNaukowy;
            this.opis = opis;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                Prelegent p = (Prelegent)obj;
                int pom = this.Login.CompareTo(p.login);

                if (pom != 0)
                {
                    return pom;
                }

                else
                {
                    return this.haslo.CompareTo(p.Haslo);
                }
            }

            else
                return 1;
        }

        public bool Equals(Prelegent other)
        {
            return (login.Equals(other.Login));
        }

    }
}
