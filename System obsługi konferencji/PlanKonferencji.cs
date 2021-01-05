using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    class PlanKonferencji
    {
        private string idKonferencji;
        private TimeSpan czasDlaReferatow;
        public LinkedList<Referat> planKonferencji;
        private LinkedList<Referat> Lista { get => planKonferencji; set => planKonferencji = value; }

        public PlanKonferencji()
        {
            planKonferencji = new LinkedList<Referat>();
            czasDlaReferatow = new TimeSpan(0, 0, 0);
        }

        public void SumujCzasDlaReferatow()
        {
            foreach (Referat r in planKonferencji)
            {
                czasDlaReferatow = czasDlaReferatow + r.SzacowanyCzasTrwania;
            }

        }
        public void DodajUczestnika(Referat referat)
        {
            planKonferencji.AddLast(referat);
        }
    }
}

