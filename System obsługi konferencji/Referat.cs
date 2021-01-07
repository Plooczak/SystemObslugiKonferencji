using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class Referat
    {
        private string tytul;
        private string streszczenie;
        private Prelegent autor;
        private TimeSpan szacowanyCzasTrwania;

        public string Tytul { get => tytul; set => tytul = value; }
        public string Streszczenie { get => streszczenie; set => streszczenie = value; }
        public TimeSpan SzacowanyCzasTrwania { get => szacowanyCzasTrwania; set => szacowanyCzasTrwania = value; }
        internal Prelegent Autor { get => autor; set => autor = value; }

        public Referat()
        {
            tytul = null;
            streszczenie = null;
            autor = null;
            szacowanyCzasTrwania = new TimeSpan(0, 0, 0);
        }

        public Referat(string tytul, string streszczenie, Prelegent autor) : this()
        {
            this.tytul = tytul;
            this.streszczenie = streszczenie;
            this.autor = autor;
        }

        public TimeSpan DodajCzasTrwania(int godziny, int minuty)
        {
            return szacowanyCzasTrwania = new TimeSpan(godziny, minuty, 0);    
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

