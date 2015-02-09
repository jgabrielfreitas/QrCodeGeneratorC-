using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCode_Generator.Classes
{
    class CacheXML
    {

        public static string ReturnCacheXML(string name)
        {
            Xml xml = new Xml();
            xml.nm  = name;

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(xml.GetType());

            StringWriter writer = new StringWriter();
            x.Serialize(writer, xml);
            string result = writer.ToString().Replace(" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "").Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
            
            return result;
        }

    }
}
