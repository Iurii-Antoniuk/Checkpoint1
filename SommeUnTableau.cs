using System;

namespace Somme_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbersToAdd = InitializeTable();
           int summOfIntegers = AraySumm(numbersToAdd);
           Console.WriteLine("The summ of entered integers is: " + summOfIntegers);
        }

        static int[] InitializeTable()
        {
            int[] numbersToAdd = new int[255];
            Console.WriteLine("Enter the integers to add. To finish enter a negative number.");
            bool negativeNumber = false;
            while (!negativeNumber)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbersToAdd[counter] = number;
                if (number < 0)
                {
                    negativeNumber = true;
                }
            }
            return numbersToAdd;
        }

        static int[] InitializeTableSimplified(params int[] numbersToAdd)
        {
            return numbersToAdd;
        }

        static int AraySumm (int[] numbersToAdd)
        {
            int result = 0;
            foreach (int element in numbersToAdd)
            {
                if (element > 0)
                {
                    result = result + element;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}
