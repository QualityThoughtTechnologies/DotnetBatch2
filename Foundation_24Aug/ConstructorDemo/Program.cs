using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike();
            bike1.Display();
            Bike.PetrolTanks = 2;
            bike1.EngineCapacity = "250cc";
            bike1.Model = "2014";
            //DisplayBikeINfo(bike1);
            bike1.Display("AB");
            //bike1.Display();
            Bike bike2 = new Bike("2014", "350cc");
            //DisplayBikeINfo(bike2);
            bike2.Display();
            bike2.Display("DLF");

        }

        //private static void DisplayBikeINfo(Bike bike1)
        //{
        //    Console.WriteLine(bike1.EngineCapacity);
        //    Console.WriteLine(bike1.Model);
        //}
    }
}
