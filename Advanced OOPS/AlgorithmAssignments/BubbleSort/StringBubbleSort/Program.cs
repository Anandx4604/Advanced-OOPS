using System;
namespace StringBubbleSort;
    class Program
    {
        public static void Main(string[] args)
        {
            string[] values = { "SF1002", "SF1004", "SF1003", "SF1001", "SF1005", "SF1006", "SF1007", "SF1008", "SF1009", "SF1010", "SF1011", "SF1012", "SF1013", "SF1014", "SF1015", "SF1016", "SF1017", "SF1018", "SF1019", "SF1020" };
            System.Console.WriteLine("Bubble Sort Algorithm");
            System.Console.Write("\nGiven Array: ");
            for (int i = 0; i < values.Length; i++)
            {
                System.Console.Write($"{values[i]+" "}");
            }

            BubbleSort(values);
            System.Console.Write("\nSorted Array: ");
            for (int i = 0; i < values.Length; i++)
            {
                System.Console.Write($"{values[i]+" "}");
            }
        }

        static void BubbleSort(string[] values)
        {
            string temp;
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = 0; j < values.Length - i - 1; j++)
                {
                    if (values[j].CompareTo(values[j + 1])>0)
                    {
                        temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }
        }
    }