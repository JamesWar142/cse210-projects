class Customer
{
    private Address _address;

    public Customer(Address address)
    {
        _address = address;
    }
    public void FullAddress()
    {
        Console.WriteLine($"{_address._street}");
        Console.WriteLine($"{_address._city}, {_address._state}");
        Console.WriteLine($"{_address._country}");
    }
}