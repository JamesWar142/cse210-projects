class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Please Select one of the choices bellow:");
        Console.WriteLine("a: Write");
        Console.WriteLine("b: Display");
        Console.WriteLine("c: Save");
        Console.WriteLine("d: Load");
        Console.WriteLine("e: Quit");
    }
    public string MenuChoice()
    {
        //we use public string as we want to keep response
        Console.WriteLine("What would you like to do?");
        return Console.ReadLine();
        // return is used to identify proper string
    }
}