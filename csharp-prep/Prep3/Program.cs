using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(2, 101);
        Console.WriteLine("This is the number guessing game. Make a guess between 1-100");
        string response = "yes";
        while (response == "yes")
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            if (guess > number)
            {
                Console.WriteLine("lower");
                response = "yes";
            }
            else if (guess < number)
            {
                Console.WriteLine("higher");
                response = "yes";
            }
            else
            {
                Console.Write("Congradulations! You guessed the number.");
                response = "no";
            }
        }
    }
}