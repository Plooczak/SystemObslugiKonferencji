using System_obsługi_konferencji;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace System_obsługi_konferencji
{
    [Serializable]
    public class DataStore
    {
        public List<Sluchacz> Sluchacze {get;set;}
        public List<Prelegent> Prelegenci { get; set; }
        public List<Organizator> Organizatorzy { get; set; }


        //DataStore(List<Sluchacz> sluchacze, List<Prelegent> prelegenci, List<Organizator> organizatorzy)
        //{
        //    this.Sluchacze = sluchacze;
        //    this.Prelegenci = prelegenci;
        //    this.Organizatorzy = organizatorzy;
        //}
        public void DataStore_save(DataStore ds)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataStore));
            
            //using (TextWriter writer = new StreamWriter("C:/Users/karbo/source/repos/Plooczak/SystemObs-ugiKonferencji/System obsługi konferencji/BazaUzytkownikow.xml"))
            using (TextWriter writer = new StreamWriter("C:/Users/Paweł/Desktop/Studia/AGH/Semestr III/Programowanie obiektowe/System obsługi konferencji/ESSGit/System obsługi konferencji/BazaUzytkownikow.xml"))
            {
                serializer.Serialize(writer, ds);
            }
        }
        public static DataStore DataStore_load()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(DataStore));
            //using (TextReader reader = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "\\BazaUzytkownikow.xml")))
   
            //using (TextReader reader = new StreamReader("C:/Users/karbo/source/repos/Plooczak/SystemObs-ugiKonferencji/System obsługi konferencji/BazaUzytkownikow.xml"))
            using (TextReader reader = new StreamReader("C:/Users/Paweł/Desktop/Studia/AGH/Semestr III/Programowanie obiektowe/System obsługi konferencji/ESSGit/System obsługi konferencji/BazaUzytkownikow.xml"))
            {
                object ds = deserializer.Deserialize(reader);
                return ds as DataStore;
            }

        }
    }
}