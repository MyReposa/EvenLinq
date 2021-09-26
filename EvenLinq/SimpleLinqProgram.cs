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
            List<int> even = SelectEven(numbers);
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

        static List<int> SelectEven(List<int> numbersToSelectFrom)
        {
            var evenNumbers = from number in numbersToSelectFrom
                              where number % 2 == 0
                              select number;

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
