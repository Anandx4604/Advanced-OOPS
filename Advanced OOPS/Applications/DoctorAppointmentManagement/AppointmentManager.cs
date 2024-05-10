using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;

namespace DoctorAppointmentManagement
{
    public static class AppointmentManager
    {
        static List<Doctor> doctorsList = new List<Doctor>();
        static List<Patient> patientsList = new List<Patient>();
        static List<Appointment> appointmentsList = new List<Appointment>();
        public static Patient currentLoginPatient;
        public static void AddDefaultData()
        {
            System.Console.WriteLine("Adding Default Data...");
            System.Console.WriteLine("Adding Default Doctors List:");
            Doctor doctor1 = new Doctor("Nancy", "Anaesthesiology");
            doctorsList.Add(doctor1);
            Doctor doctor2 = new Doctor("Andrew", "Cardiology");
            doctorsList.Add(doctor2);
            Doctor doctor3 = new Doctor("Janet", "Diabetology");
            doctorsList.Add(doctor3);
            Doctor doctor4 = new Doctor("Margaret", "Neonatology");
            doctorsList.Add(doctor4);
            Doctor doctor5 = new Doctor("Steven", "Nephrology");
            doctorsList.Add(doctor5);

            foreach (Doctor doctors in doctorsList)
            {
                System.Console.WriteLine($"| {doctors.DoctorID,-3} | {doctors.Name,-15} | {doctors.Department,-20} |");
            }

            System.Console.WriteLine("Adding Default Patients List:");
            Patient patient1 = new Patient("Robert", "welcome", 40, Gender.Male);
            patientsList.Add(patient1);
            Patient patient2 = new Patient("Laura", "welcome", 36, Gender.Female);
            patientsList.Add(patient2);
            Patient patient3 = new Patient("Anne", "welcome", 43, Gender.Male);
            patientsList.Add(patient3);

            foreach (Patient patients in patientsList)
            {
                System.Console.WriteLine($"| {patients.PatientID,-3} | {patients.Name,-10} | {patients.Password,-10} |  | {patients.Age,-3} | {patients.PatientGender,-10} |");
            }

            System.Console.WriteLine("Adding Default Appointment List:");
            Appointment appointment1 = new Appointment(1, 2, new DateTime(2012, 08, 03), "Heart problem");
            appointmentsList.Add(appointment1);
            Appointment appointment2 = new Appointment(1, 5, new DateTime(2012, 08, 03), "Spinal cord injury");
            appointmentsList.Add(appointment2);
            Appointment appointment3 = new Appointment(2, 2, new DateTime(2012, 08, 03), "Heart attack");
            appointmentsList.Add(appointment3);
            foreach (Appointment appointments in appointmentsList)
            {
                System.Console.WriteLine($"| {appointments.AppointmentID,-3} | {appointments.PatientID,-3} | {appointments.DoctorID,-3} | {appointments.Date:MM/dd/yyyy} | {appointments.Problem,-30} |");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("\nMainMenu");
                System.Console.WriteLine("\n1.Login \n2.Register \n3.Exit");
                System.Console.Write("Select an option(1/2):");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Login();
                            break;
                        }

                    case 2:
                        {
                            Register();
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
                            System.Console.WriteLine("invalid option!");
                            break;
                        }
                }
            } while (flag);
        }
        public static void Register()
        {
            System.Console.WriteLine("---- Patient Registration");
            System.Console.Write("Enter your Name:");
            string name = Console.ReadLine();
            System.Console.Write("Enter your Password:");
            string password = Console.ReadLine();
            System.Console.Write("Enter your Age:");
            int age = int.Parse(Console.ReadLine());
            System.Console.Write("Enter your Gender:");
            Gender patientGender = Enum.Parse<Gender>(Console.ReadLine(), true);

            Patient newPatient = new Patient(name, password, age, patientGender);
            patientsList.Add(newPatient);

            System.Console.WriteLine($"New Patient Registered! Your patientID:{newPatient.PatientID}");
        }
        public static void Login()
        {
            bool flag = true;
            System.Console.WriteLine("------ Patient Login -------");
            System.Console.Write("Enter your Name:");
            string checkName = Console.ReadLine();
            System.Console.Write("Enter your Password:");
            string checkPassword = Console.ReadLine();
            foreach (Patient patients in patientsList)
            {
                if (checkName == patients.Name && checkPassword == patients.Password)
                {
                    flag = false;
                    System.Console.WriteLine("Login Succesful!");
                    currentLoginPatient = patients;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Wrong Name and Password!");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("\n----- Sub Menu -----");
                System.Console.WriteLine("1.Book Appointment 2.View appointment 3.Edit My profile 4.Exit");
                System.Console.Write("Select an option:");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            BookAppointment();
                            break;
                        }

                    case 2:
                        {
                            ViewAppointmentDetails();
                            break;
                        }

                    case 3:
                        {
                            EditMyProfile();
                            break;
                        }

                    case 4:
                        {
                            System.Console.WriteLine("Exiting Sub Menu...");
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
        public static void BookAppointment()
        {
            bool flag = true;
            int count = 0;
            System.Console.WriteLine("------ Book Appointment ------");
            foreach (Doctor doctors in doctorsList)
            {
                System.Console.WriteLine(doctors.Department);
            }

            System.Console.Write("Select an Department:");
            string department = Console.ReadLine();
            foreach (Doctor doctors1 in doctorsList)
            {
                if (department == doctors1.Department)
                {
                    System.Console.Write("Enter your problem:");
                    string problem = Console.ReadLine();
                    flag = false;
                    System.Console.Write("Enter Date of appointment:(MM/dd/yyyy):");

                    DateTime appointmentDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);
                    if (appointmentDate >= DateTime.Today)
                    {
                        foreach (Appointment appointments in appointmentsList)
                        {
                            if (currentLoginPatient.PatientID == appointments.PatientID)
                            {
                                if (appointmentDate == appointments.Date && doctors1.DoctorID == appointments.DoctorID)
                                {
                                    count++;
                                }
                            }
                        }

                        if (count < 2)
                        {
                            System.Console.WriteLine($"Appointment is confirmed for the date - {appointmentDate}");
                            System.Console.Write("To book the appointment(Y/N):");
                            string bookingConfirmed = Console.ReadLine().ToUpper();
                            if (bookingConfirmed == "Y")
                            {
                                Appointment newAppointment = new Appointment(currentLoginPatient.PatientID, doctors1.DoctorID, appointmentDate, problem);
                                appointmentsList.Add(newAppointment);
                                System.Console.WriteLine("Booking confirmed!");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Appointments are already booked!");
                            break;
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid date!");
                    }
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Wrong Department name!");
            }
        }
        public static void ViewAppointmentDetails()
        {
            System.Console.WriteLine("------ ViewAppointments ------");
            foreach (Appointment appointments in appointmentsList)
            {
                if (currentLoginPatient.PatientID == appointments.PatientID)
                {
                    System.Console.WriteLine($"| {appointments.AppointmentID,-3} | {appointments.PatientID,-3} | {appointments.DoctorID,-3} | {appointments.Date:MM/dd/yyyy} | {appointments.Problem,-30} |");
                }
            }
        }
        public static void EditMyProfile()
        {
            System.Console.WriteLine("------ EditPatientProfile ----- ");
            System.Console.WriteLine("\n1.Name \n2.Password \n3.Age \n4.Gender");
            System.Console.Write("Select an option(1/2/3/4):");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        ChangeName();
                        break;
                    }

                case 2:
                    {
                        ChangePassword();
                        break;
                    }

                case 3:
                    {
                        ChangeAge();
                        break;
                    }
                case 4:
                    {
                        ChangeGender();
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid Otion!");
                        break;
                    }
            }
        }
        public static void ChangeName()
        {
            System.Console.WriteLine("---- Change Name ----");
            System.Console.Write("Enter new Name:");
            string newName = Console.ReadLine();
            foreach (Patient patients in patientsList)
            {
                if (currentLoginPatient.PatientID == patients.PatientID)
                {
                    currentLoginPatient.Name = newName;
                    System.Console.WriteLine($"Your changed Name:{patients.Name}");

                }
            }
        }
        public static void ChangePassword()
        {
            System.Console.WriteLine("----Change Password ----");
            System.Console.Write("Enter your new Password:");
            string newPassword = Console.ReadLine();
            foreach (Patient patients in patientsList)
            {
                if (currentLoginPatient.PatientID == patients.PatientID)
                {
                    currentLoginPatient.Password = newPassword;
                    System.Console.WriteLine($"Your changed Password:{patients.Password}");
                }
            }
        }
        public static void ChangeAge()
        {
            System.Console.WriteLine("----Change age ----");
            System.Console.Write("Enter your new Age:");
            int newAge = int.Parse(Console.ReadLine());
            foreach (Patient patients in patientsList)
            {
                if (currentLoginPatient.PatientID == patients.PatientID)
                {
                    currentLoginPatient.Age = newAge;
                    System.Console.WriteLine($"Your changed Age:{patients.Age}");

                }

            }
        }
        public static void ChangeGender()
        {
            System.Console.WriteLine("----Change Gender ----");
            System.Console.Write("Enter your new Gender:");
            Gender newGender = Enum.Parse<Gender>(Console.ReadLine(), true);
            foreach (Patient patients in patientsList)
            {
                if (currentLoginPatient.PatientID == patients.PatientID)
                {
                    currentLoginPatient.PatientGender = newGender;
                    System.Console.WriteLine($"Your changed Gender:{patients.PatientGender}");

                }

            }
        }
    }
}