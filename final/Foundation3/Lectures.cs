class Lectures : Event
{
    public Lectures(Address address) : base(address){}
    public override void Standard()
    {
        Console.WriteLine("Public Coders Talk");
        Console.WriteLine("Come talk with us in the largest coders event.");
    }
    public override void Full()
    {
        Console.WriteLine("This is a Lecture, and we will be gathered in front of a stand to talk about what our passion.");
    }
    public void Speaker()
    {
        Console.WriteLine("The capacity is around 500 and our main speaker will be James Wyatt.");
    }
    public override void Short()
    {
        Console.WriteLine("Lecture meeting, Public Coders Talk, 12/11/25");
    }
}