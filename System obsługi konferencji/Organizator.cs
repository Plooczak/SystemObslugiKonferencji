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
        private string adres { get; set; }
        private string numerKonta { get; set; }
        private static bool czyFirma { get; set; }
        private string nip { get; set; }
        private string nazwaFirmy { get; set; }

        public Organizator()
        {
            czyFirma = false;
            adres = null;
            numerKonta = null;
            nip = null;
            nip = null;
            nazwaFirmy = null;
        }
        public Organizator(string login, string haslo):base(login,haslo)
        {
            czyFirma = false;
            adres = null;
            numerKonta = null;
            nip = null;
            nip = null;
            nazwaFirmy = null;
        }
        public Organizator(string login, string haslo, string adres, string numerKonta) : base(login, haslo)
        {
            this.adres = adres;
            this.numerKonta = numerKonta;
            czyFirma = false;
            nip = null;
            nazwaFirmy = null;
        }

        public Organizator(string login, string haslo, string adres, string numerKonta, string nip, string nazwaFirmy) : base(login, haslo)
        {
            this.adres = adres;
            this.numerKonta = numerKonta;
            czyFirma = true;
            this.nip = nip;
            this.nazwaFirmy = nazwaFirmy;
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
