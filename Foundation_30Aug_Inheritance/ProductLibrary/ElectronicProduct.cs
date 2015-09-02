using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class ElectronicProduct:Product
    {
        public ElectronicProduct():base()
        {
            TechnicalDetails = string.Empty;
            Category = "Electronics";
        }
        public string TechnicalDetails { get; set; }

        public new void Display()
        {
            //base.Display();
            Console.WriteLine("Tecnical Details are "+TechnicalDetails);
        }

        public override void DisplayRuntime()
        {
            base.Display();
            Console.WriteLine("Tecnical Details are " + TechnicalDetails);
        }
    }
}
