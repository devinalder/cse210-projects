class Word
{
    private bool _hidden;
    private string _word;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Display()
    {
        Console.Write($"{GetWordString()} ");
    }

    public string GetWordString()
    {
        if (!_hidden)
        {
            return _word;
        }

        string returnString = "";
        foreach (char c in _word)
        {
            returnString += char.IsLetterOrDigit(c) ? '_' : c;
        }
        return returnString;
    }
}