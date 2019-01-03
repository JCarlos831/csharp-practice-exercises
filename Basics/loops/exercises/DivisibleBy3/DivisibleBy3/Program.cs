// Write a program to count how many numbers between 1 and 100 are divisible by 3
// with no remainder. Display the count on the console.

using System;

namespace DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine("The count of numbers divisible by 3 between 1 and 100 is " + count);
        }
    }
}