using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            string underscores = "";
            for (int i = 0; i < _text.Length; i++)
            {
                underscores = underscores + "_";
            }
            return underscores;
        }
        else
        {
            return _text;
        }
    }
}