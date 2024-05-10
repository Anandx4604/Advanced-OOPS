using System;
namespace DoctorAppointmentManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            AppointmentManager.AddDefaultData();
            AppointmentManager.MainMenu();
        }
    }
}