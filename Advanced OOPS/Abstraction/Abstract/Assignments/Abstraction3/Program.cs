using System;
namespace Abstraction1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cylinders cyclinder = new Cylinders(7.8,10.5);
            System.Console.Write($"\nCylinder Area:{cyclinder.CalculateArea()}");
            System.Console.Write($"\nCyclinder Volume {cyclinder.CalculateVolume()}");

            Cubes cubes = new Cubes(8);
            System.Console.Write($"\nCube Area:{cubes.CalculateArea()}");
            System.Console.WriteLine($"\nCube Volume:{cubes.CalculateVolume()}");
        }
    }
}