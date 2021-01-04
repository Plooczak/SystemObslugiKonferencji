using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgramoProjekt
{
    class Organizator : Uzytkownik
    {
        public Organizator()
        {

        }

        public Organizator(string imie, string nazwisko, string plec, string data_Urodzenia, string nrTelefonu, string email, string login, string haslo) : base(imie, nazwisko, plec, data_Urodzenia, nrTelefonu, email, login, haslo)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
