using System;
namespace Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Marksheet marksheet1 = new Marksheet("RID1333","Anand","Aruldoss",9898988988,new DateTime(2000,11,05),"male",100, "M1002", new DateTime(2024, 06, 05), new double[]{90, 98, 97, 89, 70, 80}, new double[]{90, 98, 97, 89, 70, 80}, new double[] {90, 98, 97, 89, 70, 80},new double[]{90, 98, 97, 89, 70, 80});
            string result = marksheet1.ShowUGMarksheet();
            System.Console.WriteLine(result);
        }
    }
}