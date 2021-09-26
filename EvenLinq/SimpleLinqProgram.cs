using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenLinq
{
    class SimpleLinqProgram
    {
        static void Main(string[] args)
        {
            List<int> initialNumbers = CreateList();
            List<int> even = SelectEven_V2(initialNumbers);
            List<int> sorted = Sort(even);

            Console.WriteLine("Initial numbers are:");
            DisplayListItems(initialNumbers);

            Console.WriteLine("Even numbers are:");
            DisplayListItems(even);

            Console.WriteLine("Sorted numbers are:);
            DisplayListItems(sorted);

            Console.ReadKey();
        }

        static List<int> CreateList()
        {
            List<int> newlyCreatedList = new List<int>();

            for (int current = 0; current < 20; current++)
            {
                Random randomizer = new Random();
                newlyCreatedList.Add(randomizer.Next(0,100));
            }
            return newlyCreatedList;
        }

        static List<int> SelectEven_V1(List<int> numbersToSelectFrom) //SQL-like syntax
        {
            var evenNumbers = from number in numbersToSelectFrom
                              where number % 2 == 0
                              select number;

            return evenNumbers.ToList();
        }

        static List<int> SelectEven_V2(List<int> numbersToSelectFrom) //object-like syntax
        {
            List<int> evenNumbers = numbersToSelectFrom.Where(number => number % 2 == 0).ToList();

            return evenNumbers;
        }

        static List<int> Sort(List<int> numbersToBeSorted)
        {
            List<int> sortedNumbers = numbersToBeSorted.OrderByDescending(number => number).ToList();
            
            return sortedNumbers;
        }

        static void DisplayListItems(List<int> numbersToDisplay)
        {
            foreach (int item in numbersToDisplay)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\r\n");
        }
    }
}
