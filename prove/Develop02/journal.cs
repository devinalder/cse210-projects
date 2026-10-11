// Journal.cs
using System;
class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public void AddEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        _entries.Add(new JournalEntry(date, prompt, response));
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine("Journal saved.");
    }

    public void Load()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        foreach (string line in File.ReadAllLines(filename))
        {
            _entries.Add(JournalEntry.FromFileString(line));
        }
        Console.WriteLine("Journal loaded.");
    }
}