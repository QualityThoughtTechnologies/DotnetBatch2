using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingStationRevisitedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingStation p = new ParkingStation();
            p.Park(new Bike() { Name = "Test", Number = 1 });
            p.Park(new Bike() { Name = "Test", Number = 2 });
            p.Park(new Bike() { Name = "Test", Number = 3 });
            p.Park(new Bike() { Name = "Test", Number = 4 });
            p.Park(new Bike() { Name = "Test", Number = 5 });
            p.Park(new Bike() { Name = "Test", Number = 6 });
            p.Park(new Bike() { Name = "Test", Number = 7 });
            p.ShowAll();
            p.UnPark(5);
            p.UnPark(6);
            p.ShowAll();
        }
    }
}
