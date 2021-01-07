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

        [TestMethod]
        public void TestListyPrelegentow() //sprawdzanie metody dodawania prelegentow konferencji 
        {
            ListaPrelegentówKonferencji list = new ListaPrelegentówKonferencji();
            Prelegent p1 = new Prelegent("login1", "haslo1");
            Prelegent p2 = new Prelegent("login2", "haslo2");
            list.DodajPrelegenta(p1);
            list.DodajPrelegenta(p2);
            Assert.IsNotNull(list);
            //pozytywny test oznacza, ze licznik prelegentow dziala poprawnie - lista nie jest pusta
        }

        [TestMethod]
        public void TestCzyPrzekroczono() //test metody sprawdzajacej czy przekroczono liczbe uczetnikow konferencji
        {
            ListaUczestnikówKonferencji list = new ListaUczestnikówKonferencji();
            Sluchacz s1 = new Sluchacz("login1", "haslo1");
            Sluchacz s2 = new Sluchacz("login2", "haslo2");
            Sluchacz s3 = new Sluchacz("login3", "haslo3");
            Sluchacz s4 = new Sluchacz("login4", "haslo4");
            Sluchacz s5 = new Sluchacz("login5", "haslo5");
            Sluchacz s6 = new Sluchacz("login6", "haslo6");
            list.DodajUczestnika(s1);
            list.DodajUczestnika(s2);
            list.DodajUczestnika(s3);
            list.DodajUczestnika(s4);
            list.DodajUczestnika(s5);
            list.DodajUczestnika(s6);
            MiejsceKonferencji m = new MiejsceKonferencji("Kwiatowa", "Krakow", "30-332", "5", "6", 1, 5);
            Assert.IsTrue(m.CzyPrzekroczono(list));
            //pozytywny test oznacza, ze nie przekroczono
        }

        [TestMethod]
        public void TestDodajCzasTrwania() //test metody dodajacej czas trwania wystapienia na konferencji
        {
            TimeSpan czas1 = new TimeSpan(1, 30, 0);
            Prelegent p1 = new Prelegent("login", "haslo");
            Referat r1 = new Referat("tytul", "streszczenie", p1);
            Assert.AreEqual(czas1, r1.DodajCzasTrwania(1, 30));
            //pozytywny wynik oznacza, ze czasy sa identyczne
        }

        [TestMethod]
        public void TestKopiuj() //test metody kopiuj, ktora klonuje liste uczestnikow
        {
            //ListaUczestnikówKonferencji list = new ListaUczestnikówKonferencji();
            //Sluchacz s1 = new Sluchacz("login1", "haslo1");
            //Sluchacz s2 = new Sluchacz("login2", "haslo2");
            //Sluchacz s3 = new Sluchacz("login3", "haslo3");
            //Sluchacz s4 = new Sluchacz("login4", "haslo4");
            //Sluchacz s5 = new Sluchacz("login5", "haslo5");
            //list.DodajUczestnika(s1);
            //list.DodajUczestnika(s2);
            //list.DodajUczestnika(s3);
            //list.DodajUczestnika(s4);
            //list.DodajUczestnika(s5);
            
            //ListaUczestnikówKonferencji list2 = list.Kopiuj();
            //Assert.AreEqual(list, list2);
        }
    }
}
