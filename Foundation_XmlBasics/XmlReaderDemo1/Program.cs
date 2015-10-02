using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlReaderDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlReader booksReader = new XmlTextReader("Books.xml");
            while(booksReader.Read())
            {
                Console.WriteLine("Node Type={0}, Name={1}, Value={2}",booksReader.NodeType,booksReader.Name,booksReader.Value);
                if(booksReader.Name=="Book")
                {
                    booksReader.MoveToContent();
                }
            }

            XmlWriter writer = XmlWriter.Create("NewBooks.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("Books");
            writer.WriteElementString("Book", "My book");
            writer.WriteEndElement();
            //writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();


        }
    }
}
