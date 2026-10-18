using System.Xml.Schema;

public class Fraction
{
    private int _top;
    private int _bottom;

//declare the fraction blueprint
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


// declare the get and set functions
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

//display fraction and decimal value
    public string GetFractionString()
    {
    return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
    return (double)_top / (double)_bottom;
    }
}