using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        float devider = 0;
        int highest = 0;
        List<int> numbers = new List<int>();
        int num = 1;
        Console.WriteLine("Enter a list of numbers, type 0 to finish.");
        while (num != 0)
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();
            num = int.Parse(numInput);
            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        foreach (int number in numbers)
        {
            total = total + number;
            devider = numbers.Count;
            if (number >= highest)
            {
                highest = number;
            }
        }
        float average = total / devider;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {highest}");
    }
}