class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _country;
    public int _shipping;

    public void Location()
    {
        Console.WriteLine("What is your street?");
        _street = Console.ReadLine();
        Console.WriteLine("What is your city?");
        _city = Console.ReadLine();
        Console.WriteLine("What is your state?");
        _state = Console.ReadLine();
        Console.WriteLine("What is your country? If you type USA, shipping is $30 less");
        _country = Console.ReadLine();
    }
    public int Shipping()
    {
        if (_country == "USA")
        {
            _shipping = 5;
        }
        else
        {
            _shipping = 35;
        }
        return _shipping;
    }
}