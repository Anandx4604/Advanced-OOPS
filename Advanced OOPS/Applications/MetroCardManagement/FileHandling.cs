using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static class FileHandling
    {
        public static void Create()
        {
            if (!Directory.Exists("MetroCardManagement"))
            {
                System.Console.WriteLine("Creating a Folder...");
                Directory.CreateDirectory("MetroCardManagement");
            }

            if (!File.Exists("MetroCardManagement/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("MetroCardManagement/UserDetails.csv").Close();
            }

            if (!File.Exists("MetroCardManagement/TravelDetails.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("MetroCardManagement/TravelDetails.csv").Close();
            }

            if (!File.Exists("MetroCardManagement/TicketFairDetails.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("MetroCardManagement/TicketFairDetails.csv").Close();
            }

        }
        public static void WritetoCSV()
        {
            //UserDetails
            string[] users = new string[Operations.userDetailsList.Count];
            for (int i = 0; i < Operations.userDetailsList.Count; i++)
            {
                users[i] = Operations.userDetailsList[i].CardNumber + "," + Operations.userDetailsList[i].UserName + "," + Operations.userDetailsList[i].PhoneNumber + "," + Operations.userDetailsList[i].Balance;
            }
            File.WriteAllLines("MetroCardManagement/UserDetails.csv", users);

            //Travel details
            string[] travels = new string[Operations.travelDetailsList.Count];
            for (int i = 0; i < Operations.travelDetailsList.Count; i++)
            {
                travels[i] = Operations.travelDetailsList[i].TravelID + "," + Operations.travelDetailsList[i].CardNumber + "," + Operations.travelDetailsList[i].FromLocation + "," + Operations.travelDetailsList[i].ToLocation + "," + Operations.travelDetailsList[i].Date.ToString("dd/MM/yyyy") + "," + Operations.travelDetailsList[i].TravelCost;
            }
            File.WriteAllLines("MetroCardManagement/TravelDetails.csv", travels);

            //Travel Fair details
            string[] fairs = new string[Operations.ticketFairDetailsList.Count];
            for (int i = 0; i < Operations.ticketFairDetailsList.Count; i++)
            {
                fairs[i] = Operations.ticketFairDetailsList[i].TicketID + "," + Operations.ticketFairDetailsList[i].FromLocation + "," + Operations.ticketFairDetailsList[i].ToLocation + "," + Operations.ticketFairDetailsList[i].TicketPrice;
            }
            File.WriteAllLines("MetroCardManagement/TicketFairDetails.csv", fairs);
        }

        public static void ReadFromCSV()
        {
            string[] users = File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            foreach (string user in users)
            {
                UserDetails newUser = new UserDetails(user);
                Operations.userDetailsList.Add(newUser);
            }

            string[] travels = File.ReadAllLines("MetroCardManagement/TravelDetails.csv");
            foreach (string travel in travels)
            {
                TravelDetails newTravel = new TravelDetails(travel);
                Operations.travelDetailsList.Add(newTravel);
            }

            string[] fairs = File.ReadAllLines("MetroCardManagement/TicketFairDetails.csv");
            foreach (string fair in fairs)
            {
                TicketFairDetails tickets = new TicketFairDetails(fair);
                Operations.ticketFairDetailsList.Add(tickets);
            }
        }
    }
}