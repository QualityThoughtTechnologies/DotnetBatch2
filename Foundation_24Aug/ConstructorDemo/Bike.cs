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

        private static int petrolTanks=1;

        public string RegNo { set; get; }

        public static  int PetrolTanks
        {
            get { return petrolTanks; }
            set { petrolTanks = value; }
        }
        
        public void Display()
        {
            Console.WriteLine("Model is {0} & Engine Capacity is {1}",Model, EngineCapacity);
            DisplayPetrolTanks();
        }

        public void Display(string sponsor)
        {
            Display();
            Console.WriteLine("Sponsered by {0}", sponsor);
        }

        public static void DisplayPetrolTanks()
        {
            Console.WriteLine("Petrol tanks : {0}",PetrolTanks);
            
            //Display();
        }
    }
}
