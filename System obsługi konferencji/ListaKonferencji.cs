using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System_obsługi_konferencji
{
    class ListaKonferencji
    {
        public LinkedList<Konferencja> listaKonferencji;
        private LinkedList<Konferencja> Lista { get => listaKonferencji; set => listaKonferencji = value; }

        public ListaKonferencji()
        {
            listaKonferencji = new LinkedList<Konferencja>();
        }

        public void DodajKonferencje(Konferencja konferencja)
        {
            listaKonferencji.AddLast(konferencja);
        }

        public void SortujPoDacie()
        {
            List<Konferencja> nowa_lista = new List<Konferencja>(listaKonferencji);
            nowa_lista.Sort(new DataComparator());
            listaKonferencji = new LinkedList<Konferencja>(nowa_lista);
        }

    }

    public class DataComparator : IComparer<Konferencja>
    {
        int IComparer<Konferencja>.Compare(Konferencja x, Konferencja y)
        {
            if (x != null && y != null)
            {
                return x.DataKonferencji.CompareTo(y.DataKonferencji);
            }

            return 0;
        }
    }
}