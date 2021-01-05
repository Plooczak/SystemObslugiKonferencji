using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class ListaPrelegentówKonferencji
    {
        private string idKonferencji;
        public LinkedList<Prelegent> listaPrelegentow;
        private LinkedList<Prelegent> Lista { get => listaPrelegentow; set => listaPrelegentow = value; }
        
        public ListaPrelegentówKonferencji()
        {
            listaPrelegentow = new LinkedList<Prelegent>();
        }
        
        public void DodajPrelegenta(Prelegent prelegent)
        {
            listaPrelegentow.AddLast(prelegent);
        }
    }
}