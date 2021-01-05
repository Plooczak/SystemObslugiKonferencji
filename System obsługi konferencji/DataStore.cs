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
        List<Sluchacz> sluchacze = new List<Sluchacz>();
        List<Prelegent> prelegenci = new List<Prelegent>();
        List<Organizator> organizatorzy = new List<Organizator>();


        DataStore(List<Sluchacz> sluchacze, List<Prelegent> prelegenci, List<Organizator> organizatorzy)
        {
            this.Sluchacze = sluchacze;
            this.Prelegenci = prelegenci;
            this.Organizatorzy = organizatorzy;
        }

        List<Sluchacz> Sluchacze { get => sluchacze; set => sluchacze = value; }
        List<Prelegent> Prelegenci { get => prelegenci; set => prelegenci = value; }
        List<Organizator> Organizatorzy { get => organizatorzy; set => organizatorzy = value; }

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