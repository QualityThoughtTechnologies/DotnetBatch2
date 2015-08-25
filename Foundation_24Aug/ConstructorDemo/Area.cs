using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Area
    {

        public double CalculateArea(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public double CalculateArea(double length,double breath)
        {
            return length * breath;
        }
        public double CalculateArea(int length)
        {
            return length * length;
        }
    }
}
