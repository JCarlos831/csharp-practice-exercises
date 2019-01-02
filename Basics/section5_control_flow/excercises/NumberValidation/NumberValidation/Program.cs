// Write a program and ask the user to enter a number. The number should be between 1 and 10.
// If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".

using System;

namespace NumberValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNumberFromUser();
        }

        private static void GetNumberFromUser()
        {
            Console.WriteLine("Enter a number between 1 and 10");

            var userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber < 1 || userNumber > 10)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }
        }
    }
}