using System;
using System.Collections.Generic;

namespace iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var numbers = new List<int>();

            var myNumber = 0;

            do
            {
                myNumber++; // 2

                numbers.Add(myNumber); // 1, 2, 3, 4, 100

            } while (myNumber < 100);

            while (myNumber < 200)
            {
                myNumber++;

                numbers.Add(myNumber);
            }

            Console.WriteLine("Increase");

            foreach(var item in numbers)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("");
            Console.WriteLine("Decrease");

            for(int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }
        }
    }
}
