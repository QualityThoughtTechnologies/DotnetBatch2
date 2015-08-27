using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorDemo
{
    class ParkingStation
    {
        int size;
        Bike[] bikes;
        int currentFreeLocation=0;
        public ParkingStation(int size)
        {
            this.size = size;
            bikes = new Bike[size];
        }

        public void Park(Bike bike)
        {
            if(currentFreeLocation<size)
            {
                if(bikes[currentFreeLocation]==null)
                {
                    bikes[currentFreeLocation] = bike;
                    Console.WriteLine("Bike id parked at {0}", currentFreeLocation);
                    currentFreeLocation++;
                }
                else
                {
                    Console.WriteLine("Bike is present at {0}",currentFreeLocation);
                }
                
            }
            else
            {
                Console.WriteLine("ParkingStation Full");
            }
        }

        public void UnPark(int location)
        {
            bikes[location] = null;
            currentFreeLocation = location;
        }

    }
}
