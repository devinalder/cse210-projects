using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers =  new List<int>();
        Console.Write("Enter some numbers, enter 0 to stop: ");
        while (true)
        {
            Console.WriteLine(""); 
            int n = int.Parse(Console.ReadLine());
            numbers.Add(n);

            if (n == 0) {
                break;
            }

            numbers.Add(n);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
    }
}