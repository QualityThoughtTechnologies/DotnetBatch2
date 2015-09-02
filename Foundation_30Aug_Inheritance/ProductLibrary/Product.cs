using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
            Brand = string.Empty;
            Price = 0;
            IsWarrantyApplicable = false;
            WarrantyDetails = string.Empty;
            Category = string.Empty;
        }

        public string Name { get; set; }

        public string Brand { get; set; }

        public double Price { get; set; }

        public string Code { get; set; }

        public bool IsWarrantyApplicable { get; set; }

        public string WarrantyDetails { get; set; }

        public string Category { set; get; }

        public void Purchase()
        {

        }

        public void Display()
        {
            Console.WriteLine("Name is {0} Brand is {1} Price is {2}",Name,Brand,Price);
        }

        public virtual void DisplayRuntime()
        {
            Console.WriteLine("Name is {0} Brand is {1} Price is {2}", Name, Brand, Price);
        }
        
    }
}
