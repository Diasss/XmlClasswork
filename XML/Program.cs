using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Empl01();
        }
        static void Empl01()
        {
            XmlDocument doc = new XmlDocument();

            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            doc.AppendChild(declaration);

            XmlElement root = doc.CreateElement("root");
            XmlElement note = doc.CreateElement("note");

            XmlAttribute date = doc.CreateAttribute("date");
            date.InnerText = DateTime.Now.ToShortDateString();
            root.Attributes.Append(date);


            XmlElement message = doc.CreateElement("message");
            message.InnerText = "приветъ";

            note.AppendChild(message); //добавляем в node элемент message
            root.AppendChild(note); //добавляем в root элемент note
            doc.AppendChild(root);

            doc.Save("note.xml");
        }
    }
}
