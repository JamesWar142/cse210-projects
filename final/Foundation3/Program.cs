using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address();
        var l = new Lectures(address);
        var r = new Reception(address);
        var o = new Outdoor(address);


        address.Location();
        Console.WriteLine("\nWhat type of event do you want to be held?");
        Console.WriteLine("a: Lecture");
        Console.WriteLine("b: Reception");
        Console.WriteLine("c: Outdoor");
        string eventType = Console.ReadLine();
        Console.WriteLine("\nWhat type message do you want to see?");
        Console.WriteLine("a: Standard");
        Console.WriteLine("b: Full");
        Console.WriteLine("c: Short");
        string message = Console.ReadLine();

        if (eventType == "a")
        {
            if (message == "a")
            {
                l.Standard();
                l.Info();
            }
            else if (message == "b")
            {
                l.Full();
                l.Standard();
                l.Info();
            }
            else if (message == "c")
            {
                l.Short();
            }
        }
        else if (eventType == "b")
        {
            if (message == "a")
            {
                r.Standard();
                r.Info();
            }
            else if (message == "b")
            {
                r.Full();
                r.Standard();
                r.Info();
            }
            else if (message == "c")
            {
                r.Short();
            }
        }
        else if (eventType == "c")
        {
            if (message == "a")
            {
                o.Standard();
                o.Info();
            }
            else if (message == "b")
            {
                o.Full();
                o.Standard();
                o.Info();
            }
            else if (message == "c")
            {
                o.Short();
            }
        }
    }
}