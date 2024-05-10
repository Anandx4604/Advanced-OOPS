using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public static class FileHandling
    {
        public static void Create()
        {
            if (!Directory.Exists("CafeteriaManagement"))
            {
                System.Console.WriteLine("Creating Folder...");
                Directory.CreateDirectory("CafeteriaManagement");
            }
            //Creating file for PersonalDetails
            if(!File.Exists("UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("UserDetails.csv");
            }

             //Creating file for FoodDetails
            if(!File.Exists("FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("FoodDetails.csv");
            }

             //Creating file for OrderDetails
            if(!File.Exists("OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("OrderDetails.csv");
            }

             //Creating file for CartDetails
            if(!File.Exists("CartItemDetails.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("CartItemDetails.csv");
            }
            








        }
    }
}