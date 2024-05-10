using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace HotelManagement
{
    public enum BookingStatus{Default, Initiated, Booked, Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID = 100;
        public string BookingID { get; set; }
        public string UserID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string userID, double totalPrice,DateTime dateOfBooking, BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID = "BID" + s_bookingID;
            UserID = userID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }
        
    }
}