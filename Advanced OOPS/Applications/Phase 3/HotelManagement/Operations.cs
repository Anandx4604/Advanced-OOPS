using System;
using System.Collections.Generic;

namespace HotelManagement
{
    public static class Operations
    {
        public static CustomList<UserRegistration> userList = new CustomList<UserRegistration>();
        public static CustomList<RoomDetails> roomDetailslist = new CustomList<RoomDetails>();
        public static CustomList<RoomSelection> roomSelectionsList = new CustomList<RoomSelection>();
        public static CustomList<BookingDetails> bookingDetailsList = new CustomList<BookingDetails>();
        public static UserRegistration currentLoginUser;
        public static void AddDefaultdata()
        {
            System.Console.WriteLine("Adding Default Data...");
            System.Console.WriteLine("\nAdding User default data...");
            UserRegistration user1 = new UserRegistration("Ravichandran", 995875777, 347777378383, "Chennai", FoodType.Veg, Gender.Male, 5000);
            UserRegistration user2 = new UserRegistration("Baskaran", 448844848, 474777477477, "Chennai", FoodType.NonVeg, Gender.Male, 6000);
            userList.Add(user1);
            userList.Add(user2);
            foreach (UserRegistration user in userList)
            {
                System.Console.WriteLine($"| {user.UserID,-5} | {user.UserName,-15} | {user.MobileNumber,-15} | {user.AadharNumber,-20} | {user.Address,-10} | {user.FoodType,-10} | {user.PersonGender,-10} | {user.WalletBalance,-7}");
            }

            System.Console.WriteLine("\nAdding Room Details default data...");
            RoomDetails room1 = new RoomDetails(RoomType.Standard, 2, 500);
            RoomDetails room2 = new RoomDetails(RoomType.Standard, 4, 700);
            RoomDetails room3 = new RoomDetails(RoomType.Standard, 2, 500);
            RoomDetails room4 = new RoomDetails(RoomType.Standard, 2, 500);
            RoomDetails room5 = new RoomDetails(RoomType.Standard, 2, 500);
            RoomDetails room6 = new RoomDetails(RoomType.Delux, 2, 1000);
            RoomDetails room7 = new RoomDetails(RoomType.Delux, 2, 1000);
            RoomDetails room8 = new RoomDetails(RoomType.Delux, 4, 1400);
            RoomDetails room9 = new RoomDetails(RoomType.Delux, 4, 1400);
            RoomDetails room10 = new RoomDetails(RoomType.Suit, 2, 2000);
            RoomDetails room11 = new RoomDetails(RoomType.Suit, 2, 2000);
            RoomDetails room12 = new RoomDetails(RoomType.Suit, 2, 2000);
            RoomDetails room13 = new RoomDetails(RoomType.Suit, 4, 2500);
            roomDetailslist.Add(room1);
            roomDetailslist.Add(room2);
            roomDetailslist.Add(room3);
            roomDetailslist.Add(room4);
            roomDetailslist.Add(room5);
            roomDetailslist.Add(room6);
            roomDetailslist.Add(room7);
            roomDetailslist.Add(room8);
            roomDetailslist.Add(room9);
            roomDetailslist.Add(room10);
            roomDetailslist.Add(room11);
            roomDetailslist.Add(room12);
            roomDetailslist.Add(room13);
            foreach (RoomDetails room in roomDetailslist)
            {
                System.Console.WriteLine($"| {room.RoomID,-5} | {room.RoomType,-12} | {room.NumberOfBeds,-5} | {room.PricePerDay,-5} |");
            }

            System.Console.WriteLine("\nAdding Selection Details default data...");
            RoomSelection select1 = new RoomSelection("BID101", "RID101", new DateTime(2022, 11, 11, 06, 00, 00), new DateTime(2022, 11, 12, 14, 00, 00, DateTimeKind.Utc), 750, 1.5, BookingStatus.Booked);
            RoomSelection select2 = new RoomSelection("BID101", "RID102", new DateTime(2022, 11, 11, 10, 00, 00), new DateTime(2022, 11, 12, 9, 00, 00, DateTimeKind.Local), 700, 1, BookingStatus.Booked);
            RoomSelection select3 = new RoomSelection("BID102", "RID103", new DateTime(2022, 11, 12, 09, 00, 00), new DateTime(2022, 11, 13, 9, 00, 00, DateTimeKind.Local), 500, 1, BookingStatus.Cancelled);
            RoomSelection select4 = new RoomSelection("BID102", "RID106", new DateTime(2022, 11, 12, 06, 00, 00), new DateTime(2022, 11, 13, 12, 30, 00, DateTimeKind.Local), 1500, 1.5, BookingStatus.Cancelled);
            roomSelectionsList.Add(select1);
            roomSelectionsList.Add(select2);
            roomSelectionsList.Add(select3);
            roomSelectionsList.Add(select4);
            foreach (RoomSelection select in roomSelectionsList)
            {
                System.Console.WriteLine($"| {select.SelectionID,-5} | {select.BookingID,-5} | {select.RoomID,-5} | {select.StayingDateFrom,-25:dd/MM/yyyy hh:mm tt} | {select.StayingDateTo,-25:dd/MM/yyyy hh:mm tt} | {select.Price,-10} | {select.NumberOfDays,-5} | {select.BookingStatus,-15}");
            }

            System.Console.WriteLine("\nAdding Booking Details default data...");

            BookingDetails booked1 = new BookingDetails("SF1001", 1450, new DateTime(2022, 11, 10), BookingStatus.Booked);
            BookingDetails booked2 = new BookingDetails("SF1002", 2000, new DateTime(2022, 11, 10), BookingStatus.Cancelled);
            bookingDetailsList.Add(booked1);
            bookingDetailsList.Add(booked2);

            foreach (BookingDetails book in bookingDetailsList)
            {
                System.Console.WriteLine($"| {book.BookingID,-5} | {book.UserID,-5} | {book.TotalPrice,-7} | {book.DateOfBooking,-15:dd/MM/yyyy} | {book.BookingStatus,-15} |");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("\nMain Menu");
                System.Console.WriteLine("1.User Registration \n2.UserLogin \n3.Exit");
                System.Console.Write("Select an option(1/2/3):");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }

                    case 2:
                        {
                            Login();
                            break;
                        }

                    case 3:
                        {
                            System.Console.WriteLine("Exiting the application...");
                            flag = false;
                            break;

                        }
                    default:
                        {
                            System.Console.WriteLine("Invalid option!");
                            break;
                        }
                }
            } while (flag);
        }
        public static void Registration()
        {
            System.Console.WriteLine("\n----- User Registration ------");
            System.Console.Write("Enter your Name:");
            string userName = Console.ReadLine();
            System.Console.Write("Enter your Mobile Number:");
            long mobileNumber = long.Parse(Console.ReadLine());
            System.Console.Write("Enter your Aadhar number:");
            long aadharNumber = long.Parse(Console.ReadLine());
            System.Console.Write("Enter your Address:");
            string address = Console.ReadLine();
            System.Console.Write("Enter your Food Type:");
            FoodType foodType = Enum.Parse<FoodType>(Console.ReadLine(), true);
            System.Console.Write("Enter You Gender:");
            Gender personGender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.Write("Enter your Wallet Balance:");
            double walletBalance = double.Parse(Console.ReadLine());
            UserRegistration newUser = new UserRegistration(userName, mobileNumber, aadharNumber, address, foodType, personGender, walletBalance);
            userList.Add(newUser);
            System.Console.WriteLine($"Successfully Regisgtered! Your UserID:{newUser.UserID}");

        }
        public static void Login()
        {
            bool flag = true;
            System.Console.WriteLine("\n------ User Login ------");
            System.Console.Write("Enter your UserID:");
            string userID = Console.ReadLine().ToUpper();
            foreach (UserRegistration user in userList)
            {
                if (userID == user.UserID)
                {
                    flag = false;
                    System.Console.WriteLine("Login Successful!");
                    currentLoginUser = user;
                    SubMenu();
                }
            }

            if (flag)
            {
                System.Console.WriteLine("Invalid UserID! Please enter a valid one!");
            }

        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("\n----- Sub Menu -----");
                System.Console.WriteLine("1.View Customer Profile 2.Book Room 3.Modify Booking 4.Cancel Booking 5.Booking History 6.Wallet Recharge 7.Show WalletBalance 8.Exit");
                System.Console.Write("Select an option(1/2/3/4/5/6/7/8):");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            ViewCustomerProfile();
                            break;
                        }
                    case 2:
                        {
                            BookRoom();
                            break;
                        }
                    case 3:
                        {
                            ModifyBooking();
                            break;
                        }
                    case 4:
                        {
                            CancelBooking();
                            break;
                        }
                    case 5:
                        {
                            BookingHistory();
                            break;
                        }

                    case 6:
                        {
                            IsWalletRecharge();
                            break;
                        }
                    case 7:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            System.Console.WriteLine("Exiting Sub Menu....");
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
        public static void ViewCustomerProfile()
        {
            System.Console.WriteLine("\n----- Customer Profile -----");
            foreach (UserRegistration user in userList)
            {
                if (currentLoginUser.UserID == user.UserID)
                {
                    System.Console.WriteLine($"| {user.UserID,-5} | {user.UserName,-15} | {user.MobileNumber,-15} | {user.AadharNumber,-20} | {user.Address,-10} | {user.FoodType,-10} | {user.PersonGender,-10} | {user.WalletBalance,-7}");
                }
            }
        }
        public static void BookRoom()
        {
            bool flag = true;
            bool flag1 = true;
            System.Console.WriteLine("\n----- Book Room -----");
            // 1.Create temporary booking object whose UserID is currentUserID, TotalAmount 0, Bookingdate Now, Status as initiated.
            // 2.Create temporary local room selection list to hold the room selection objects up to booking completion.
            BookingDetails tempBooking = new BookingDetails(currentLoginUser.UserID, 0, DateTime.Now, BookingStatus.Initiated);
            CustomList<RoomSelection> tempRoomSelectList = new CustomList<RoomSelection>();
            while (flag)
            {
                // 3.Need to show the list of available room types by traversing the Room Details list.
                System.Console.WriteLine("\nAvailable Room Details List");
                foreach (RoomDetails room in roomDetailslist)
                {
                    System.Console.WriteLine($"| {room.RoomID,-5} | {room.RoomType,-12} | {room.NumberOfBeds,-5} | {room.PricePerDay,-5} |");

                    // 4.Need to ask the user to enter DateFrom (Date and Time) and DateTo (Date and Time), RoomID & no. Of Days of booking.
                    System.Console.Write("Enter DateFrom:");
                    DateTime stayingFromDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm tt", null);
                    System.Console.Write("Enter DateTo:");
                    DateTime stayingToDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm tt", null);
                    System.Console.Write("Enter RoomID;");
                    string roomID = Console.ReadLine();
                    System.Console.Write("Enter Number of Days of Booking:");
                    double numberOfDays = double.Parse(Console.ReadLine());
                    // 5.Based on the data need to check the room is already booked or not by traversing room selection list. 
                    // 5 a)If it is not booked means Create Room Selection object and add it to local room selection list.
                    // bool flag = true;
                    foreach (RoomSelection select in roomSelectionsList)
                    {
                        if (roomID == select.RoomID)
                        {
                            // flag = false;
                            //checking if Staying Date is over with datetime.Now
                            if (stayingFromDate < select.StayingDateTo && select.BookingStatus != BookingStatus.Booked)
                            {
                                RoomSelection newTempRoomSelection = new RoomSelection(stayingFromDate, stayingToDate, room.PricePerDay, numberOfDays, BookingStatus.Initiated);
                                tempRoomSelectList.Add(newTempRoomSelection);
                            }

                        }
                        else
                        {
                            System.Console.WriteLine("Wrong BookID!");
                            break;
                        }
                    }
                    // 6.Ask the user whether he want to book another room.
                    // 6 b)If “yes” means repeat step 3 to 5 to create new selection object 
                    // 6 c)and add it to local list.
                    System.Console.Write("Do you wish to buy Another Room?(YES/NO)");
                    string anotherRoom = Console.ReadLine().ToUpper();
                    if (anotherRoom == "YES")
                    {
                        flag = true;
                    }
                    else
                    {
                        double totalPrice = 0;
                        double totalroomPrice;
                        flag = false;
                        // calculating totalprice of selected rooms
                        foreach (RoomSelection rooms in tempRoomSelectList)
                        {
                            if (rooms.RoomID == room.RoomID)
                            {
                                totalroomPrice = room.PricePerDay * numberOfDays;
                                totalPrice += totalroomPrice;
                            }
                        }
                        // 7.If user says “No” means calculate the total rent amount of that selected rooms 
                        // modify the booking object details and status as booked. 
                        tempBooking = new BookingDetails(currentLoginUser.UserID, totalPrice, DateTime.Now, BookingStatus.Booked);
                        // 8.Check the user has enough balance. 
                        // 8 a)If he has enough balance Add the local temp room selection to global list. 
                        // 8 b)Add the booking object to booking list. And show rooms successfully booked Your booking ID – BID101.
                        while (flag1)
                        {
                            if (totalPrice <= currentLoginUser.WalletBalance)
                            {
                                currentLoginUser.DeductBalance(totalPrice);
                                roomSelectionsList.AddRange(tempRoomSelectList);
                                bookingDetailsList.Add(tempBooking);
                                System.Console.WriteLine($"Rooms are successfully booked! Your booking ID:{tempBooking.BookingID}");
                            }
                            else
                            {
                                // 9.If user don’t have enough balance, ask the user whether he want to proceed booking after recharge. 
                                System.Console.WriteLine("InSufficient balance!");
                                System.Console.WriteLine("Do you want to recharge?(YES/NO)");
                                string recharge = Console.ReadLine().ToUpper();
                                // 10.If he says yes means show the amount to be recharged for continue booking (Total Booking Amount). 
                                // 10 a) Recharge with user provided amount and go to step 8 to proceed booking.
                                if (recharge == "YES")
                                {
                                    System.Console.WriteLine($"Total amount to be recharged:{totalPrice}");
                                    System.Console.Write("Enter the amount to recharge:");
                                    double amount = double.Parse(Console.ReadLine());
                                    currentLoginUser.WalletRecharge(amount);
                                    System.Console.WriteLine("Recharged Successfully!");
                                    flag1 = true;
                                }
                                else
                                {
                                    // 9 a)If he says no then Show Exiting without booking rooms.
                                    flag1 = false;
                                    break;

                                }

                            }

                        }

                    }
                }

            }
        }
        public static void ModifyBooking()
        {
            double totalPrice;
            System.Console.WriteLine("\n------- Modify booking ------");
            // Need to show the current user’s booking history whose booking status is Booked by traversing the booking details list 
            foreach (BookingDetails book in bookingDetailsList)
            {
                if (currentLoginUser.UserID == book.UserID && book.BookingStatus == BookingStatus.Booked)
                {
                    System.Console.WriteLine($"| {book.BookingID,-5} | {book.UserID,-5} | {book.TotalPrice,-7} | {book.DateOfBooking,-15:dd/MM/yyyy} | {book.BookingStatus,-15} |");
                }
            }
            // and need to ask the user to pick a bookingID. 
            System.Console.WriteLine("Enter a BookID to modify:");
            string bookingID = Console.ReadLine().ToUpper();
            foreach (BookingDetails book1 in bookingDetailsList)
            {
                // •Check whether the booking ID present in booking details and its status is Booked.
                if (bookingID == book1.BookingID && book1.BookingStatus == BookingStatus.Booked)
                {
                    // •Traverse the selection list and check the Booking ID present in selection list and the selection status is Booked.
                    foreach (RoomSelection select in roomSelectionsList)
                    {
                        if (bookingID == select.BookingID && select.BookingStatus == BookingStatus.Booked)
                        {
                            // •Show the selection list details of that booking ID and ask the user to enter selection ID.
                            System.Console.WriteLine($"| {select.SelectionID,-5} | {select.BookingID,-5} | {select.RoomID,-5} | {select.StayingDateFrom,-25:dd/MM/yyyy hh:mm tt} | {select.StayingDateTo,-25:dd/MM/yyyy hh:mm tt} | {select.Price,-10} | {select.NumberOfDays,-5} | {select.BookingStatus,-15}");
                        }
                        System.Console.Write("Enter SelectionID to modify:");
                        string selectionID = Console.ReadLine();

                        // •Validate the selection ID present in the selection list and its belong to current user and current booking ID.
                        // •Ask the user to select option
                        // 1.Cancel selected room
                        // 2.Add new room
                        if (selectionID == select.SelectionID && currentLoginUser.UserID == book1.UserID && bookingID == book1.BookingID)
                        {
                            System.Console.WriteLine("\n1.Cancel selected room \n2.Add new room");
                            int option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    {
                                        // If the user selects 
                                        // i.	Cancel selected room 
                                        // 1.	If the user enter this option means return the selected room amount to user, deduct the amount from booking 
                                        // and change the status of selection entry to Cancelled.
                                        // 2.	Show “Selected room cancelled from your booking”.
                                        totalPrice = select.Price * select.NumberOfDays;
                                        currentLoginUser.WalletRecharge(totalPrice);
                                        book1.TotalPrice -= totalPrice;
                                        select.BookingStatus = BookingStatus.Cancelled;
                                        break;
                                    }
                                
                                case 2:
                                {

                                    
                                    break;
                                }
                            }

                        }
                    }
                }
            }
        }

        // ii.	Add new room
        // 1.	Show the list of available rooms in from the room details and ask the user to enter room ID and check in and out date and time.
        // 2.	Ask the user to enter number of days room is required.
        // 3.	Check the selected room is available on that date and time by checking in the room selection list.
        // 4.	If the room is available means then calculate amount.
        // 5.	Check the user has enough balance. If he has means deduct the amount from user.
        // 6.	Add the amount to booking details.
        // 7.	Create selection object based on provided details and its status as Booked and add to the booking list.
        // 8.	Show “Booking modified successfully”.
        // 9.	If he don’t have enough balance means show “Please recharge {Rs. The above selected amount} before adding new room”.

    public static void CancelBooking()
    {
        // bool flag = true;
        System.Console.WriteLine("\n---- Cancel booking");
        //1.Need to show the current user’s booking history whose booking status is Booked by traversing the booking details list 
        //1 a)and need to ask the user to pick a bookingID. 

        //3.Change the booking status of selection list details of that corresponding bookingID from Booked to cancelled.
        foreach (BookingDetails book in bookingDetailsList)
        {
            if (currentLoginUser.UserID == book.UserID)
            {
                System.Console.WriteLine($"| {book.BookingID,-5} | {book.UserID,-5} | {book.TotalPrice,-7} | {book.DateOfBooking,-15:dd/MM/yyyy} | {book.BookingStatus,-15} |");
            }

        }
        foreach (BookingDetails book1 in bookingDetailsList)
        {
            System.Console.Write("Enter a BookingID to cancel:");
            string bookingID = Console.ReadLine().ToUpper();
            //2.Need to validate the id is present and need to change the status of booking to Cancelled 
            // 2 a) and return the booking amount to current user’s wallet.
            if (bookingID == book1.BookingID)
            {
                // flag = false;
                book1.BookingStatus = BookingStatus.Cancelled;
                currentLoginUser.WalletRecharge(book1.TotalPrice);

                foreach (RoomSelection select in roomSelectionsList)
                {
                    if (bookingID == select.BookingID)
                    {
                        select.BookingStatus = BookingStatus.Cancelled;
                        break;
                    }
                }

            }
            else
            {
                System.Console.WriteLine("invalid bookID");
                break;
            }
        }


    }
    public static void BookingHistory()
    {
        bool flag = true;
        System.Console.WriteLine("\n----- Booking History -----");
        foreach (BookingDetails book in bookingDetailsList)
        {
            if (currentLoginUser.UserID == book.UserID)
            {
                flag = false;
                System.Console.WriteLine($"| {book.BookingID,-5} | {book.UserID,-5} | {book.TotalPrice,-7} | {book.DateOfBooking,-15:dd/MM/yyyy} | {book.BookingStatus,-15} |");

                System.Console.Write("\nEnter a BookingID:");
                string bookingID = Console.ReadLine().ToUpper();
                foreach (RoomSelection select in roomSelectionsList)
                {
                    if (bookingID == select.BookingID)
                    {
                        System.Console.WriteLine($"| {select.SelectionID,-5} | {select.BookingID,-5} | {select.RoomID,-5} | {select.StayingDateFrom,-25:dd/MM/yyyy hh:mm tt} | {select.StayingDateTo,-25:dd/MM/yyyy hh:mm tt} | {select.Price,-10} | {select.NumberOfDays,-5} | {select.BookingStatus,-15}");
                    }
                    else
                    {
                        System.Console.WriteLine("Wrong BookID!");
                        break;
                    }
                }
            }
        }
        if (flag)
        {
            System.Console.WriteLine("You have no Booking History!");
        }
    }
    public static void IsWalletRecharge()
    {
        System.Console.WriteLine("\n----- Wallet recharge");
        System.Console.Write("Do you want to Recharge?(YES/NO)");
        string recharge = Console.ReadLine().ToUpper();
        if (recharge == "YES")
        {
            System.Console.Write("Enter the amount to recharge:");
            double amount = double.Parse(Console.ReadLine());
            currentLoginUser.WalletRecharge(amount);
            System.Console.WriteLine("Recharged Successfully!");
            ShowWalletBalance();
        }
        else
        {
            SubMenu();
        }

    }
    public static void ShowWalletBalance()
    {
        System.Console.WriteLine("\n----- Wallet Balance ------");
        System.Console.WriteLine($"Current Wallet Balance:{currentLoginUser.WalletBalance}");
    }
}
}