using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Bike
    {
        public Bike()
        {
            Model = "2015";
            EngineCapacity = "150cc";
        }

        public Bike(string model,string engineCapacity)
        {
            Model = model;
            EngineCapacity = engineCapacity;
        }
        public string Model { set; get; }

        public string EngineCapacity { set; get; }

        public void Display()
        {
            Console.WriteLine("Model is {0} & Engine Capacity is {1}",Model, EngineCapacity);
        }

        public void Display(string sponsor)
        {
            Display();
            Console.WriteLine("Sponsered by {0}", sponsor);
        }
    }
}
