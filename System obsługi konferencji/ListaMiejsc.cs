using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class ListaMiejsc: IAktualizujListe
    {
        public LinkedList<MiejsceKonferencji> listaMiejsc;
        private LinkedList<MiejsceKonferencji> Lista { get => listaMiejsc; set => listaMiejsc = value; }

        public ListaMiejsc()
        {
            listaMiejsc = new LinkedList<MiejsceKonferencji>();
        }
        public void DodajObiekt(MiejsceKonferencji miejsce)
        {
            listaMiejsc.AddLast(miejsce);
        }

        public void DodajObiekt(dynamic o)
        {
            listaMiejsc.AddLast(o);
        }

        public bool UsunObiekt(string nrSali)
        {
            var currentNode = listaMiejsc.First;
            bool czyUsunieto = false;
            while (currentNode != null)
            {
                if (currentNode.Value.NrSali.ToString() == nrSali)
                {
                    var toRemove = currentNode;
                    currentNode = currentNode.Next;
                    listaMiejsc.Remove(toRemove);
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
            return listaMiejsc.Count();
        }

        public void Wyczysc()
        {
            listaMiejsc.Clear();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista miejsc: ");
            foreach (MiejsceKonferencji m in listaMiejsc)
            {
                sb.AppendLine(m.ToString());
            }
            return sb.ToString();
        }
    }
}