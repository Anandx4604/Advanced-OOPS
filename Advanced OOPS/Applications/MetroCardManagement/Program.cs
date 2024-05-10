using System;
namespace MetroCardManagement;
class Program
{
    public static void Main(string[] args)
    {
        // Operations.AddDefaultData();
        FileHandling.Create();
        FileHandling.ReadFromCSV();
        Operations.MainMenu();
        FileHandling.WritetoCSV();

    }
}