using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public static class Operations
    {
        public static CustomList<PersonalDetails> userList = new CustomList<PersonalDetails>();
        public static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        public static CustomList<CartItem> cartItemsList = new CustomList<CartItem>();
        public static UserDetails CurrentLoginUser;

        public static void AddDefaultData()
        {
            System.Console.WriteLine("Adding Default data");
            System.Console.WriteLine("\nAdding Default User Details");
            UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", 8857777575, "ravi@gmail.com", Gender.Male, "WS101", 400);
            UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", 9577747744, "baskaran@gmail.com", Gender.Male, "WS105", 500);
            userList.Add(user1);
            userList.Add(user2);

            foreach (UserDetails user in userList)
            {
                System.Console.WriteLine($"|{user.UserID,-5} | {user.Name,-15} | {user.FatherName,-15} | {user.Mobile,-10} | {user.MailID,-20} | {user.PersonGender,-7} | {user.WorkstationNumber,-5} | {user.WalletBalance,-5} |");
            }
            System.Console.WriteLine("\nAdding Default Food Details");
            FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
            FoodDetails food2 = new FoodDetails("Tea", 15, 100);
            FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
            FoodDetails food4 = new FoodDetails("Juice", 50, 100);
            FoodDetails food5 = new FoodDetails("Puff", 40, 100);
            FoodDetails food6 = new FoodDetails("Milk", 10, 100);
            FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);
            foreach (FoodDetails food in foodList)
            {
                System.Console.WriteLine($"| {food.FoodID,-5} | {food.FoodName,-10} | {food.FoodPrice,-3} | {food.AvailableQuantity,-5} |");
            }

            System.Console.WriteLine("\nAdding Default Order Values... ");
            OrderDetails order1 = new OrderDetails("SF1001", new DateTime(2022, 06, 15), 70, OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("SF1002", new DateTime(2022, 06, 15), 100, OrderStatus.Ordered);
            orderList.Add(order1);
            orderList.Add(order2);

            foreach (OrderDetails order in orderList)
            {
                System.Console.WriteLine($"| {order.OrderID,-5} | {order.UserID,-5} | {order.OrderDate,-15:dd/MM/yyyy} | {order.TotalPrice,-5} | {order.OrderStatus,-10} |");
            }

            System.Console.WriteLine("\nAdding Default Cart Item Values... ");
            CartItem cart1 = new CartItem("OID1001", "FID101", 20, 1);
            CartItem cart2 = new CartItem("OID1001", "FID103", 10, 1);
            CartItem cart3 = new CartItem("OID1001", "FID105", 40, 1);
            CartItem cart4 = new CartItem("OID1002", "FID103", 10, 1);
            CartItem cart5 = new CartItem("OID1002", "FID104", 50, 1);
            CartItem cart6 = new CartItem("OID1002", "FID105", 40, 1);
            cartItemsList.Add(cart1);
            cartItemsList.Add(cart2);
            cartItemsList.Add(cart3);
            cartItemsList.Add(cart4);
            cartItemsList.Add(cart5);
            cartItemsList.Add(cart6);

            foreach (CartItem item in cartItemsList)
            {
                System.Console.WriteLine($"| {item.ItemID,-5} | {item.OrderID,-5} | {item.FoodID,-5} | {item.OrderPrice,-5} | {item.OrderQuantity,-5} |");
            }

        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Main Menu");
                System.Console.WriteLine("\n1.User Registration \n2.User Login \n3.Exit");
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
                            Login();
                            break;
                        }

                    case 3:
                        {
                            System.Console.WriteLine("Exiting the application...");
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void UserRegistration()
        {
            System.Console.WriteLine("----- User Registeration ------");
            System.Console.Write("Enter your Name:");
            string name = Console.ReadLine();
            System.Console.Write("Enter your Father name:");
            string fatherName = Console.ReadLine();
            System.Console.Write("Enter your Mobile Number:");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.Write("Enter your MailID:");
            string mailID = Console.ReadLine();
            System.Console.Write("Enter your Gender:");
            Gender personGender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.Write("Enter your Workstation Number:");
            string workstationNumber = Console.ReadLine();
            System.Console.Write("Enter your Balance:");
            double walletBalance = double.Parse(Console.ReadLine());
            UserDetails newUser = new UserDetails(name, fatherName, mobile, mailID, personGender, workstationNumber, walletBalance);
            userList.Add(newUser);
            System.Console.WriteLine($"You Have Registered Successfully! Your UserID:{newUser.UserID}");
        }
        public static void Login()
        {
            bool flag = true;
            System.Console.WriteLine("----- User Login ------");
            System.Console.Write("Enter your UserID:");
            string userID = Console.ReadLine().ToUpper();
            foreach (UserDetails user in userList)
            {
                if (userID == user.UserID)
                {
                    System.Console.WriteLine("Login Successful!");
                    CurrentLoginUser = user;
                    SubMenu();
                    flag = false;

                }

            }
            if (flag)
            {
                System.Console.WriteLine("Invalid UserID!");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("1.Show My Profile 2.Food Order 3.Modify Order 4.Cancel Order 5.Order History 6.Wallet Recharge 7.Show Wallet Balance 8.Exit");
                System.Console.Write("Select an option:(1/2/3/4/5/6/7/8):");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            ShowMyProfile();
                            break;
                        }

                    case 2:
                        {
                            FoodOrder();
                            break;
                        }

                    case 3:
                        {
                            ModifyOrder();
                            break;
                        }

                    case 4:
                        {
                            CancelOrder();
                            break;
                        }

                    case 5:
                        {
                            OrderHistory();
                            break;
                        }

                    case 6:
                        {
                            IsWalletRecharge();
                            break;
                        }

                    case 7:
                        {
                            ShoWalletBalance();
                            break;
                        }

                    case 8:
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
        public static void ShowMyProfile()
        {
            bool flag = true;
            System.Console.WriteLine("----- My Profile -----");
            foreach (UserDetails user in userList)
            {
                if (CurrentLoginUser.UserID == user.UserID)
                {
                    flag = false;
                    System.Console.WriteLine($"|{user.UserID,-5} | {user.Name,-15} | {user.FatherName,-15} | {user.Mobile,-10} | {user.MailID,-20} | {user.PersonGender,-7} | {user.WorkstationNumber,-5} | {user.WalletBalance,-5} |");
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Invalid UserID!");
            }
        }
        public static void FoodOrder()
        {
            bool foodIDFound = false;
            System.Console.WriteLine("----- Food Order -------");
            // 1.	Create a temporary local carItemtList.
            CustomList<CartItem> localCartList = new CustomList<CartItem>();
            // 2.	Create an Order object with current UserID, Order date as current DateTime, total price as 0, Order status as “Initiated”.
            OrderDetails order = new OrderDetails(CurrentLoginUser.UserID, DateTime.Now, 0, OrderStatus.Initiated);
            //displaying food details
            string option;
            double totalPrice = 0;
            do
            {
                foreach (FoodDetails food in foodList)
                {
                    System.Console.WriteLine($"| {food.FoodID,-5} | {food.FoodName,-10} | {food.FoodPrice,-3} | {food.AvailableQuantity,-5} |");
                }
                // 3.	Ask the user to pick a product using FoodID, quantity required and calculate price of food.
                System.Console.Write("Enter the FoodID:");
                string FoodID = Console.ReadLine().ToUpper();
                System.Console.Write("Enter its Quantity:");
                double quantity = double.Parse(Console.ReadLine());
                foreach (FoodDetails food1 in foodList)
                {
                    if (FoodID == food1.FoodID)
                    {
                        foodIDFound = true;
                        if (quantity <= food1.AvailableQuantity)
                        {
                            // 4.	If the food and quantity available, reduce the quantity from the food object’s “AvailableQuantity” then create CartItems object using the available data.
                            double price = food1.FoodPrice * quantity;
                            food1.AvailableQuantity -= quantity;
                            totalPrice += price;
                            // 5.	Add that object it to local CartItemsList to add it to cart wish list.
                            CartItem tempCart = new CartItem(order.OrderID, food1.FoodID, price, quantity);
                            cartItemsList.Add(tempCart);
                        }
                        else
                        {
                            System.Console.WriteLine("Unavailable Quantity Count, Enter available quantity!");
                        }
                    }
                }
                if (!foodIDFound)
                {
                    System.Console.WriteLine("Invalid FoodID!");
                }
                System.Console.WriteLine("Do you want to purchase again?(YES/NO)");
                option = Console.ReadLine().ToUpper();
            } while (option == "YES");
            // 6.	Ask the user whether he want to pick another product. 
            // 7.	If “Yes” then show the updated Food Details and repeat from step “3”.
            // 8.	Repeat the process until the user enters “No”.
            // 9.	If He says No then, 
            // 10.	Ask the user whether he confirm the wish list to purchase. If he says “No” then traverse the local CartItemList 
            // and get the Items one by one and reverse the quantity to the FoodItem’s objects in the foodList.
            System.Console.WriteLine("Do you confirm wishlist to purchase?(YES/NO)");
            string choice = Console.ReadLine().ToUpper();
            if (choice == "YES")
            {
                bool temp = false;

                // 11.	If he says “Yes” then, Calculate the total price of the food items selected using the local CartItemList information 
                // and check the balance from the user details whether it has sufficient balance to purchase.
                do
                {
                    if (totalPrice < CurrentLoginUser.WalletBalance)
                    {
                        temp = false;
                        // 12.	If he has enough balance, then deduct the respective amount from the user’s balance.            
                        // 13.	Append the local CartItemList to global CartItemList.
                        // 14.	Modify Order object created at step 1’s total price as total OrderPrice and OrderStatus as “Ordered”. 
                        // 15.	Then add the Order object to the Order list.
                        // 16.	Show “Order placed successfully, and OrderID is OID1001”.
                        cartItemsList.AddRange(localCartList);
                        order.OrderStatus = OrderStatus.Ordered;
                        order.TotalPrice = totalPrice;
                        CurrentLoginUser.DeductAmount(totalPrice);
                        orderList.Add(order);
                        System.Console.WriteLine("Order Purchased Successfully!");
                    }
                    // 17.	If he doesn’t have enough balance show “In sufficient balance to purchase.” Ask him “Are you willing to recharge.”
                    else
                    {
                        System.Console.WriteLine("In sufficient balance to purchase.");
                        System.Console.WriteLine("Do you Want to recharge?(YES/NO)");
                        string recharge = Console.ReadLine().ToUpper();
                        if (recharge == "YES")
                        {
                            // 19.	If he says “Yes”. Then ask him to Recharge with the total price of Order. 
                            // If he recharged with that amount means continue from step 12 to continue purchase. 
                            temp = true;
                            System.Console.Write("Enter the Amount to recharge:");
                            double amount = double.Parse(Console.ReadLine());
                            CurrentLoginUser.WalletRecharge(amount);
                            System.Console.WriteLine($"Current Balance:{CurrentLoginUser.WalletBalance}");
                        }
                        else
                        {
                            temp = false;
                            foreach (CartItem item in cartItemsList)
                            {
                                foreach (FoodDetails food2 in foodList)
                                {
                                    if (item.FoodID == food2.FoodID)
                                    {
                                        food2.AvailableQuantity += item.OrderQuantity;
                                        break;
                                    }
                                }
                            }
                        }


                    }
                } while (temp);
            }
            else
            {
                // 18.	 If he says “No” then show “Exiting without Order due to insufficient balance”. 
                // Then need to return the localCartList items to foodItemsList.
                foreach (CartItem item in cartItemsList)
                {
                    foreach (FoodDetails food2 in foodList)
                    {
                        if (item.FoodID == food2.FoodID)
                        {
                            food2.AvailableQuantity += item.OrderQuantity;
                            break;
                        }
                    }
                }
            }
        }
        public static void ModifyOrder()
        {
            bool orderNotFound = false;
            bool quantityAvail = true;
            System.Console.WriteLine("------ Modify Order ------");
            // 1.	Show the Order details of current logged in user to pick an Order detail by using OrderID 
            // and whose status is “Ordered”. Check whether the order details is present. If yes then,

            foreach (OrderDetails order in orderList)
            {
                if (CurrentLoginUser.UserID == order.UserID && order.OrderStatus == OrderStatus.Ordered)
                {
                    orderNotFound = true;
                    System.Console.WriteLine($"| {order.OrderID,-5} | {order.UserID,-5} | {order.OrderDate,-15:dd/MM/yyyy} | {order.TotalPrice,-5} | {order.OrderStatus,-10} |");
                }
            }
            if (!orderNotFound)
            {
                System.Console.WriteLine("You have no purchases!");
            }
            else
            {
                System.Console.Write("Enter the orderID you wish to Modify:");
                string orderID = Console.ReadLine().ToUpper();
                foreach (OrderDetails order in orderList)
                {
                    if (orderID == order.OrderID && order.OrderStatus == OrderStatus.Ordered)
                    {
                        // 2.	Show list of Cart Item details and ask the user to pick an Item id.
                        foreach (CartItem item in cartItemsList)
                        {
                            if (order.OrderID == item.OrderID)
                            {
                                System.Console.WriteLine($"| {item.ItemID,-5} | {item.OrderID,-5} | {item.FoodID,-5} | {item.OrderPrice,-5} | {item.OrderQuantity,-5} |");
                            }
                        }
                        System.Console.Write("Enter the ItemID to modify:");
                        string itemID = Console.ReadLine().ToUpper();
                        foreach (CartItem item in cartItemsList)
                        {

                            // 3.	Ensure the ItemID is available and ask the user to enter the new quantity of the food. 
                            // Calculate the Item price and update in the OrderPrice.
                            if (itemID == item.ItemID)
                            {
                                System.Console.Write("Enter new Quantity:");
                                double quantity = double.Parse(Console.ReadLine());
                                foreach (FoodDetails food3 in foodList)
                                {
                                    if (item.FoodID == food3.FoodID)
                                    {
                                        if (quantity <= food3.AvailableQuantity && food3.FoodID == item.FoodID)
                                        {
                                            quantityAvail = false;
                                            double itemPrice = food3.FoodPrice * quantity;
                                            // 4.	Calculate the total price of Items and update in Order details entry. 
                                            // 5.	Show Order modified successfully.
                                            double finalQuantityCheck = quantity - item.OrderQuantity;
                                            if (finalQuantityCheck == 0)
                                            {
                                                System.Console.WriteLine("Same Quantity Entered!");
                                            }
                                            else if (finalQuantityCheck < 0)
                                            {
                                                //reduce item count
                                                item.OrderQuantity += finalQuantityCheck;
                                                //calculate returning price
                                                double returnAmount = -finalQuantityCheck * food3.FoodPrice;

                                                //recharge to user
                                                CurrentLoginUser.WalletRecharge(returnAmount);
                                                //increase food item in stock count
                                                food3.AvailableQuantity += -finalQuantityCheck;
                                                System.Console.WriteLine("Order modified successfully!");

                                            }
                                            else
                                            {
                                                //calculating substracting price
                                                double returnAmount = finalQuantityCheck * food3.FoodPrice;
                                                if (CurrentLoginUser.WalletBalance > returnAmount)
                                                {
                                                    //increase item count
                                                    item.OrderQuantity += finalQuantityCheck;
                                                    CurrentLoginUser.DeductAmount(returnAmount);
                                                    food3.AvailableQuantity -= finalQuantityCheck;
                                                    System.Console.WriteLine("Order modified successfully!");

                                                }
                                                else
                                                {
                                                    System.Console.WriteLine("Insufficient Balance");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    }
                }
            }
            if (quantityAvail)
            {
                System.Console.WriteLine("Quantity not available");
            }
        }
        public static void CancelOrder()
        {
            bool flag = true;
            bool orderNotFound = true;
            System.Console.WriteLine("-------- Cancel Order ---------");

            foreach (OrderDetails orders in orderList)
            {
                // 1.    Show the Order details of the current user who’s Order status is “Ordered”.
                if (CurrentLoginUser.UserID == orders.UserID && orders.OrderStatus == OrderStatus.Ordered)
                {
                    flag = false;
                    System.Console.WriteLine($"| {orders.OrderID,-5} | {orders.UserID,-5} | {orders.OrderDate,-15:dd/MM/yyyy} | {orders.TotalPrice,-5} | {orders.OrderStatus,-10} |");
                }
            }
            // 2.    Ask the user to pick an OrderID to cancel.
            System.Console.Write("Select an Order to Cancel, Enter OrderID:");
            string orderID = Console.ReadLine().ToUpper();

            foreach (OrderDetails order in orderList)
            {
                // 3.    Check the OrderID is valid. 
                // 4.    If valid, then Return the Order total amount to current user. 
                if (orderID == order.OrderID)
                {
                    orderNotFound = false;
                    CurrentLoginUser.WalletRecharge(order.TotalPrice);
                    // 5.    Return product orderQuantity to Foodtem list’s FoodQuantity. 
                    foreach (CartItem cart in cartItemsList)
                    {
                        if (order.OrderID == cart.OrderID)
                        {
                            foreach (FoodDetails food in foodList)
                            {
                                if (cart.FoodID == food.FoodID)
                                {
                                    food.AvailableQuantity += cart.OrderQuantity;
                                    break;
                                }
                            }
                        }
                    }
                    // 6.Change the OrderStatus as Cancelled.
                    order.OrderStatus = OrderStatus.Cancelled;
                    System.Console.WriteLine("Order cancelled successfully!");
                    // 7. Show “Order cancelled successfully” and product returned to cart.
                }
            }
            if (flag)
            {
                System.Console.WriteLine("You have no purchases!");
            }
            // 4.If not, then show “Invalid OrderID”.
            if (orderNotFound)
            {
                System.Console.WriteLine("Invalid OrderID!");
            }


        }
        public static void OrderHistory()
        {
            System.Console.WriteLine(" ------  OrderHistory ----------");
            foreach (OrderDetails order in orderList)
            {
                if (CurrentLoginUser.UserID == order.UserID)
                {
                    System.Console.WriteLine($"| {order.OrderID,-5} | {order.UserID,-5} | {order.OrderDate,-15:dd/MM/yyyy} | {order.TotalPrice,-5} | {order.OrderStatus,-10} |");
                }
            }
        }
        public static void IsWalletRecharge()
        {
            bool flag = true;
            System.Console.WriteLine("------ Wallet Recharge ------");
            System.Console.WriteLine("Do you Want to Recharge?(Yes/No)");
            string option = Console.ReadLine().ToUpper();
            if (option == "YES")
            {
                flag = false;
                System.Console.Write("Enter the amount:");
                double amount = double.Parse(Console.ReadLine());
                CurrentLoginUser.WalletRecharge(amount);
                ShoWalletBalance();
            }
            if (flag)
            {
                SubMenu();
            }
        }
        public static void ShoWalletBalance()
        {
            System.Console.WriteLine("------ Wallet Balance ------");
            System.Console.WriteLine($"\nCurrent Balance: {CurrentLoginUser.WalletBalance}");
        }
    }
}




