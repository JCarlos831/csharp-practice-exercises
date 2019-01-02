// Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape
// or portrait.

using System;

namespace LandscapeOrPortrait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will determine if an image is landscape or portrait dependent on the" +
                              "width and height that is entered.");

            Console.WriteLine("Enter a width");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a height");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(width > height ? "The image is landscape" : "The image is portrait");
        }
    }
}