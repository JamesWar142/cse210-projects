using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius;

    public Circle(string Color, double Radius) : base (Color)
    {
        _radius = Radius;
    }
    public override double GetArea()
    {
        double PI = Math.PI;
        return _radius * _radius * PI;
    }
}