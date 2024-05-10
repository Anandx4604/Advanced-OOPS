using System;
using System.Collections.Generic;
using System.IO;

namespace HotelManagement
{
    public static class FileHandling
    {
        public static void Create()
        {
            if (!Directory.Exists("HotelManageMent"))
            {
                System.Console.WriteLine("Creating a Folder...");
                Directory.CreateDirectory("HotelManageMent");
            }

            if (!File.Exists("HotelManageMent/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating a File...");
                File.Create("HotelManageMent/UserDetails.csv").Close();
            }

             if (!File.Exists("HotelManageMent/RoomDetails.csv"))
            {
                System.Console.WriteLine("Creating a File...");
                File.Create("HotelManageMent/RoomDetails.csv").Close();
            }

            if (!File.Exists("HotelManageMent/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating a File...");
                File.Create("HotelManageMent/BookingDetails.csv").Close();
            }

            if (!File.Exists("HotelManageMent/SelectionDetails.csv"))
            {
                System.Console.WriteLine("Creating a File...");
                File.Create("HotelManageMent/SelectionDetails.csv").Close();
            }

        }

        // public static void WritetoCSV()
        // {
        //     string[] users = new string[Operations.userList]
        // }
    }
}