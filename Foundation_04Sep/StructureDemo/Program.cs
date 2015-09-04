using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookInfo bookInfo=new BookInfo();
            bookInfo.Author = "Test";
            bookInfo.Id = "1";
            bookInfo.Name = "Test";
            Category category=(Category) Enum.Parse(typeof(Category), "Mathematics");
            bookInfo.Category = Category.Mathematics;
        }
    }
}
