using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string InputName = PromptUserName();
        int InputNumber = PromptUserNumber();
        int InputBirthYear = PromptUserBirthYear();
        int SquaredNumber = SquareNumber(InputNumber);
        DisplayResult(InputName, SquaredNumber, InputBirthYear);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numInput = Console.ReadLine();
        int number = int.Parse(numInput);
        return number;
    }
    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        string birthIn = Console.ReadLine();
        int birthyear = int.Parse(birthIn);
        return birthyear;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square, int age)
    {
        int year = 2025 - age;
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {year} this year.");
    }
}