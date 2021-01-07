using System;
using System_obsługi_konferencji;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SystemObsługiKonferencjiTesty
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestCompareTo() //test sprawdzajacy metode CompareTo
        {
            Organizator o1 = new Organizator("Login2", "haslo2");
            Organizator o2 = new Organizator("Login1", "haslo1");
            Assert.AreEqual(1, o1.CompareTo(o2));
            //test bedzie pozytywny, jesli dane sa rozne 
        }

        [TestMethod]
        public void TestLiczbyUczestnikow() //sprawdzanie metody dodawania uczestników konferencji
        {
            Sluchacz s1 = new Sluchacz("login1", "haslo1");
            Sluchacz s2 = new Sluchacz("login2", "haslo2");
            ListaUczestnikówKonferencji list = new ListaUczestnikówKonferencji();
            list.DodajUczestnika(s1);
            list.DodajUczestnika(s2);
            Assert.AreEqual(2, list.LiczbaUczestnikow); 
            //pozytywny test oznacza, ze licznik uczestnikow dziala poprawnie
        }
    }
}
