class Rabbit: Mammal
{
    public Rabbit(string name) : base(name)
    {
    }
    
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} makes no noise");
    }
}