using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    static class ProductExtension
    {
        public static void AssignProductValues(
            this ProductLibrary.Product product,string name,
            string brand, double price,bool isWarrantyApplicable=false,
            string warrantyDetails="")
        {
            product.Name = name;
            product.Price = price;
            product.Brand = brand;
            product.IsWarrantyApplicable = isWarrantyApplicable;
            product.WarrantyDetails = warrantyDetails;
        }
    }
}
