﻿// Write a program and ask the user to enter a number. Compute the factorial of the number
// and print it on the console. For example, if the user enters 5, the program should
// calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var number = Convert.ToInt32(Console.ReadLine());
            var ogNumber = number;

            if (number == 0 || number == 1)
            {
                Console.WriteLine(ogNumber + "! = " + 1);
                return;
            }

            var sum = number;
            while (number > 1)
            {
                number--;
                sum *= number;
            }
            
            Console.WriteLine(ogNumber + "! = " + sum);
        }
    }
}