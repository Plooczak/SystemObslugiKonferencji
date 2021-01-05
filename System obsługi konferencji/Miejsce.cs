using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class Miejsce
    {
        private string adres;
        private int nrSali;
        private int iloscMiejsc;

        public string Adres { get => adres; set => adres = value; }
        public int NrSali { get => nrSali; set => nrSali = value; }
        public int IloscMiejsc { get => iloscMiejsc; set => iloscMiejsc = value; }

        public Miejsce()
        {
            adres = null;
            nrSali = 0;
            iloscMiejsc = 0;
        }

    }
}
