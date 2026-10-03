using System;
using System.Collections.Generic;

class Shape
{
    public virtual double CalculateArea() => 0.0;
}

class Circle : Shape
{
    public double Radius;
    public Circle(double r) => Radius = r;
    public override double CalculateArea() => Math.PI * Radius * Radius;
}

class Rectangle : Shape
{
    public double Width, Height;
    public Rectangle(double w, double h) { Width = w; Height = h; }
    public override double CalculateArea() => Width * Height;
}

class Program
{
    static void Main()
    {
        var list = new List<Shape> { new Circle(5), new Rectangle(4, 6) };

        foreach (var s in list)
        {
            Console.WriteLine($"Type: {s.GetType().Name}");
            Console.WriteLine($"Area: {s.CalculateArea():F2}");
        }
    }
}
