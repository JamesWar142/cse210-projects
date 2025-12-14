class Cycling : Activity
{
    public Cycling(Activity activity) : base(){}
    public override double Distance()
    {
        Console.WriteLine("How fast did you go in kph?");
        _kph = double.Parse(Console.ReadLine());
        return _kph;
    }
    public override void Calculations()
    {
        _distance=_kph*_time/60.0;
        _pace=60.0/_kph;
    }
}