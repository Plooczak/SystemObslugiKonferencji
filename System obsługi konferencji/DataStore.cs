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

        public void DataStore_save(DataStore ds)
        {
            ds.SortAll(ds);
            XmlSerializer serializer = new XmlSerializer(typeof(DataStore));
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\BazaUzytkownikow.xml";

            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, ds);
            }
        }
        public static DataStore DataStore_load()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(DataStore));
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\BazaUzytkownikow.xml";

            using (TextReader reader = new StreamReader(path))
            {
                object ds = deserializer.Deserialize(reader);
                return ds as DataStore;
            }

        }
        public void SortAll(DataStore ds)
        {
            ds.Sluchacze.Sort();
            ds.Prelegenci.Sort();
            ds.Organizatorzy.Sort();
        }
    }
}