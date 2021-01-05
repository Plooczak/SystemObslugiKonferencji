using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class Referat
    {
        private string tytul;
        private string streszczenie;
        private Prelegent autor;
        private DateTime szacowanyCzasTrwania;

        public string Tytul { get => tytul; set => tytul = value; }
        public string Streszczenie { get => streszczenie; set => streszczenie = value; }
        public DateTime SzacowanyCzasTrwania { get => szacowanyCzasTrwania; set => szacowanyCzasTrwania = value; }
        internal Prelegent Autor { get => autor; set => autor = value; }

        public Referat()
        {
            tytul = null;
            streszczenie = null;
            autor = null;
            szacowanyCzasTrwania = DateTime.MinValue;
        }

        public Referat(string tytul, string streszczenie, Prelegent autor, DateTime szacowanyCzasTrwania) : this()
        {
            this.tytul = tytul;
            this.streszczenie = streszczenie;
            this.autor = autor;
            this.szacowanyCzasTrwania = szacowanyCzasTrwania;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

