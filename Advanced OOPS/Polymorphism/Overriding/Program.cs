using System;
namespace Overriding
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pomerian pomerian = new Pomerian();
            System.Console.WriteLine(pomerian.Sound());

            Animal animal = new Pomerian();
            System.Console.WriteLine(animal.Sound());
        }
    }
}