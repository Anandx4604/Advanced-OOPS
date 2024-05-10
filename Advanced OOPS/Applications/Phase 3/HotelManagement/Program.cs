using System;
namespace HotelManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operations.AddDefaultdata();
            // FileHandling.Create();
            Operations.MainMenu();
        }
    }
}