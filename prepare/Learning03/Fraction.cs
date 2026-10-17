using System.Xml.Schema;

public class Function
{
    private int _top;
    private int _bottom;

    public Function()
    {
        _top = 1;
        _bottom = 1;

    }

    public Function(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Function(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

}