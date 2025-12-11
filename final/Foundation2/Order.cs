class Order
{
    private Address _address;
    private int _total;
    public int _finalTotal;
    public int _apple;
    public int _orange;
    public int _banana;

    public Order(Address address)
    {
        _address = address;
    }
    public void CheckOut()
    {
        int apples = 15;
        int oranges = 10;
        int bananas = 5;

        while (true)
        {
            Console.WriteLine($"${_total}.00");
            Console.WriteLine("Please choose your order(Apples=$15, Oranges=$10, Bananas = $5) type 'quit' to exit");
            string item = Console.ReadLine();

            if (item == "quit")
            {
                break;
            }

            Console.WriteLine("How much of that product do you want?");
            int qty = int.Parse(Console.ReadLine());
            if (item == "apples")
            {
                _total += apples * qty;
                _apple += qty;
            }
            else if (item == "oranges")
            {
                _total += oranges * qty;
                _orange += qty;
            }
            else if (item == "bananas")
            {
                _total += bananas * qty;
                _banana += qty;
            }
        }
    }
    public int FinalTotal()
    {
        _finalTotal = _total + _address._shipping;
        return _finalTotal;
    }
}