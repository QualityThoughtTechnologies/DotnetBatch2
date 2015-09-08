using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingStationRevisitedDemo
{
    class ParkingStation
    {
        IList<Bike> bikes = new List<Bike>();

        public void Park(Bike bike)
        {
            bikes.Add(bike);
        }

        public void UnPark(int number)
        {
            Bike bike;
            int foundAt = -1;
            for(int index=0;index<bikes.Count;index++)
            {
                if(bikes[index].Number==number)
                {
                    //bike = bikes[index];
                    foundAt = index;
                    break;
                }
            }
            //bikes.Remove(bike);
            bikes.RemoveAt(foundAt);
            //foreach(Bike bikeI in bikes)
            //{
            //    if(bikeI.Number==number)
            //    {
            //        bike = bikeI;
            //        break;
            //    }
            //}
            ////bikes.Remove(bike);

            //bikes.Remove(bikes.FirstOrDefault(item => item.Number == number));
            //from bike in bikes where 
            
        }

        public void ShowAll()
        {
            foreach (Bike bike in bikes)
            {
                Console.WriteLine(bike.Number);
            }
        }
    }
}
