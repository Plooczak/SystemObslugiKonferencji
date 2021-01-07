using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class ListaUczestnikówKonferencji : ICloneable
    {
        private int liczbaUczestnikow;
        public int LiczbaUczestnikow { get => liczbaUczestnikow; set => liczbaUczestnikow = value; }
        private LinkedList<Sluchacz> listaUczestnikow;
        public LinkedList<Sluchacz> Lista { get => listaUczestnikow; set => listaUczestnikow = value; }

        public ListaUczestnikówKonferencji()
        {
            listaUczestnikow = new LinkedList<Sluchacz>();
            liczbaUczestnikow = 0;
        }

        public void DodajUczestnika(Sluchacz sluchacz)
        {
            listaUczestnikow.AddLast(sluchacz);
            liczbaUczestnikow++;
        }

        public object Clone()
        {
            return (ListaUczestnikówKonferencji)this.MemberwiseClone();
        }

        public ListaUczestnikówKonferencji Kopiuj()
        {
            ListaUczestnikówKonferencji kopia = (ListaUczestnikówKonferencji)this.Clone();
            kopia.listaUczestnikow = new LinkedList<Sluchacz>(listaUczestnikow.Select(x => (Sluchacz)x.Clone()));
            return kopia;
        }
    }
}