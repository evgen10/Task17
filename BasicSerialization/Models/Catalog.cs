using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization.Models
{
    [Serializable]
    [XmlRoot(ElementName = "catalog", Namespace = Namespaces.CatalogNamespace)]
    public class Catalog
    {
        [XmlAttribute(AttributeName = "date", DataType = "date")]
        public DateTime Date { get; set; }
        [XmlElement("book")]
        public Book[] Books { get; set; }
    }
}
