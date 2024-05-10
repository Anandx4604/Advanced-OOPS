using System;
namespace DictionaryDS;
class Program
{
    public static void Main(string[] args)
    {
        CustomDictionary<string, string> myDict = new CustomDictionary<string, string>();
        myDict.Add("SF3001", "Anand");
        myDict.Add("SF3002", "Dhanush");
        myDict.Add("SF3002", "Anand");
        myDict.Add("SF3004", "Bhuvanesh");
        foreach (KeyValue<string, string> data in myDict)
        {
            System.Console.WriteLine($"Key:{data.Key} Value:{data.Value}");
        }

        string name = myDict["SF3001"];
        System.Console.WriteLine("Searcing Name for SF3001...");
        System.Console.WriteLine($"Name:{name}");

        myDict["SF3001"] = "Andy";
        string name1 = myDict["SF3001"];
        System.Console.WriteLine("Searcing Name for SF3001...");
        System.Console.WriteLine($"Name:{name1}");

    }
}