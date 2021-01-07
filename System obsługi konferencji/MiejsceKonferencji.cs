﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class MiejsceKonferencji: Adres
    {
        private Adres adres;
        private int nrSali;
        private int iloscMiejsc;

        public Adres Adres { get => adres; set => adres = value; }
        public int NrSali { get => nrSali; set => nrSali = value; }
        public int IloscMiejsc { get => iloscMiejsc; set => iloscMiejsc = value; }

        public MiejsceKonferencji()
        {
            this.adres = null;
            this.nrSali = 0;
            this.iloscMiejsc = 0;
        }

        public MiejsceKonferencji(string ulica, string miejscowosc, string kodPocztowy, string numerBudynku, string numerLokalu, int nrSali, int iloscMiejsc): base(ulica, miejscowosc, kodPocztowy, numerBudynku, numerLokalu)
        {
            this.nrSali = nrSali;
            this.iloscMiejsc = iloscMiejsc;
        }
    }
}
