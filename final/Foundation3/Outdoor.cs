class Outdoor : Event
{
    public Outdoor(Address address) : base(address){}
    public override void Standard()
    {
        Console.WriteLine("Outdoor Barbacue");
        Console.WriteLine("Come have a fun barbaque with us.");
    }
    public override void Full()
    {
        Console.WriteLine("A simple barbacue. If you have any diet restrictions let us know.");
    }
    public void Weather()
    {
        Console.WriteLine("THe weather will be sunny but might get a bit chilly later so bring a jacket.");
    }
    public override void Short()
    {
        Console.WriteLine("Outdoor Activity, Outdoor Barbacue, 12/11/25");
    }
}