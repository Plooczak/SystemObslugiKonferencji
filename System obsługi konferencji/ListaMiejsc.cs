using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class ListaMiejsc
    {
        public LinkedList<MiejsceKonferencji> listaMiejsc;
        private LinkedList<MiejsceKonferencji> Lista { get => listaMiejsc; set => listaMiejsc = value; }

        public ListaMiejsc()
        {
            listaMiejsc = new LinkedList<MiejsceKonferencji>();
        }

        public void DodajMiejsce(MiejsceKonferencji miejsce)
        {
            listaMiejsc.AddLast(miejsce);
        }
    }
}