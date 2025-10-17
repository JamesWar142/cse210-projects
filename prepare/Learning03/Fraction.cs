using System;

class Fraction
{
    // Attributes
    private int _top;
    private int _bottom;
    // Functions
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fractionOut = $"{_top}/{_bottom}";
        return fractionOut;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}