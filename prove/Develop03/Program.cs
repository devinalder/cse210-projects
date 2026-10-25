using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        scriptures.Add(scripture1);

        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture2 = new Scripture(reference2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        scriptures.Add(scripture2);

        Reference reference3 = new Reference("Philippians", 4, 13);
        Scripture scripture3 = new Scripture(reference3, "I can do all things through Christ which strengtheneth me.");
        scriptures.Add(scripture3);

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture scripture = scriptures[randomIndex];

        bool keepGoing = true;

        while (keepGoing == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden() == true)
            {
                keepGoing = false;
            }
            else
            {
                Console.WriteLine("Press enter to continue or type 'quit' to finish.");
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    scripture.HideRandomWords(3);
                }
            }
        }
    }
}