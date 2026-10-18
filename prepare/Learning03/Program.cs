using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        //create new fraction and random num
        Fraction frac1 = new Fraction();
        Random randomNum = new Random();

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test getters and setters
        f1.SetTop(6);
        f1.SetBottom(7);
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());
        
        for (int i = 1; i <= 20; i++)
        {
            int top = randomNum.Next(1, 11);
            int bottom = randomNum.Next(1, 11);

            frac1.SetTop(top);
            frac1.SetBottom(bottom);

    Console.WriteLine($"Fraction {i}: string: {frac1.GetFractionString()} Number: {frac1.GetDecimalValue()}");
        }
    }
}