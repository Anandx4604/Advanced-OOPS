using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointmentManagement
{
    public enum Gender { Select, Male, Female, Transgender }
    public class Patient
    {
        private static int s_patientID = 0;
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public int Age { get; set; }
        public Gender PatientGender { get; set; }
        public Patient(string name,string password, int age, Gender patientGender)
        {
            s_patientID++;
            PatientID = s_patientID;
            Password = password;
            Name = name;
            Age = age;
            PatientGender = patientGender;
        }
    }
}