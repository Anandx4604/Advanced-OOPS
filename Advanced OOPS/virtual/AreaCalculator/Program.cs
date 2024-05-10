using System;
namespace AreaCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            AreaCalculator area = new AreaCalculator(5.7);
            area.Calculate();
            System.Console.WriteLine($"Area:{area.Display()}");
            VolumeCalculator volume = new VolumeCalculator(7.6,12.6);
            volume.Calculate();
            System.Console.WriteLine($"Volume:{volume.Display()}");

        }
    }
}