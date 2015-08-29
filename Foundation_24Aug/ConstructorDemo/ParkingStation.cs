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
        public ParkingStation()
        {
            this.size = 0;
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

        public void Park(Bike bike,bool isDynamic)
        {
            if(!isDynamic)
            {
                Park(bike);
            }
            else
            {
                int length;
                if(bikes==null)
                {
                    length = 1;
                }
                else
                {
                    length = bikes.Length + 1;
                }
                //length = bikes == null ? 1 : bikes.Length + 1;
                Bike[] tempBikes = new Bike[length];
                if(bikes!=null)
                {
                    for (int index = 0; index < bikes.Length; index++)
                    {
                        tempBikes[index] = bikes[index];
                    }
                }
                
                tempBikes[tempBikes.Length - 1] = bike;
                Console.WriteLine("Bike id parked at {0}", currentFreeLocation);
                currentFreeLocation++;
                bikes = tempBikes;
            }
        }

        public void UnPark(int location)
        {
            bikes[location] = null;
            currentFreeLocation = location;
        }

    }
}
