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
    public class DataStore
    {
        public List<Sluchacz> Sluchacze {get;set;}
        public List<Prelegent> Prelegenci { get; set; }
        public List<Organizator> Organizatorzy { get; set; }


        DataStore(List<Sluchacz> sluchacze, List<Prelegent> prelegenci, List<Organizator> organizatorzy)
        {
            this.Sluchacze = sluchacze;
            this.Prelegenci = prelegenci;
            this.Organizatorzy = organizatorzy;
        }
        void SerializujSluchaczy(List<Sluchacz> listS)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sluchacz>));
            using (TextWriter writer = new StreamWriter(@"C:\Xml.txt"))
            {
                serializer.Serialize(writer, listS);
            }
        }
    }
}