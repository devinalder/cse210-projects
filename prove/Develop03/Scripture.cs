class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string part in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visible = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visible.Count > 0; i++)
        {
            int index = _random.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public int GetHiddenCount()
    {
        return _words.Count(w => w.IsHidden());
    }

    public int GetWordCount()
    {
        return _words.Count;
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetWordString()));
        return $"{_reference.GetDisplayText()}\n{text}";
    }
}