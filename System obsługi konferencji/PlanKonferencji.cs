using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class PlanKonferencji
    {
        //private string idKonferencji;
        //public string IdKonferencji { get => idKonferencji; set  =>  idKonferencji  =  value; }
        private TimeSpan czasDlaReferatow;
        public TimeSpan CzasDlaReferatow { get => czasDlaReferatow; set => czasDlaReferatow = value; }
        private LinkedList<Referat> planKonferencji;
        public LinkedList<Referat> Plan_Konferencji { get => planKonferencji; set => planKonferencji = value; }

        public PlanKonferencji()
        {
           // idKonferencji = null;
            planKonferencji = new LinkedList<Referat>();
            czasDlaReferatow = new TimeSpan(0, 0, 0);
        }

        //public PlanKonferencji(string id) : this()
        //{
        //   this.idKonferencji = id;
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Id: " + idKonferencji);
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

