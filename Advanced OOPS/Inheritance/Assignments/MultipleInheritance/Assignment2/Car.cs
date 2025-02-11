using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Car
    {
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public double TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }

        public Car(string fuelType, int numberOfSeats, string color, double tankCapacity,double numberOfKmDriven)
        {
            FuelType = fuelType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            TankCapacity = tankCapacity;
            NumberOfKmDriven = numberOfKmDriven;
        }

        public double CalculateMilage()
        {
            double milage = NumberOfKmDriven/TankCapacity;
            return milage;
        }
    }
}