using System;

// Program.cs
class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        Journal journal = new Journal();
        int choice = 0;

        while (choice != 5)
        {
            choice = menu.ProcessMenu();
            switch (choice)
            {
                case 1: journal.AddEntry(); break;
                case 2: journal.Display(); break;
                case 3: journal.Save(); break;
                case 4: journal.Load(); break;
            }
        }
        Console.WriteLine("Goodbye!");
    }
}