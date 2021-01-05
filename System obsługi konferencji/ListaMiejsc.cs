using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class ListaMiejsc
    {
        public LinkedList<Miejsce> listaMiejsc;
        private LinkedList<Miejsce> Lista { get => listaMiejsc; set => listaMiejsc = value; }

        public ListaMiejsc()
        {
            listaMiejsc = new LinkedList<Miejsce>();
        }

        public void DodajMiejsce(Miejsce miejsce)
        {
            listaMiejsc.AddLast(miejsce);
        }
    }
}