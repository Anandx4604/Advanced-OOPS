using System;
namespace Partial2
{
    public partial class StudentInfo
    {
        public double Total()
        {
            return Physics+Chemistry+Maths;
        }

        public double Percentage()
        {
            return Total()/3;
        }

        public string Display()
        {
            return $"| {StudentID} | {Name} | {Gender} | {DOB} | {Mobile} | Total Marks: {Total()} | Percentage: {Percentage()}";
        }
    }
}