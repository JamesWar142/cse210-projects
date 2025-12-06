using System;

class Program
{
    static void Main(string[] args)
    {
        Ref reference = new Ref("John 3:16 ");
        Scripture john3 = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Press enter to hide words or type quit to end the practice.");
            Console.WriteLine();
            Console.WriteLine(reference.Reference() + john3.GetScripture());
            string input = Console.ReadLine();
            if (input != null && input == "quit")
                break;
            if (john3.AllHidden())
                {
                    break;
                }
            john3.HideWords(3);
        }
    }
}