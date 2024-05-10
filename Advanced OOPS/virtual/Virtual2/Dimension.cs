using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class Dimension
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }

        public Dimension(double value1, double value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public virtual double Calculate()
        {
            return Value1 * Value2;
        }

        public virtual double DisplayArea()
        {
            return Calculate();
        }
    }
}