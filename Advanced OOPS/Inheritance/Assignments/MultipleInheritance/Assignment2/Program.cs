using System;
namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShiftDezire car1 = new ShiftDezire("Diesel", 4, "Red", 40, 5000, "Nissan", "DES1078", "E3008", "C7990");
            System.Console.WriteLine($"Car Milage: {car1.CalculateMilage()}");
            System.Console.WriteLine(car1.ShowDetails());

            Eco car2 = new Eco("Petrol", 5, "Blue", 60, 8000, "Tata", "ECO1078", "E4008", "C9990");
            System.Console.WriteLine($"Car Milage: {car2.CalculateMilage()}");
            System.Console.WriteLine(car2.ShowDetails());


        }
    }
}