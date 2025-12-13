class Event
{
    protected Address Address;
    Address address= new Address();

    public Event(Address address)
    {
        Address = address;
    }
    public virtual void Standard()
    {
        Console.WriteLine("Random Title");
        Console.WriteLine("Random Description");
    }
    public void Info()
    {
        Console.WriteLine($"{Address._street}, {Address._city}, {Address._state}");
    }
    public virtual void Full()
    {
        Console.WriteLine("The Event");
    }
    public virtual void Short()
    {
        Console.WriteLine("Event, Title, Date");
    }
}