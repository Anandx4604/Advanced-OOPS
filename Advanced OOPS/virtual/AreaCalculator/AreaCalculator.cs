using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class AreaCalculator
    {
        public double Radius { get; set; }
        public double CircleArea{get;set;}

        public AreaCalculator(double radius)
        {
            Radius = radius;
        }
        public virtual void Calculate()
        {
            CircleArea = Math.PI*Radius*Radius;
        }

        public virtual double Display()
        {
            return CircleArea; 
        }
    }
}