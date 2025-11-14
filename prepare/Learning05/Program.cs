using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 10);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 5, 9);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 7);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string Color = s.GetColor();

            double Area = s.GetArea();

            Console.WriteLine($"The area of the {Color} shape is {Area}.");
        }
    }
}