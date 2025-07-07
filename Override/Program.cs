using System;
using System.Collections.Generic;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape...");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(),
            new Rectangle(),
            new Circle(),
            new Rectangle()
        };

        foreach (Shape shape in shapes)
        {
            shape.Draw(); 
        }
    }
}
