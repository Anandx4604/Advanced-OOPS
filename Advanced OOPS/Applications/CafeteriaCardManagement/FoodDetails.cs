using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class FoodDetails
    {
        //fields
        private static int s_foodID = 100;
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public double AvailableQuantity { get; set; }

        public FoodDetails(string foodName, double foodPrice, double availableQuantity)
        {
            s_foodID++;
            FoodID = "FID" + s_foodID;
            FoodName = foodName;
            FoodPrice = foodPrice;
            AvailableQuantity = availableQuantity;
        }
    }
}