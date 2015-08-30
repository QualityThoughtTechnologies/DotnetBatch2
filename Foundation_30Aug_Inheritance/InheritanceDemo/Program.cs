using ProductLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basics();
            Product product1 = new ElectronicProduct(); 
            // I want to assign product Properties
            //product1.Name = "Lumia 1020";
            //product1.Price = 45000;
            //product1.Brand = "Microsoft";
            //product1.IsWarrantyApplicable = true;
            //product1.WarrantyDetails = "2 years";
            product1.AssignProductValues(
                "Lumia 1020", "Microsoft", 45000, true, "2 years");
            product1.Display();
            Console.WriteLine("Runtime");
            product1.DisplayRuntime();
            ElectronicProduct e = (ElectronicProduct)product1;
            e.TechnicalDetails = "Windows Phone";
            e.Display();
            Console.WriteLine("Runtime");
            product1.DisplayRuntime();
            product1 = e;
            product1.Display();
            Console.WriteLine("Runtime");
            product1.DisplayRuntime();

            Product product2 = new OtherProduct();
            product2.AssignProductValues("Axis Bank Gif Card", "Axis Bank", 5000);

            OtherProduct o = product2 as OtherProduct;
            if(o!=null)
            {
                o.OtherDetails = "I dont Know";
            }

        }

        private static void Basics()
        {
            ElectronicProduct elec = new ElectronicProduct();
            OtherProduct oProduct = new OtherProduct();
            elec.Brand = "Sony";
            elec.Purchase();
        }
    }
}
