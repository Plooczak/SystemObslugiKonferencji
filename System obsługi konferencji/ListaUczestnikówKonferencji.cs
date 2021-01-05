using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class ListaUczestnikówKonferencji
    {
        public LinkedList<Uzytkownik> listaUczestnikow;
        private LinkedList<Uzytkownik> Lista { get => listaUczestnikow; set => listaUczestnikow = value; }

        public ListaUczestnikówKonferencji()
        {
            listaUczestnikow = new LinkedList<Uzytkownik>();
        }

        public void DodajUczestnika(Uzytkownik uzytkownik)
        {
            listaUczestnikow.AddLast(uzytkownik);
        }
    }
}