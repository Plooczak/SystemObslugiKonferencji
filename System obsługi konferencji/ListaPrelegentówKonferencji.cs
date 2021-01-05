using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class ListaPrelegentówKonferencji
    {
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

/*
        public List<Prelegent> ZnajdzKonferencjePrelegenta(Login login)
        {
            List<Prelegent> nowaLista = new List<Prelegent>();

            foreach (Prelegent p in listaPrelegentow)
            {
                if (p.Login.Equals(Login))
                {
                    nowaLista.Add(p);
                }
            }

            return nowaLista.Count == 0 ? null : nowaLista;
        }

*/
