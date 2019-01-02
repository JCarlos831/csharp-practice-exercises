// Write a program which takes two numbers from the console and displays the maximum of the two.

using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will get the maximum between two numbers");

            List<int> numbers = new List<int>();

            Console.WriteLine("Please enter the first number");
            
            numbers.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Please enter the second number");
            
            numbers.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("The max number is " + numbers.Max());
        }
    }
}