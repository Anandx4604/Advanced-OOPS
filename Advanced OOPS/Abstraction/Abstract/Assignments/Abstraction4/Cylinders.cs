using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction1
{
    public class Cylinders : Shape
    {
        public override double Area { get; set;}
        public override double Volume { get; set;}

        public Cylinders(double radius,double height)
        {
            Radius = radius;
            Height = height;
        }
        public override double CalculateArea()
        {
            return Area = 2*Math.PI*Radius*(Radius+Height);
        }

        public override double CalculateVolume()
        {
            return Volume = 2*Math.PI*Radius*Height;
        }
    }
}