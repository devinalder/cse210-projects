using System;
using System.Formats.Tar;

class Program
{
    static void Main(string[] args)
    {
        float gradePercentage;
        string gradeString;
        string sign;
 
        Console.Write("Enter your grade percentage ");
        gradeString = Console.ReadLine();
        gradePercentage = int.Parse(gradeString);
        if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradePercentage % 10 >= 7)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (gradePercentage >= 90)
        {
            Console.WriteLine($"You have an A{sign}");
        }
        else if (gradePercentage < 90 && gradePercentage >= 80)
        {
            Console.WriteLine($"You have an B{sign}");
        }
        else if (gradePercentage < 80 && gradePercentage >= 70)
        {
            Console.WriteLine($"You have an C{sign}");
        }
        else if (gradePercentage < 70 && gradePercentage >= 60)
        {
            Console.WriteLine($"You have an D{sign}");
        }
        else
        {
            Console.WriteLine("You have an F");
        }
        if (gradePercentage > 70)
        {
            Console.WriteLine("You passed!");
        }
    }
}