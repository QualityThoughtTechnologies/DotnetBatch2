using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class OtherProduct:Product
    {
        public OtherProduct():base()
        {
            OtherDetails = string.Empty;
        }
        public string OtherDetails { get; set; }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Other Details are " + OtherDetails);
        }

        public override void DisplayRuntime()
        {
            base.Display();
            Console.WriteLine("Other Details are " + OtherDetails);
        }
    }
}
