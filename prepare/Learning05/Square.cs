public class Square : Shape
{
    private double side;

    public Square(string Color, double Side) : base(Color)
    {
        side = Side;
    }

    public override double GetArea()
    {
        return side * side;
    }
}