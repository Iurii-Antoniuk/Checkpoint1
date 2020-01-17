using System;

namespace Somme_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] integers = InitializeTable();
           int[] trimmedIntegers = TrimTable(integers);
           int summOfIntegers = AraySumm(trimmedIntegers);
           Console.WriteLine("The summ of entered integers is: " + summOfIntegers);
           double average = TableAverage(trimmedIntegers);
           Console.WriteLine("The average value of entered integers is: " + average);
           int[] sortedIntegers = SelectionSort(trimmedIntegers);
           Console.WriteLine("The sorted integer values are as follows: ");
           foreach (int element in sortedIntegers)
            {
                Console.Write(" " + element);
            }
           Console.WriteLine();
        }

        static int[] InitializeTable()
        {
            int[] numbersToAdd = new int[255];
            Console.WriteLine("Enter the integers to add. To finish enter a negative number.");
            int counter = 0;
            bool negativeNumber = false;
            while (!negativeNumber)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbersToAdd[counter] = number;
                counter++;
                if (number < 0)
                {
                    negativeNumber = true;
                }
            }
            return numbersToAdd;
        }
        static int[] TrimTable(int[] integers)
        {
            int counter = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] > 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            int[] trimmedTable = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                trimmedTable[i] = integers[i];
            }
            return trimmedTable;
        }

        static int AraySumm (int[] numbersToAdd)
        {
            int result = 0;
            foreach (int element in numbersToAdd)
            {
                result = result + element;
            }
            return result;
        }
        static double TableAverage(int[] integers)
        {
            int sumElements = AraySumm(integers);
            double average = sumElements / Convert.ToDouble(integers.Length);
            return average;
        }

        static int[] SelectionSort(int[]integers)
        {
            int n = integers.Length;
            for (int i = 0; i < n-1; i++)
            {
                int min_idx = i;
                for (int j = i+1; j < n; j++)
                {
                    if (integers[j] < integers[min_idx])
                    {
                        min_idx = j;
                    }
                }
                int temp = integers[min_idx];
                integers[min_idx] = integers[i];
                integers[i] = temp;
            }
            return integers;
        }
    }
}
