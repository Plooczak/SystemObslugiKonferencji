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
        public static int idKonferencji = 0;
        private string temat;
        private DateTime dataKonferencji;
        private DateTime terminRejestracji; //data konferencji - 7 dni
        private Organizator organizator;
        private ListaPrelegentówKonferencji prelegenci;
        private ListaUczestnikówKonferencji uczestnicy;
        private PlanKonferencji plan;
        private MiejsceKonferencji miejsce;

        public int IdKonferencji { get => idKonferencji; set => idKonferencji = value; }
        public string Temat { get => temat; set => temat = value; }
        public DateTime DataKonferencji { get => dataKonferencji; set => dataKonferencji = value; }
        public DateTime TerminRejestracji { get => terminRejestracji; set => terminRejestracji = value; }
        internal Organizator Organizator { get => organizator; set => organizator = value; }
        internal ListaPrelegentówKonferencji Prelegenci { get => prelegenci; set => prelegenci = value; }
        internal ListaUczestnikówKonferencji Uczestnicy { get => uczestnicy; set => uczestnicy = value; }
        internal PlanKonferencji Plan { get => plan; set => plan = value; }
        internal MiejsceKonferencji MiejsceKonferencji { get => miejsce; set => miejsce = value; }

       
        public Konferencja()
        {
            idKonferencji++;
            temat = null;
            dataKonferencji = DateTime.MinValue;
            //terminRejestracji = dataKonferencji.AddDays(-7);
            //organizator = null;
            //prelegenci = null; 
        }

        public Konferencja(string temat, string data_Konferencji, Organizator organizator, MiejsceKonferencji miejsce) : this()
        {
            this.temat = temat;
            DateTime.TryParseExact(data_Konferencji, new[] { "dd-MM-yyyy" }, null, DateTimeStyles.None, out dataKonferencji);
            terminRejestracji = dataKonferencji.AddDays(-7);
            this.organizator = organizator;
            //this.prelegenci = prelegenci;
            //this.uczestnicy = uczestnicy;
            //this.plan = plan;
            this.miejsce = miejsce;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}