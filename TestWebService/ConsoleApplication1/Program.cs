using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ip2GeoTestClient.IP2Geo geo = new Ip2GeoTestClient.IP2Geo();
            Ip2GeoTestClient.IPInformation info = geo.ResolveIP("49.204.64.246", "0");
            Console.WriteLine(info.Country);
            CalculatorService.Calculator cal = new CalculatorService.Calculator();
            Console.WriteLine(cal.add(3,5));
        }
    }
}
