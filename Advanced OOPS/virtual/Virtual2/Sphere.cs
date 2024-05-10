using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class Sphere : Dimension
    {
        public double Radius { get; set; }
        public double SphereArea {get;set;}
        public Sphere(double value1, double value2,double radius) : base(value1, value2)
        {
            Radius = radius;
        }

        public override double Calculate()
        {
            return 4*Math.PI*Radius*Radius;
        }

        public override double DisplayArea()
        {
            return Calculate();
        }
    }
}