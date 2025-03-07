using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        

        int guess = -1;
        while (guess != number)
        {
            Console.WriteLine ("What is your guess?:");
            guess = int.Parse(Console.ReadLine());
        

            if (number==guess)
            {
                Console.WriteLine($"The number was {number}, You guessed it. Good job");
            }
            else if  (number< guess)
            {
                Console.WriteLine($"Your guess of {guess}, is too high. Guess a lower number: ");
            }
            else
            {
                Console.WriteLine($"Your guess of {guess} is to low. Guess a higher number:");
            }
        }

    }
}