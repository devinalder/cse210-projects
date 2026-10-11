class Menu
{
    public int ProcessMenu()
    {
        int response = 0;

        while (response < 1 || response > 5)
        {
            Console.WriteLine("Welcome to the Journaling Program.");
            Console.WriteLine("Create, Display, Save, and Read Journal Entries");
            Console.WriteLine("1. Create new journal entry.");
            Console.WriteLine("2. Display journal.");
            Console.WriteLine("3. Save journal file");
            Console.WriteLine("4. Read journal from file");
            Console.WriteLine("5. Quit");
            Console.Write(">");

            response = int.Parse(Console.ReadLine());
            if (response < 1 || response > 5)
            {
                Console.WriteLine("Please enter a number from 1 to 5.");
            }
        }

        return response;
    }
}