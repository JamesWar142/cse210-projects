class Address
{
    public string _street;
    public string _city;
    public string _state;
    public void Location()
    {
        Console.WriteLine("What is the street?");
        _street = Console.ReadLine();
        Console.WriteLine("What is the city?");
        _city = Console.ReadLine();
        Console.WriteLine("What is the state?");
        _state = Console.ReadLine();
    }
}