namespace Till;

class Bin
{
    // attributes
    private string _denomination;
    private decimal _value;
    private int _count;

    // behaviors
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }
    // modifier method "Alter" method
    public void Alter(int delta)
    {
        _count += delta;
    }
    // accessor "getter" methods
    public string GetDenomination()
    {
        return _denomination;
    }
    public string GetCount()
    {
        return _count;
    }
}