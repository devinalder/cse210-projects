using System;

class JournalEntry
{
    private string _date;
    private string _prompt;
    private string _response;

    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    public string ToFileString()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }

    public static JournalEntry FromFileString(string line)
    {
        string[] parts = line.Split("~|~");
        return new JournalEntry(parts[0], parts[1], parts[2]);
    }
}