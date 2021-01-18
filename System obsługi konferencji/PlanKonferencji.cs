using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class PlanKonferencji
    {
        private TimeSpan czasDlaReferatow;
        public TimeSpan CzasDlaReferatow { get => czasDlaReferatow; set => czasDlaReferatow = value; }
        private LinkedList<Referat> planKonferencji;
        public LinkedList<Referat> Plan_Konferencji { get => planKonferencji; set => planKonferencji = value; }

        public PlanKonferencji()
        {
            planKonferencji = new LinkedList<Referat>();
            czasDlaReferatow = new TimeSpan(0, 0, 0);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista referatow: ");
            foreach (Referat r in planKonferencji)
            {
                sb.AppendLine(r.ToString());
            }

            return base.ToString();
        }

        public void SumujCzasDlaReferatow()
        {
            foreach (Referat r in planKonferencji)
            {
                czasDlaReferatow = czasDlaReferatow + r.SzacowanyCzasTrwania;
            }

        }
        public void DodajReferat(Referat referat)
        {
            planKonferencji.AddLast(referat);
        }
    }
}

