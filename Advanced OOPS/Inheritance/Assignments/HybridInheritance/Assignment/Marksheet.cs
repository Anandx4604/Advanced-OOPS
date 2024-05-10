using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class Marksheet : TheoryExamMarks, ICalculate
    {
        public double ProjectMark { get; set; }
        public string MarksheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }
        public double Semester1;
        public double Semester2;
        public double Semester3;
        public double Semester4;


        public Marksheet(string registrationNumber, string name, string fatherName, long phone, DateTime dob, string gender, double projectMark, string marksheetNumber, DateTime dateOfIssue, double[] sem1, double[] sem2, double[] sem3, double[] sem4) : base(registrationNumber, name, fatherName, phone, dob, gender, sem1, sem2, sem3, sem4)
        {
            ProjectMark = projectMark;
            MarksheetNumber = marksheetNumber;
            DateOfIssue = dateOfIssue;
            Semester1 = Sem1[0] + Sem1[1] + Sem1[2] + Sem1[3] + Sem1[4] + Sem1[5];
            Semester2 = Sem2[0] + Sem2[1] + Sem2[2] + Sem2[3] + Sem2[4] + Sem2[5];
            Semester3 = Sem3[0] + Sem3[1] + Sem3[2] + Sem3[3] + Sem3[4] + Sem3[5];
            Semester4 = Sem4[0] + Sem4[1] + Sem4[2] + Sem4[3] + Sem4[4] + Sem4[5];
        }
        public void CalculateUG()
        {
            Total = Semester1 + Semester2 + Semester3 + Semester4;
            Percentage = Total / (2400.0) * 100;
        }

        public string ShowUGMarksheet()
        {
            return $"|{RegistrationNumber} | {MarksheetNumber} | {Name} | {DOB:dd/MM/yyyy} | {Gender} | Date of Issue:{DateOfIssue:dd/MM/yyyy} | Total Marks: {Total} | Percentage: {Percentage} |";
        }
    }
}