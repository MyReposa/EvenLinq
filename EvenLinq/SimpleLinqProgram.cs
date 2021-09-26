using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenLinq
{
    class SimpleLinqProgram
    {
        static void Main(string[] args)
        {
            List<int> numbers = CreateList();
            List<int> even = SelectEven_V2(numbers);
            DisplayListItems(even);
        }

        static List<int> CreateList()
        {
            List<int> newlyCreatedList = new List<int>();

            for (int current = 0; current < 100; current++)
            {
                newlyCreatedList.Add(current);
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
            var evenNumbers = numbersToSelectFrom.Where(number => number % 2 == 0);

            return evenNumbers.ToList();
        }

        static void DisplayListItems(List<int> numbersToDisplay)
        {
            foreach (int item in numbersToDisplay)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadKey();
        }
    }
}
