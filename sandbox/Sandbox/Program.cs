using System;

class Program
{
    static double AddNumbers(double x, int y)
    {
        return x + y;
    }

    static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Welcome {name}, pleased to meet you");
    }
    static void Main(string[] args)
    {
        // bool done = false;

        // do
        // {
        //     Console.Write("Are we done? (y/n): ");
        //     done = Console.ReadLine() == "y";
        // } while (! done);

        // for(double i = 0; i <= 100.0; i+=5.13081)
        // {
        //     Console.Write($"{i} -");
        //     Console.WriteLine("hey twin");
        // }
        DisplayGreeting("Bob");
        Console.WriteLine(AddNumbers(12.243, 10));
    }
}