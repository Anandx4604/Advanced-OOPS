using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class VolumeCalculator : AreaCalculator
    {
        public double Height { get; set; }
        public double VolumeArea{get;set;}
        public VolumeCalculator(double radius,double height) : base(radius)
        {
            Height = height;
        }

        public override void Calculate()
        {
            VolumeArea = Math.PI*Radius*Radius*Height;
        }

        public override double Display()
        {
            return VolumeArea;
        }
    }
}