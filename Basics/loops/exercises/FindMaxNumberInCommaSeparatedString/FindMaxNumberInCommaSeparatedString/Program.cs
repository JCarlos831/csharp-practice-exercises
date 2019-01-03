// Write a program and ask the user to enter a series of numbers separated by comma.
// Find the maximum of the numbers and display it on the console. For example, if
// the user enters “5, 3, 8, 1, 4", the program should display 8.

using System;

namespace FindMaxNumberInCommaSeparatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series a numbers separated by a comma.\n" +
                              "For example, 5, 3, 8, 1, 4");
            var numberString = Console.ReadLine();
            var numberArray = numberString.Split(", ");

            int max = 0;
            foreach (var number in numberArray)
            {
                if (Convert.ToInt32(number) > max)
                    max = Convert.ToInt32(number);
            }

            Console.WriteLine("The max number is " + max);
        }
    }
}