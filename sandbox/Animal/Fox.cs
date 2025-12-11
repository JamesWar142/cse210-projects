class Fox: Mammal
{
    public Fox(string name) : base(name)
    {
        _sound = "hi";
    }
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} sings {_sound}");
    }
}