using System;
using System.Runtime.InteropServices;
namespace Overloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(Add(10,20));
            System.Console.WriteLine(Add(30,90,50));
            System.Console.WriteLine(Add("Anand",05));
            System.Console.WriteLine(Add(8.9,9));
            

        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        public static string Add(string string1, int number4)
        {
            return string1 + number4;
        }

        public static double Add(double number1, int number2)
        {
            return number1 + number2;
        }


    }
}
