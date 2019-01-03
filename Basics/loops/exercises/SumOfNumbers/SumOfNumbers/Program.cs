// Write a program and continuously ask the user to enter a number or "ok" to exit.
// Calculate the sum of all the previously entered numbers and display it on the console.

using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            
            while (true)
            {
                Console.WriteLine("Please enter a number to add to total or type 'ok' to exit.");

                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "ok" || userInput == "")
                    break;
                int number = Convert.ToInt32(userInput);
                sum += number;
            }

            Console.WriteLine("The sum of the numbers entered is " + sum);
        }
    }
}