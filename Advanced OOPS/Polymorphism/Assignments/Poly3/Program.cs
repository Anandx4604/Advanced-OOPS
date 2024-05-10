using System;
namespace MethodOverloading
{
    class Program
    {
        // Create a set of Multiply method inside a class
        public static void Main(string[] args)
        {
            // Call the above 5 methods and print the results.
            double result1 = Multiply(5);
            System.Console.WriteLine(result1);
            double result2 = Multiply(5,5);
            System.Console.WriteLine(result2);
            double result3 = Multiply(5,6,7);
            System.Console.WriteLine(result3);
            double result4 = Multiply(5.7,6);
            System.Console.WriteLine(result4);
            double result5 = Multiply(8,6.4,6.8f);
            System.Console.WriteLine(result5);


        }
        // Method with one argument and display the Multiply value of a given number.
        public static double Multiply(int number)
        {
            return number * number;
        }
        // Method with 2 arguments with same argument type and display result.
        public static double Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        // Method with 3 arguments with same argument type and display the result.
        public static double Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        // Method with 2 arguments with different argument type and display result.
        public static double Multiply(double number1, int number2)
        {
            return number1 * number2;
        }
        // Method with 3 arguments with different argument type and display the result.
        public static double Multiply(int number1, double number2, float number3)
        {
            return number1 * number2 * number3;
        }
    }
}