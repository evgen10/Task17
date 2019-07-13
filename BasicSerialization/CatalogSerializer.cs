using BasicSerialization.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace BasicSerialization
{
    public class CatalogSerializer
    {
        private readonly string fileName = "books.xml";

        public void Serialize(Catalog catalog)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Catalog));
            XmlSerializerNamespaces namespc = new XmlSerializerNamespaces();

            namespc.Add(string.Empty, Namespaces.CatalogNamespace);

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, catalog, namespc);
            }
        }

        public Catalog Deserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Catalog));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var catalog = (Catalog)xmlSerializer.Deserialize(fs);

                return catalog;
            }
        }
    }
}
