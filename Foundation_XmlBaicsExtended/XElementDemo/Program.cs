using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XElementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement rootElement=XElement.Load("Students.xml");

            foreach (XElement element in rootElement.Element("Studentlist").Elements("Student"))
            {
                if(element.Attribute("score").Value=="100")
                {
                    Console.WriteLine(element.Attribute("enrollment").Value);
                }
                //Console.WriteLine(element.Value.Trim());
                //Console.WriteLine(element.Attribute("id").Value);
            }
            //foreach(XElement item in 
            //    rootElement.Element("Studentlist").Elements("Student").
            //    Where(item=>item.Attribute("score").Value=="100"))
            //{
            //    Console.WriteLine(item.Attribute("enrollment").Value);
            //}
        }
    }
}
