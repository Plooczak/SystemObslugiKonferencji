using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class ListaUczestnikówKonferencji : ICloneable, IAktualizujListe
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista uczestnikow: ");
            foreach (Sluchacz s in listaUczestnikow)
            {
                sb.AppendLine(s.ToString());
            }

            return sb.ToString();
        }

        public void DodajObiekt(dynamic sluchacz)
        {
            listaUczestnikow.AddLast(sluchacz);
            liczbaUczestnikow++;
        }

        public bool UsunObiekt(string login)
        {
            var currentNode = listaUczestnikow.First;
            bool czyUsunieto = false;
            while (currentNode != null)
            {
                if (currentNode.Value.Login == login)
                {
                    var toRemove = currentNode;
                    currentNode = currentNode.Next;
                    listaUczestnikow.Remove(toRemove);
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
            return listaUczestnikow.Count();
        }

        public void Wyczysc()
        {
            listaUczestnikow.Clear();
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