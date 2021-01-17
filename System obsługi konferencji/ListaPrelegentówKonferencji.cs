using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class ListaPrelegentówKonferencji: IAktualizujListe, ICloneable
    {
        //private int liczbaPrelegentow;
        //public int LiczbaPrelegentow { get => liczbaPrelegentow; set => liczbaPrelegentow = value; }
        private LinkedList<Prelegent> listaPrelegentow;
        public LinkedList<Prelegent> Lista { get => listaPrelegentow; set => listaPrelegentow = value; }
        
        public ListaPrelegentówKonferencji()
        {
            listaPrelegentow = new LinkedList<Prelegent>();
        }
        
        public void DodajObiekt(dynamic prelegent)
        {
            listaPrelegentow.AddLast(prelegent);
        }

        public bool UsunObiekt(string login)
        {
            var currentNode = listaPrelegentow.First;
            bool czyUsunieto = false;
            while (currentNode != null)
            {
                if (currentNode.Value.Login == login)
                {
                    var toRemove = currentNode;
                    currentNode = currentNode.Next;
                    listaPrelegentow.Remove(toRemove);
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
            return listaPrelegentow.Count();
        }

        public void Wyczysc()
        {
            listaPrelegentow.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista prelegentow: ");
            foreach (Prelegent speaker in listaPrelegentow)
            {
                sb.AppendLine(speaker.ToString());
            }
            return sb.ToString();
        }

        public object Clone()
        {
            return (ListaPrelegentówKonferencji)this.MemberwiseClone();
        }

        public ListaPrelegentówKonferencji Kopiuj()
        {
            ListaPrelegentówKonferencji kopia = (ListaPrelegentówKonferencji)this.Clone();
            kopia.listaPrelegentow = new LinkedList<Prelegent>(listaPrelegentow.Select(x => (Prelegent)x.Clone()));
            return kopia;
        }
    }
}


