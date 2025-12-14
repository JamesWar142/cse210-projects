class Running : Activity
{
    public Running(Activity activity) : base(){}
    public override double Distance()
    {
        Console.WriteLine("How far did you run in kilometers?");
        _distance = double.Parse(Console.ReadLine());
        return _distance;
    }
    public override void Calculations()
    {
        _kph=_distance/_time*60.0;
        _pace=_time/_distance;
    }
}