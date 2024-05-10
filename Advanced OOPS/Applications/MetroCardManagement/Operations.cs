using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static class Operations
    {
        public static CustomList<UserDetails> userDetailsList = new CustomList<UserDetails>();
        public static CustomList<TravelDetails> travelDetailsList = new CustomList<TravelDetails>();
        public static CustomList<TicketFairDetails> ticketFairDetailsList = new CustomList<TicketFairDetails>();
        public static UserDetails currentLoginUser;

        public static void AddDefaultData()
        {
            System.Console.WriteLine("Adding Default Data...");
            System.Console.WriteLine("Adding User Default Data...");
            UserDetails user1 = new UserDetails("Ravi", 9848812345, 1000);
            UserDetails user2 = new UserDetails("Baskaran", 9948854321, 1000);
            userDetailsList.Add(user1);
            userDetailsList.Add(user2);
            foreach (UserDetails user in userDetailsList)
            {
                System.Console.WriteLine($"| {user.CardNumber,-10} | {user.UserName,-10} | {user.PhoneNumber,-10} | {user.Balance,-5} |");
            }

            System.Console.WriteLine("\nAdding Travel History Default Data...");
            TravelDetails travel1 = new TravelDetails("CMRL1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55);
            TravelDetails travel2 = new TravelDetails("CMRL1001", "Egmore", "Koyambedu", new DateTime(2023, 10, 10), 32);
            TravelDetails travel3 = new TravelDetails("CMRL1002", "Alandur", "Koyambedu", new DateTime(2023, 11, 10), 25);
            TravelDetails travel4 = new TravelDetails("CMRL1002", "Egmore", "Thirumangalam", new DateTime(2023, 11, 10), 25);
            travelDetailsList.Add(travel1);
            travelDetailsList.Add(travel2);
            travelDetailsList.Add(travel3);
            travelDetailsList.Add(travel4);
            foreach (TravelDetails travel in travelDetailsList)
            {
                System.Console.WriteLine($"| {travel.TravelID,-10} | {travel.CardNumber,-10} | {travel.FromLocation,-15} | {travel.ToLocation,-15} | {travel.Date:dd/MM/yyyy} | {travel.TravelCost,-5} |");
            }

            System.Console.WriteLine("\nAdding Ticket Fair Default Data...");
            TicketFairDetails fair1 = new TicketFairDetails("Airport", "Egmore", 55);
            TicketFairDetails fair2 = new TicketFairDetails("Airport", "Koyambedu", 25);
            TicketFairDetails fair3 = new TicketFairDetails("Alandur", "Koyambedu", 25);
            TicketFairDetails fair4 = new TicketFairDetails("Koyambedu", "Egmore", 32);
            TicketFairDetails fair5 = new TicketFairDetails("Vadapalani", "Egmore", 45);
            TicketFairDetails fair6 = new TicketFairDetails("Arumbakkam", "Egmore", 25);
            TicketFairDetails fair7 = new TicketFairDetails("Vadapalani", "Koyambedu", 25);
            TicketFairDetails fair8 = new TicketFairDetails("Arumbakkam", "Koyambedu", 16);
            ticketFairDetailsList.Add(fair1);
            ticketFairDetailsList.Add(fair2);
            ticketFairDetailsList.Add(fair3);
            ticketFairDetailsList.Add(fair4);
            ticketFairDetailsList.Add(fair5);
            ticketFairDetailsList.Add(fair6);
            ticketFairDetailsList.Add(fair7);
            ticketFairDetailsList.Add(fair8);
            foreach (TicketFairDetails fair in ticketFairDetailsList)
            {
                System.Console.WriteLine($"| {fair.TicketID,-10} | {fair.FromLocation,-10} | {fair.ToLocation,-10} |  {fair.TicketPrice,-5} |");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("\nMetro Card Management");
                System.Console.WriteLine("1.New User Registration \n2.User Login \n3.Exit");
                System.Console.Write("Select an option(1/2/3):");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            UserRegistration();
                            break;
                        }

                    case 2:
                        {
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exiting the application....");
                            flag = false;
                            break;
                        }
                }

            } while (flag);
        }
        public static void UserRegistration()
        {
            System.Console.WriteLine("----- User Registration ----");
            System.Console.Write("Enter your Name:");
            string userName = Console.ReadLine();
            System.Console.Write("Enter your Phone Number:");
            long phoneNumber = long.Parse(Console.ReadLine());
            System.Console.Write("Enter your Balance:");
            double balance = double.Parse(Console.ReadLine());
            UserDetails newUser = new UserDetails(userName, phoneNumber, balance);
            userDetailsList.Add(newUser);
            System.Console.WriteLine("You have succesfully Registered!");
            System.Console.WriteLine($"Your card number is : {newUser.CardNumber}");
        }
        public static void UserLogin()
        {
            System.Console.WriteLine("----- User Login ------");
            System.Console.Write("Enter your Card Number:");
            string cardNumber = Console.ReadLine().ToUpper();
            currentLoginUser = Search.CardNumberSearch(cardNumber);
            if (currentLoginUser != null)
            {
                System.Console.WriteLine("Login Successful!");
                SubMenu();
            }
            else
            {
                System.Console.WriteLine("The card number you entered is not a valid one!");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("\n----- Sub Menu -----");
                System.Console.WriteLine("1.Balance Check 2.Recharge 3.View Travel History 4.Travel 5.Exit");
                System.Console.Write("Selecct an option(1/2/3/4/5):");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            BalanceCheck();
                            break;
                        }
                    case 2:
                        {
                            Recharge();
                            break;
                        }
                    case 3:
                        {
                            ViewTravelHistory();
                            break;
                        }
                    case 4:
                        {
                            Travel();
                            break;
                        }
                    case 5:
                        {
                            System.Console.WriteLine("Exiting SubMenu...");
                            flag = false;
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Invalid Option!");
                            break;
                        }
                }
            } while (flag);
        }
        public static void BalanceCheck()
        {
            System.Console.WriteLine("----- Balance Check -----");
            System.Console.WriteLine($"Current Balance: {currentLoginUser.Balance}");
        }
        public static void Recharge()
        {
            System.Console.WriteLine("----- Recharge -----");
            System.Console.Write("Enter the amount:");
            double amount = double.Parse(Console.ReadLine());
            currentLoginUser.WalletRecharge(amount);
            System.Console.WriteLine($"Current Balance: {currentLoginUser.Balance}");

        }
        public static void ViewTravelHistory()
        {
            System.Console.WriteLine("----- Travel History -----");
            bool flag = true;
            // TravelDetails travelled = Search.TravelDetailsSearch(currentLoginUser.CardNumber);

            foreach (TravelDetails travel in travelDetailsList)
            {
                if (currentLoginUser.CardNumber == travel.CardNumber)
                {
                    flag = false;
                    System.Console.WriteLine($"| {travel.TravelID,-10} | {travel.CardNumber,-10} | {travel.FromLocation,-15} | {travel.ToLocation,-15} | {travel.Date:dd/MM/yyyy} | {travel.TravelCost,-5} |");
                }
            }

            if (flag)
            {
                System.Console.WriteLine("No Travel History Found!");
            }
        }
        public static void Travel()
        {
            bool flag = true;
            System.Console.WriteLine("----- Travel -----");

            System.Console.WriteLine("Ticket Fair Details:");
            // 1.	Show the Ticket fair details where the user wishes to travel by getting TicketID.
            foreach (TicketFairDetails fair in ticketFairDetailsList)
            {
                System.Console.WriteLine($"| {fair.TicketID,-10} | {fair.FromLocation,-10} | {fair.ToLocation,-10} |  {fair.TicketPrice,-5} |");
            }

            System.Console.WriteLine("Enter the TicketID you wish to travel:");
            string ticketID = Console.ReadLine().ToUpper();
            foreach (TicketFairDetails fair in ticketFairDetailsList)
            {
                // 2.	Check the ticketID is valid. Else show “Invalid user id”.
                if (ticketID == fair.TicketID)
                {
                    flag = false;
                    // 3.	IF ticket is valid then, Check the balance from the user object whether it has sufficient balance to travel.
                    // 4.	If “Yes” deduct the respective amount from the balance 
                    if (fair.TicketPrice <= currentLoginUser.Balance)
                    {
                        currentLoginUser.DeductBalance(fair.TicketPrice);
                        // and add the travel details like Card number, From and ToLocation, Travel Date, Travel cost, Travel ID (auto generation) in his travel history.
                        TravelDetails newTravel = new TravelDetails(currentLoginUser.CardNumber, fair.FromLocation, fair.ToLocation, DateTime.Today, fair.TicketPrice);
                        travelDetailsList.Add(newTravel);
                        System.Console.WriteLine("You have purchased the Ticket Successfully!");
                        break;
                    }
                    else
                    {
                        // 5.	If “No” ask him to recharge and go to the “Existing User Service” menu
                        System.Console.WriteLine("Insufficent Balance!");
                        System.Console.Write("Do you want to Recharge?(YES/NO):");
                        string recharge = Console.ReadLine().ToUpper();
                        if (recharge == "YES")
                        {
                            Recharge();
                        }
                        else
                        {
                            SubMenu();
                        }
                    }
                }
            }

            if (flag)
            {
                System.Console.WriteLine("Invalid TicketID!");
            }

        }
    }
}