using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Adapter
{
    public class AdapterClass : IJsonConvert
    {
        public string ConvertToJson(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            return  JsonConvert.SerializeXmlNode(doc);
        }
    }
}
