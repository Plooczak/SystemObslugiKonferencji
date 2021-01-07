using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class Adres
    {
        public string ulica { get; set; }
        public string miejscowosc { get; set; }
        public string kodPocztowy { get; set; }
        public string numerBudynku { get; set; }
        public string numerLokalu { get; set; }

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
