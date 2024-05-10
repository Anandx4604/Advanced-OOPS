using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Runtime.CompilerServices;
namespace CSVReadAndWrite;
class Program
{
    public static void Main(string[] args)
    {
        if (!Directory.Exists("TestFolder"))
        {
            System.Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            System.Console.WriteLine("Directory already exists!");
        }

        if (!File.Exists("TestFolder/Data.csv"))
        {
            System.Console.WriteLine("Creating CSV File...");
            File.Create("TestFolder/Data.csv").Close();
        }
        else
        {
            System.Console.WriteLine("CSV File already exists!");
        }

        //JSON file creation
        if (!File.Exists("TestFolder/Data1.json"))
        {
            System.Console.WriteLine("Creating JSON File...");
            File.Create("TestFolder/Data1.json").Close();
        }
        else
        {
            System.Console.WriteLine("JSON File already exists!");
        }
        List<Student> studentList = new List<Student>();
        studentList.Add(new Student() { Name = "Anand", FatherName = "Aruldoss", DOB = new DateTime(2000, 11, 05), StudentGender = Gender.Male, TotalMark = 467 });
        studentList.Add(new Student() { Name = "Ravi", FatherName = "Chandran", DOB = new DateTime(1999, 11, 11), StudentGender = Gender.Male, TotalMark = 490 });
        studentList.Add(new Student() { Name = "Dhanush", FatherName = "SivaKumar", DOB = new DateTime(2001, 09, 21), StudentGender = Gender.Male, TotalMark = 420 });
        WriteToCSV(studentList);
        ReadCSV();
        WriteToJSON(studentList);
        ReadJSON();
    }
    static void WriteToCSV(List<Student> studentList)
    {
        StreamWriter sw = new StreamWriter("TestFolder/Data.csv");
        foreach (Student student in studentList)
        {
            string line = student.Name + "," + student.FatherName + "," + student.DOB.ToString("dd/MM/yyyy") + "," + student.StudentGender + "," + student.TotalMark;
            sw.WriteLine(line);
        }
        sw.Close();
    }

    static void ReadCSV()
    {
        System.Console.WriteLine("\nReading CSV file...");
        List<Student> newList = new List<Student>();
        StreamReader sr = new StreamReader("TestFolder/Data.csv");
        string line = sr.ReadLine();
        while (line != null)
        {
            string[] values = line.Split(",");
            if (values[0] != "")
            {
                Student student = new Student()
                {
                    Name = values[0],
                    FatherName = values[1],
                    DOB = DateTime.ParseExact(values[2], "dd/MM/yyyy", null),
                    StudentGender = Enum.Parse<Gender>(values[3]),
                    TotalMark = int.Parse(values[4])
                };
                newList.Add(student);
            }
            line = sr.ReadLine();
        }
        sr.Close();
        foreach (Student student in newList)
        {
            System.Console.WriteLine($"Name:{student.Name} FatherName:{student.FatherName} DOB:{student.DOB:dd/MM/yyyy} Gender:{student.StudentGender} Mark:{student.TotalMark}");
        }

    }

    //Reading and writing JSON file
    static void WriteToJSON(List<Student> studentlist)
    {
        StreamWriter sw = new StreamWriter("TestFolder/Data1.json");
        var option = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonData = JsonSerializer.Serialize(studentlist, option);
        sw.WriteLine(jsonData);
        sw.Close();
    }

    static void ReadJSON()
    {
        //no need for stream Reader
        List<Student> students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("TestFolder/Data1.json"));
        System.Console.WriteLine("\nReading JSON file...");
        foreach (Student student in students)
        {
            System.Console.WriteLine($"Name:{student.Name} FatherName:{student.FatherName} DOB:{student.DOB:dd/MM/yyyy} Gender:{student.StudentGender} Mark:{student.TotalMark}");
        }
    }
}
