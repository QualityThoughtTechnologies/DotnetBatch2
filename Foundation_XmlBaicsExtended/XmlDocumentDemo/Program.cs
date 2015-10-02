using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDocumentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument studentsDcoument = new XmlDocument();
            studentsDcoument.Load("Students.xml");
            XmlNodeList studentNodeList=studentsDcoument.SelectNodes("/StudentsInformation/Studentlist/Student");
            foreach (XmlNode studentNode in studentNodeList)
            {
                Console.WriteLine(studentNode.InnerText.Trim());
                Console.WriteLine(studentNode.Attributes.GetNamedItem("id").Value);
            }
            Console.WriteLine( studentsDcoument.SelectSingleNode("/StudentsInformation/GeneralInformation/School").InnerText);
        }
    }
}
