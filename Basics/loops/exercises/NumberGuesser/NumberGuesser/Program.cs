// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
// If the user guesses the number, display “You won"; otherwise, display “You lost".
// (To make sure the program is behaving correctly, you can display the secret number on the console first.)

using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var secretNumber = random.Next(1, 10);
//            Console.WriteLine(secretNumber);
            
            var guesses = 4;

            while (guesses > 0)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                var userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < 1 || userGuess > 10)
                    Console.WriteLine("Invalid. Number must be between 1 and 10.");
                else if (userGuess == secretNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
                else
                {
                    guesses--;
                    Console.WriteLine("You have " + guesses + " remaining.");
                }
            }

            Console.WriteLine("You lost");
        }
    }
}