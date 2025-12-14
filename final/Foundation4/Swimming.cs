class Swimming : Activity
{
    public Swimming(Activity activity) : base(){}
    public override double Distance()
    {
        Console.WriteLine("How many laps did you do?");
        _laps = int.Parse(Console.ReadLine());
        return _laps;
    }
    public override void Calculations()
    {
        _distance=_laps*50.0/1000.0;
        _pace=_time/_distance;
        _kph=60.0/_pace;
    }
}