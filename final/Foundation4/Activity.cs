class Activity
{
    public string _date;
    public double _time;
    public double _distance;
    public double _pace;
    public double _kph;
    public int _laps;

    public string Date()
    {
        Console.WriteLine("What day is it in MM/DD/YYYY? ");
        _date=Console.ReadLine();
        return _date;
    }
    public double Time()
    {
        Console.WriteLine("How long did you do this activity?");
        _time = double.Parse(Console.ReadLine());
        return _time;
    }

    public virtual double Distance()
    {
        Console.WriteLine("How far did you go?");
        _distance = double.Parse(Console.ReadLine());
        return _distance;
    }

    public virtual void Calculations()
    {
        _kph=_distance/_time*60.0;
        _pace=_time/_distance;
    }
    public void GetSummary()
    {
        Console.WriteLine($"{_date} ({_time} min): Distance {_distance} km, Speed: {_kph} kph, Pace: {_pace} min per km");
    }
}