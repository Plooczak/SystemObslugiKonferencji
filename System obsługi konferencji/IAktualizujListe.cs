using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_obsługi_konferencji
{
    interface IAktualizujListe
    {
        void DodajObiekt(dynamic o);
        bool UsunObiekt(string usunJesli);
        int PoliczObiekty();
        void Wyczysc();
    }
}
