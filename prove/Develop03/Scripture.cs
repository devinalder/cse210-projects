using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            if (IsCompletelyHidden() == true)
            {
                return;
            }

            int index = _random.Next(_words.Count);

            while (_words[index].IsHidden() == true)
            {
                index = _random.Next(_words.Count);
            }

            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            text = text + word.GetDisplayText() + " ";
        }

        return text;
    }
}