using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    public class Organizator : Uzytkownik, IComparable<Organizator>, IEquatable<Organizator>
    {
        public Adres adres { get; set; }
        public string numerKonta { get; set; }
        public string nip { get; set; }
        public string nazwaFirmy { get; set; }

        public Organizator()
        {
            adres = new Adres();
            numerKonta = null;
            nip = null;
            nazwaFirmy = null;
        }
        public Organizator(string login, string haslo):base(login,haslo)
        {
            adres = null;
            numerKonta = null;
            nip = null;
            nazwaFirmy = null;
        }
        public Organizator(string login, string haslo, Adres adres, string numerKonta) : base(login, haslo)
        {
            this.adres = adres;
            this.numerKonta = numerKonta;
            nip = null;
            nazwaFirmy = null;
        }

        public Organizator(string login, string haslo, Adres adres, string numerKonta, string nip, string nazwaFirmy) : base(login, haslo)
        {
            this.adres = adres;
            this.numerKonta = numerKonta;
            this.nip = nip;
            this.nazwaFirmy = nazwaFirmy;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(Organizator other) => login.CompareTo(other.login);

        public bool Equals(Organizator other)
        {
            return (login.Equals(other.Login));
        }

    }
}
