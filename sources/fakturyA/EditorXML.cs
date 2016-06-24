using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace fakturyA
{
    public class EditorXML
    {
        List<XmlElement> elements = new List<XmlElement>();
        XmlDocument document = new XmlDocument();
        FileInfo xmlFile;
        string file = "";
        bool name_exsist = false;
        public EditorXML(string FilePath)
        {
            xmlFile = new FileInfo(FilePath);
            file = FilePath;
            if (xmlFile.Exists)
            {
                try
                {

                    document.Load(FilePath);
                }
                catch (XmlException e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }
            else
            {
                XmlDeclaration xmlDeclaration = document.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = document.DocumentElement;
                document.InsertBefore(xmlDeclaration, root);
                XmlElement element1 = document.CreateElement(string.Empty, "body", string.Empty);
                document.AppendChild(element1);

                document.Save(FilePath);
            }
        }
        public void AddToXML(string name, string contents)
        {
            name_exsist = false;
            FindInXML(name);
            if (name_exsist == false)
            {
                XmlElement element1 = document.CreateElement(string.Empty, name, string.Empty);
                XmlText text1 = document.CreateTextNode(contents);
                element1.AppendChild(text1);
                document.DocumentElement.AppendChild(element1);
                document.Save(file);

            }
            else
            {
                XElement xmlOverwrite = XElement.Load(file);
                XElement element = xmlOverwrite.Element(name);
                XElement change = element.Element(name);
                element.Value = contents;
                xmlOverwrite.Save(file);
                document.Load(file);
            }

        }
        public string FindInXML(string name)
        {

            XmlNodeList elemList = document.GetElementsByTagName(name);
            string s = "";
            for (int i = 0; i < elemList.Count; i++)
            {
                s = elemList[i].InnerXml;
                name_exsist = true;
            }

            return s;
        }


    }
}
