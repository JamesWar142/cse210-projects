using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity= new Activity();
        var r = new Running(activity);
        var c = new Cycling(activity);
        var s = new Swimming(activity);
        Console.WriteLine("Welcome to fitness tracker. What activity would you like to do?");
        Console.WriteLine("a. Running");
        Console.WriteLine("b. Cycling");
        Console.WriteLine("c. Swimming");
        string choice=Console.ReadLine();
        if (choice == "a")
        {
            r.Date();
            r.Time();
            r.Distance();
            r.Calculations();
            r.GetSummary();
        }
        else if (choice == "b")
        {
            c.Date();
            c.Time();
            c.Distance();
            c.Calculations();
            c.GetSummary();
        }
        else if (choice == "c")
        {
            s.Date();
            s.Time();
            s.Distance();
            s.Calculations();
            s.GetSummary();
        }
    }
}