using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    public class Prelegent : Uzytkownik, IComparable<Prelegent>, IEquatable<Prelegent>, ICloneable
    {
        public string stopienNaukowy { get; set; }
        public string dziedzina { get; set; }
        public string opis { get; set; }
        

        public Prelegent()
        {
            stopienNaukowy = null;
            dziedzina = null;
            opis = null;
        }
        public Prelegent(string login, string haslo) : base(login, haslo)
        {
            stopienNaukowy = null;
            dziedzina = null;
            opis = null;
        }

        public Prelegent(string login, string haslo, string stopienNaukowy, string dziedzina, string opis) : base(login, haslo)
        {
            this.stopienNaukowy = stopienNaukowy;
            this.dziedzina = dziedzina;
            this.opis = opis;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(Prelegent other) => login.CompareTo(other.login);


        public bool Equals(Prelegent other)
        {
            return (login.Equals(other.Login));
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
