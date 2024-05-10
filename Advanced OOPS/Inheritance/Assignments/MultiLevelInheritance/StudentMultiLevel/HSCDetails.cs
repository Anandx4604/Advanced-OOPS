using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMultiLevel
{
    public class HSCDetails : StudentInfo
    {
        // Class HSCDetails: Inherits StudentInfo
        // Properties: HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks
        private static int s_marksheetNumber = 10000;
        public string HSCMarksheetNumber { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }
        public double Total { get; set; }

        public double PercentageMarks { get; set; }

        public HSCDetails(string name, string fatherName, long phone, string mailID,
        DateTime dob, Gender studentGender, string standard, string branch, string academicYear, 
        double physics, double chemistry, double maths) : base(name, fatherName, phone, mailID, dob, studentGender, 
        standard, branch, academicYear)
        {
            s_marksheetNumber++;
            HSCMarksheetNumber = "HSC" + s_marksheetNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;

        }
        // Methods: GetMarks, Calculate – Total and percentage, Show Marksheet.
        public string GetMarks()
        {
            return $"| {Physics} | | {Chemistry} | {Maths} |";
        }

        public void Calculate()
        {
            Total = Physics+Chemistry+Maths;
            PercentageMarks = Math.Round(Total/6,2);
        }

        public string ShowMarksheet()
        {
            return $"| {HSCMarksheetNumber} | {Name} | {Total} | {PercentageMarks} |";
        }

    }
}