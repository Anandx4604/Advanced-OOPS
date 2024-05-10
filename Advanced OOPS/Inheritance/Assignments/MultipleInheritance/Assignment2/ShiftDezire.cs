using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ShiftDezire : Car, IBrand
    {
        private static int s_makingID = 1000;
        public string MakingID { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public ShiftDezire(string fuelType, int numberOfSeats, string color, double tankCapacity, double numberOfKmDriven, string brandName, string modelName, string engineNumber, string chasisNumber) : base(fuelType, numberOfSeats, color, tankCapacity, numberOfKmDriven)
        {
            s_makingID++;
            MakingID = "MID" + s_makingID;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            BrandName = brandName;
            ModelName = modelName;
        }


        public string ShowDetails()
        {
            return $"|{BrandName} | {ModelName} | {MakingID} | {EngineNumber} | {ChasisNumber} | { FuelType} | {NumberOfSeats} | {Color} | {TankCapacity} | {NumberOfKmDriven} |";
        }
    }
}