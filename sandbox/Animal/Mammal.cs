class Mammal
{
    protected string _name;
    protected string _sound;

    public override string ToString()
    {
        //override the .GetType function
        return $"{this.GetType()} named {_name}";
    }
    public Mammal(string name)
    {
        _name = name;
    }

    public virtual void MakeNoise()
    {
        Console.WriteLine($"{_name} makes no sound.");
    }
}