using System;
namespace BubbleSortAlgorithm
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] values = { 9,8,7,6,10,5,3,2,1,4};
            System.Console.WriteLine("Bubble Sort Algorithm");
            System.Console.Write("Given Array: ");
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

        static void BubbleSort(int[] values)
        {
            int temp;
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = 0; j < values.Length - i - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }
        }
    }
}