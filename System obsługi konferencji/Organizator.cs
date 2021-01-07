using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    public class Organizator : Uzytkownik, IComparable, IEquatable<Sluchacz>
    {
        public Adres adres { get; set; }
        public string numerKonta { get; set; }
        public static bool czyFirma { get; set; }
        public string nip { get; set; }
        public string nazwaFirmy { get; set; }

        public Organizator()
        {
            czyFirma = false;
            adres = new Adres();
            numerKonta = null;
            nip = null;
            nazwaFirmy = null;
        }
        public Organizator(string login, string haslo):base(login,haslo)
        {
            czyFirma = false;
            adres = null;
            numerKonta = null;
            nip = null;
            nazwaFirmy = null;
        }
        public Organizator(string login, string haslo, string ulica, string miejscowosc, string kodPocztowy, string numerBudynku, string numerLokalu, string numerKonta) : base(login, haslo)
        {
            adres.Ulica = ulica;
            adres.Miejscowosc = miejscowosc;
            adres.KodPocztowy = kodPocztowy;
            adres.NumerBudynku = numerBudynku;
            adres.NumerLokalu = numerLokalu;
            czyFirma = false;
            nip = null;
            nazwaFirmy = null;
        }

        public Organizator(string login, string haslo, string ulica, string miejscowosc, string kodPocztowy, string numerBudynku, string numerLokalu,
            string numerKonta, string nip, string nazwaFirmy) : base(login, haslo)
        {
            adres.Ulica = ulica;
            adres.Miejscowosc = miejscowosc;
            adres.KodPocztowy = kodPocztowy;
            adres.NumerBudynku = numerBudynku;
            adres.NumerLokalu = numerLokalu;
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

        public bool Equals(Sluchacz other)
        {
            return (login.Equals(other.Login));
        }

    }
}
