using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement
{
    public enum FoodType{Select,Veg,NonVeg}
    public enum Gender{Select,Male,Female,Transgender}
    public class PersonalDetails
    {
        public string UserName { get; set; }
        public long MobileNumber { get; set; }
        public long AadharNumber { get; set; }
        public string Address { get; set; }
        public FoodType FoodType { get; set; }
        public Gender PersonGender { get; set; }

        public PersonalDetails(string userName, long mobileNumber, long aadharNumber,string address,FoodType foodType,Gender personGender)
        {
            UserName = userName;
            MobileNumber = mobileNumber;
            AadharNumber = aadharNumber;
            Address = address;
            FoodType = foodType;
            PersonGender = personGender;
        }
    }
}