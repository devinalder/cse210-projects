using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int hidden = randomGenerator.Next(1, 101);

        int guess = -1;

        while(true)
        {
            Console.Write("What's your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (hidden > guess)
            {
                Console.WriteLine("higher");
            }
            else if (hidden < guess)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("You got it!");
                break;
            }

        }                    
    }
}    