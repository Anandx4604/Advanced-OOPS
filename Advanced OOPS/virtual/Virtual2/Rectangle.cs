using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class Rectangle : Dimension
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle(double length, double height,double value1, double value2):base(value1,value2)      
         {
            Length = length;
            Height = height;
        }

        public override double Calculate()
        {
            return Length*Height;
        }

        public override double DisplayArea()
        {
            return Calculate();
        }

    }
}