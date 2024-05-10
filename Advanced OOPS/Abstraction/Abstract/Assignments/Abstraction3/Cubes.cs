using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction1
{
    public class Cubes : Shape
    {
        public Cubes(double side)
        {
            Side = side;
        }
        
        public override double Area { get; set; }
        public override double Volume { get; set; }

        public override double CalculateArea()
        {
            return Area = 6*Side*Side;
        }

        public override double CalculateVolume()
        {
            return Volume = Side*Side*Side;
        }
    }
}