class Product
{
    private Order _order;
    public Product(Order order)
    {
        _order = order;
    }
    public void Cart()
    {
        int final = _order.FinalTotal();
        Console.WriteLine($"Apples, id:01, $15, {_order._apple}");
        Console.WriteLine($"Oranges, id:02, $10, {_order._orange}");
        Console.WriteLine($"Bananas, id:03, $5, {_order._banana}");
        Console.WriteLine($"Total = ${final}.00");
    }
}