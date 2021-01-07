using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class ListaUczestnikówKonferencji
    {
        private int liczbaUczestnikow;
        public int LiczbaUczestnikow { get => liczbaUczestnikow; set => liczbaUczestnikow = value; }
        public LinkedList<Sluchacz> listaUczestnikow;
        private LinkedList<Sluchacz> Lista { get => listaUczestnikow; set => listaUczestnikow = value; }

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
    }
}