using System;
using System_obsługi_konferencji;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
            list.DodajObiekt(s1);
            list.DodajObiekt(s2);
            Assert.AreEqual(2, list.LiczbaUczestnikow); 
            //pozytywny test oznacza, ze licznik uczestnikow dziala poprawnie
        }

        [TestMethod]
        public void TestLiczbyUczestniko_Count() //sprawdzanie metody Count
        {
            Sluchacz s1 = new Sluchacz("login1", "haslo1");
            Sluchacz s2 = new Sluchacz("login2", "haslo2");
            ListaUczestnikówKonferencji list = new ListaUczestnikówKonferencji();
            list.DodajObiekt(s1);
            list.DodajObiekt(s2);
            Assert.AreEqual(2, list.PoliczObiekty());
            //pozytywny test oznacza, ze metoda dziala poprawnie
        }

        [TestMethod]
        public void TestListyPrelegentow() //sprawdzanie metody dodawania prelegentow konferencji 
        {
            ListaPrelegentówKonferencji list = new ListaPrelegentówKonferencji();
            Prelegent p1 = new Prelegent("login1", "haslo1");
            Prelegent p2 = new Prelegent("login2", "haslo2");
            list.DodajObiekt(p1);
            list.DodajObiekt(p2);
            Assert.IsNotNull(list);
            //pozytywny test oznacza, ze licznik prelegentow dziala poprawnie - lista nie jest pusta
        }
        
        [TestMethod]
        public void TestUsunObiekt() //sprawdzenie metody usuwania obiektu
        {
            ListaPrelegentówKonferencji list = new ListaPrelegentówKonferencji();
            Prelegent p1 = new Prelegent("login1", "haslo1");
            Prelegent p2 = new Prelegent("login2", "haslo2");
            Prelegent p3 = new Prelegent("login3", "haslo3");
            list.DodajObiekt(p1);
            list.DodajObiekt(p2);
            list.DodajObiekt(p3);
            ListaPrelegentówKonferencji list2 = list.Kopiuj();
            list.UsunObiekt("login2");
            Assert.AreNotSame(list, list2);
            //pozytywny test oznacza, ze metoda usun obiekt dziala poprawnie 
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
            list.DodajObiekt(s1);
            list.DodajObiekt(s2);
            list.DodajObiekt(s3);
            list.DodajObiekt(s4);
            list.DodajObiekt(s5);
            list.DodajObiekt(s6);
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
        public void TestWyczysc() //test metody wyczysc
        {
            MiejsceKonferencji m1 = new MiejsceKonferencji("Kwiatowa", "Krakow", "30-332", "5", "6", 1, 50);
            MiejsceKonferencji m2 = new MiejsceKonferencji("Sloneczna", "Krakow", "30-002", "12", "10", 1, 50);
            MiejsceKonferencji m3 = new MiejsceKonferencji("Kolejowa", "Krakow", "31-932", "17", "6", 3, 75);
            ListaMiejsc list = new ListaMiejsc();
            list.DodajObiekt(m1);
            list.DodajObiekt(m2);
            list.DodajObiekt(m3);
            list.Wyczysc();
            int liczba = 0;
            Assert.IsTrue(list.PoliczObiekty() == liczba);
            //pozytywny wynik oznacza, ze lista jest pusta
        }
    }
}
