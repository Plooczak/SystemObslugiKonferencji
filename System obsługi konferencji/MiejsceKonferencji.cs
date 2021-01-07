using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class MiejsceKonferencji
    {
        private string ulica;
        private string miejscowosc;
        private string kodPocztowy;
        private int numerBudynku;
        private int numerLokalu;
        private int nrSali;
        private int iloscMiejsc;

        public string Ulica { get => ulica; set => ulica = value; }
        public string Miejscowosc { get => miejscowosc; set => miejscowosc = value; }
        public string KodPocztowy { get => kodPocztowy; set => kodPocztowy = value; }
        public int NumerBudynku { get => numerBudynku; set => numerBudynku = value; }
        public int NumerLokalu { get => numerLokalu; set => numerLokalu = value; }
        public int NrSali { get => nrSali; set => nrSali = value; }
        public int IloscMiejsc { get => iloscMiejsc; set => iloscMiejsc = value; }

        public MiejsceKonferencji()
        {
            this.ulica = null;
            this.miejscowosc = null;
            this.kodPocztowy = null;
            this.numerBudynku = 0;
            this.numerLokalu = 0;
            this.nrSali = 0;
            this.iloscMiejsc = 0;
        }

        public MiejsceKonferencji(string ulica, string miejscowosc, string kodPocztowy, int numerBudynku, int numerLokalu, int nrSali, int iloscMiejsc)
        {
            this.ulica = ulica;
            this.miejscowosc = miejscowosc;
            this.kodPocztowy = kodPocztowy;
            this.numerBudynku = numerBudynku;
            this.numerLokalu = numerLokalu;
            this.nrSali = nrSali;
            this.iloscMiejsc = iloscMiejsc;
        }
    }
}
