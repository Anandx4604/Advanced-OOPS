using System;
namespace Virtual2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangleArea = new Rectangle(10.7,17.5,11.6,7.8);
            rectangleArea.Calculate();
            System.Console.WriteLine($"Rectangle Area:{rectangleArea.DisplayArea()}");

            Sphere sphereArea = new Sphere(8.9,8.6,7.5);
            sphereArea.Calculate();
            System.Console.WriteLine($"Sphere Area:{sphereArea.DisplayArea()}");
        }
    }
}