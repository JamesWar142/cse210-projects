using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address();
        Order order = new Order(address);
        Product product = new Product(order);
        Customer customer = new Customer(address);
        while (true)
        {
            Console.WriteLine("Please choose an option");
            Console.WriteLine("a: Go Shopping");
            Console.WriteLine("b: View Cart");
            Console.WriteLine("c: View Address");
            Console.WriteLine("d: Edit Address");
            Console.WriteLine("e: Finish Shopping");
            Console.WriteLine("f: quit");
            string s = Console.ReadLine();
            if (s == "a")
            {
                order.CheckOut();
            }
            else if (s == "b")
            {
                product.Cart();
            }
            else if (s == "c")
            {
                customer.FullAddress();
            }
            else if (s == "d")
            {
                address.Location();
            }
            else if (s == "e")
            {
                int final = order.FinalTotal();
                Console.WriteLine($"Your final total is {final}. Have a great day.");
                break;
            }
            else if (s == "f")
            {
                Console.WriteLine("Have a nice day!");
                break;
            }
            else
            {
                Console.WriteLine("Please choose one of the options");
            }
        }
    }
}