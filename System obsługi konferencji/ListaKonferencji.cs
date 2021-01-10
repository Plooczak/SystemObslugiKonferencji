using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System_obsługi_konferencji
{
    public class ListaKonferencji: IAktualizujListe//, IEnumerable<Konferencja>
    {
        public LinkedList<Konferencja> listaKonferencji;
        public LinkedList<Konferencja> Lista_Konferencji { get => listaKonferencji; set => listaKonferencji = value; }
        //public ListaKonferencji(System.Collections.Generic.IEnumerable<Konferencja> collection) { }

        public ListaKonferencji()
        {
            listaKonferencji = new LinkedList<Konferencja>();
        }

        public void DodajObiekt(dynamic konferencja)
        {
            listaKonferencji.AddLast(konferencja);
        }
        public bool UsunObiekt(string temat)
        {
            var currentNode = listaKonferencji.First;
            bool czyUsunieto = false;
            while (currentNode != null)
            {
                if (currentNode.Value.Temat == temat)
                {
                    var toRemove = currentNode;
                    currentNode = currentNode.Next;
                    listaKonferencji.Remove(toRemove);
                    czyUsunieto = true;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
            return czyUsunieto;
        }

        public int PoliczObiekty()
        {
            return listaKonferencji.Count();
        }

        public void Wyczysc()
        {
            listaKonferencji.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("NLista Konferencji \n");
            foreach (Konferencja konf in listaKonferencji)
            {
                int i = 1;
                sb.AppendLine(i + "." + " \"" + konf.Temat.ToString() + "\" ");
                i++;
            }

            return sb.ToString();
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

        public Konferencja ZnajdzKonferencje(string temat)
        {
            Konferencja k = new Konferencja();
            bool f = false;

            foreach (Konferencja konf in listaKonferencji)
            {
                if (k.Temat.Equals(temat))
                {
                    k = konf;
                    f = true;
                }

            }

            if (!f)
            {
                throw new KonferencjaNotFoundException();
            }

            return k;
        }

        //public ListaKonferencjiEnumerator(LinkedList<Konferencja> collection)
        //{
        //}


        //public IEnumerator<Konferencja> GetEnumerator()
        //{
          //  return new ListaKonferencjiEnumerator<Konferencja>(this);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
          //  return new NotImplementedException();
        //}
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