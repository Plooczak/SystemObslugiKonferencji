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
            List<Konferencja> nowaLista = new List<Konferencja>(listaKonferencji);
            nowaLista.Sort(new DataComparator());
            listaKonferencji = new LinkedList<Konferencja>(nowaLista);
        }

        public void SortujPoDacieOdKonca()
        {
            List<Konferencja> nowaLista = new List<Konferencja>(listaKonferencji);
            nowaLista.Sort(new DataComparator2());
            listaKonferencji = new LinkedList<Konferencja>(nowaLista);
        }

        public void SortujPoTemacie()
        {
            List<Konferencja> nowaLista = new List<Konferencja>(listaKonferencji);
            nowaLista.Sort(new DataComparator3());
            listaKonferencji = new LinkedList<Konferencja>(nowaLista);
        }

        public void PokazNadchodzace()
        {
            List<Konferencja> nowaLista = new List<Konferencja>(listaKonferencji);
            DateTime teraz = DateTime.Now;

            foreach (Konferencja conference in listaKonferencji)
            {
                if (conference.TerminRejestracji > teraz)
                {
                    nowaLista.Add(conference);
                }
            }

            nowaLista.Sort(new DataComparator());
            listaKonferencji = new LinkedList<Konferencja>(nowaLista);
        }

        public void PokazPrzeszle()
        {
            List<Konferencja> nowaLista = new List<Konferencja>(listaKonferencji);
            DateTime teraz = DateTime.Now;

            foreach (Konferencja conference in listaKonferencji)
            {
                if (conference.TerminRejestracji < teraz)
                {
                    nowaLista.Add(conference);
                }
            }

            nowaLista.Sort(new DataComparator());
            listaKonferencji = new LinkedList<Konferencja>(nowaLista);
        }

    }

    //Pokaż nadchodzące posortowane datami 
    //Pokaż wszystkie


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

    public class DataComparator2 : IComparer<Konferencja>
    {
        int IComparer<Konferencja>.Compare(Konferencja x, Konferencja y)
        {
            if (x != null && y != null)
            {
                return y.DataKonferencji.CompareTo(x.DataKonferencji);
            }

            return 0;
        }
    }

    public class DataComparator3 : IComparer<Konferencja>
    {
        int IComparer<Konferencja>.Compare(Konferencja x, Konferencja y)
        {
            if (x != null && y != null)
            {
                return x.Temat.CompareTo(y.Temat);
            }

            return 0;
        }
    }
}