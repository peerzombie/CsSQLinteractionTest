using System;
using System.Xml;

namespace XMLCRYPT
{
    public class XmlGateway
    {
        private string filepath = "data/data.xml";
        public XmlGateway(string file)
        {
            filepath = file;
        }

        public void CreateRoot()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(filepath);
            XmlElement elem = xdoc.CreateElement("root");
            elem.SetAttribute("MODEL", "STANDARD");
            XmlCDataSection cdata = xdoc.CreateCDataSection("");
            elem.AppendChild(cdata);
            xdoc.AppendChild(elem);
            xdoc.Save(filepath);
        }

        public void AddEnc(string name, string hash, string inc, DateTime created)
        {
            
        }
    }
}