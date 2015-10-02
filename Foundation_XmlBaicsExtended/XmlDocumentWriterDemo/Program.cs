using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDocumentWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            XmlElement booksElement=document.CreateElement("Books");
            
            XmlElement authorElement = document.CreateElement("Author");
            authorElement.InnerText = "Christian Nagel";
            XmlElement bookElement = document.CreateElement("Book");
            bookElement.AppendChild(authorElement);
            booksElement.AppendChild(bookElement);
            document.AppendChild(booksElement);
            document.Save("Books.xml");
        }
    }
}
