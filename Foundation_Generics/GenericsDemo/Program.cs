using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            QTContainer<int> myIntContainer = new QTContainer<int>();
            for(int index=0;index<100;index++)
            {
                myIntContainer.SetItem(index, index);
            }
            for (int index = 0; index < 100; index++)
            {
                Console.WriteLine(myIntContainer.GetItem(index));
            }
        }
    }
}
