using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgramoProjekt
{
    class Konferencja
    {
        private DateTime dataKonferencji;

        public DateTime DataKonferencji { get => dataKonferencji; set => dataKonferencji = value; }

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
