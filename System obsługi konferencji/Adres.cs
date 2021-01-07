using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class Adres
    {
        protected string ulica;
        protected string miejscowosc;
        protected string kodPocztowy;
        protected string numerBudynku;
        protected string numerLokalu;

        public string Ulica { get => ulica; set => ulica = value; }
        public string Miejscowosc { get => miejscowosc; set => miejscowosc = value; }
        public string KodPocztowy { get => kodPocztowy; set => kodPocztowy = value; }
        public string NumerBudynku { get => numerBudynku; set => numerBudynku = value; }
        public string NumerLokalu { get => numerLokalu; set => numerLokalu = value; }

        public Adres()
        {
            this.ulica = null;
            this.miejscowosc = null;
            this.kodPocztowy = null;
            this.numerBudynku = null;
            this.numerLokalu = null;
        }
        public Adres(string ulica, string miejscowosc, string kodPocztowy, string numerBudynku, string numerLokalu) : this()
        {
            this.ulica = ulica;
            this.miejscowosc = miejscowosc;
            this.kodPocztowy = kodPocztowy;
            this.numerBudynku = numerBudynku;
            this.numerLokalu = numerLokalu;
        }
    }
}
