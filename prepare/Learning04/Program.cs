using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment ment = new Assignment("James Wyatt", "Geometery");
        Console.WriteLine(ment.GetSummary());
        Console.WriteLine("");

        MathAssignment Mathment = new MathAssignment("Ervin Wyatt", "Addition", "19", "1-10");
        Console.WriteLine(Mathment.GetSummary());
        Console.WriteLine(Mathment.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment Writement = new WritingAssignment("Sherry Wyatt", "American History", "The Civil War");
        Console.WriteLine(Writement.GetSummary());
        Console.WriteLine(Writement.GetWritingInformation());
    }
}