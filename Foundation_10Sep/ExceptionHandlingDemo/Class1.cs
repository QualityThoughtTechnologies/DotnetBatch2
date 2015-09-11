using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Class1
    {

        public static string ISBNSearch(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                MyException ex = new MyException("Name Parameter is null");
                throw ex;
            }
            return "test";
        }
    }
}
