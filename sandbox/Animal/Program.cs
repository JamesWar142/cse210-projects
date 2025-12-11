class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Animal World!");
        Mammal mypet = new Mammal("Ali");
        Console.WriteLine($"{mypet.GetType()}");
        mypet.MakeNoise();
        Mammal myLogomorph = new Rabbit("Shadow");
        Console.WriteLine($"{myLogomorph.GetType()}");
        myLogomorph.MakeNoise();
        Mammal myFeline = new Tiger("Hobbes");
        Console.WriteLine($"{myFeline}");//Atomatically Adds .GetType()
        myFeline.MakeNoise();
        Mammal myFox = new Fox("Ylvis");
        Console.WriteLine($"{myFox}");
        myFox.MakeNoise();
    }
}