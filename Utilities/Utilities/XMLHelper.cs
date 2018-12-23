using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Utilities
{
    public static class XMLHelper
    {
        public static T DeserializeXmlToObject<T>(string xml)
        {
            XmlSerializer xmlDeserializeer = new XmlSerializer(typeof(T));
            return (T)xmlDeserializeer.Deserialize(new StringReader(xml));
        }

        public static string GetXmlFromObject(object o)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, o);
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
            }
            return sw.ToString();
        }
    }
}
