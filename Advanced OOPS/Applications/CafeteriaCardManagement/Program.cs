using System;
namespace CafeteriaCardManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operations.AddDefaultData();
            FileHandling.Create();
            Operations.MainMenu();
        }
    }
}