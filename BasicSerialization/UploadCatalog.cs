using BasicSerialization.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization
{
    public class UploadCatalog
    {
        public void Serialize(Catalog catalog)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Catalog));

            using (FileStream fs = new FileStream("catalog.xml",FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, catalog);
            }

        }
    }
}
