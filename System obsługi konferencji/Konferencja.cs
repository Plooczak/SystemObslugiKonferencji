using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System_obsługi_konferencji
{
    class Konferencja
    {
        private string idKonferencji;
        private string temat;
        private DateTime dataKonferencji;
        private DateTime terminRejestracji; //data konferencji - 7 dni
        private Organizator organizator;
        private ListaPrelegentówKonferencji prelegenci;
        private ListaUczestnikówKonferencji uczestnicy;
        private PlanKonferencji plan;
        private MiejsceKonferencji miejsce;

        public string IdKonferencji { get => idKonferencji; set => idKonferencji = value; }
        public string Temat { get => temat; set => temat = value; }
        public DateTime DataKonferencji { get => dataKonferencji; set => dataKonferencji = value; }
        public DateTime TerminRejestracji { get => terminRejestracji; set => terminRejestracji = value; }
        internal Organizator Organizator { get => organizator; set => organizator = value; }
        internal ListaPrelegentówKonferencji Prelegenci { get => prelegenci; set => prelegenci = value; }
        internal ListaUczestnikówKonferencji Uczestnicy { get => uczestnicy; set => uczestnicy = value; }
        internal PlanKonferencji Plan { get => plan; set => plan = value; }
        internal MiejsceKonferencji Miejsce { get => miejsce; set => miejsce = value; }

        public Konferencja()
        {
            dataKonferencji = DateTime.MinValue;
        }

        public Konferencja(string data_Konferencji) : this()
        {
            DateTime.TryParseExact(data_Konferencji, new[] { "dd-MM-yyyy" }, null, DateTimeStyles.None, out dataKonferencji);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}