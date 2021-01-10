using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    public class KonferencjaNotFoundException : Exception
    {
        public KonferencjaNotFoundException() : base()
        {
            Console.WriteLine("Nie ma takiej konferencji!");
        }
    }
}
