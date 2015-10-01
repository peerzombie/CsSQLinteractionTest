using System;
using System.CodeDom;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace XMLCRYPT
{
    public class XmlGateway
    {
        private readonly string _filepath;
        public XmlGateway(string file)
        {
            _filepath = file;
        }

        public void CreateRoot()
        {
            XmlDocument xdoc = new XmlDocument();
            XmlElement elem = xdoc.CreateElement("root");
            elem.SetAttribute("MODEL", "STANDARD");
            XmlCDataSection cdata = xdoc.CreateCDataSection("");
            elem.AppendChild(cdata);
            xdoc.AppendChild(elem);
            xdoc.Save(_filepath);
        }

        public void AddUsr(string name, string hash, int inc, DateTime created)
        {
            XmlDocument xdoc = new XmlDocument();
            if (!File.Exists(_filepath)) throw new FileNotFoundException();
            xdoc.Load(_filepath);
            XmlNode root = xdoc.SelectSingleNode("root");
            if (root != null)
            {
                XmlElement xmlUserRoot = xdoc.CreateElement("user");
                XmlElement xmlAddElement = xdoc.CreateElement("name");
                xmlAddElement.InnerText = name;
                xmlUserRoot.AppendChild(xmlAddElement);
                xmlAddElement = xdoc.CreateElement("str");
                xmlAddElement.InnerText = hash;
                xmlUserRoot.AppendChild(xmlAddElement);
                xmlAddElement = xdoc.CreateElement("inc");
                xmlAddElement.InnerText = Convert.ToString(inc);
                xmlUserRoot.AppendChild(xmlAddElement);
                xmlAddElement = xdoc.CreateElement("crtime");
                xmlAddElement.InnerText = created.ToString(new CultureInfo("de-DE"));
                xmlUserRoot.AppendChild(xmlAddElement);
                root.AppendChild(xmlUserRoot);
                xdoc.Save(_filepath);
            }
            else
            {
                MessageBox.Show("FATAL ERROR\nMALEFORMED XML DATA FILE\nABORTING !\nErrorCode: XML-Datacode-0001",
                    "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}