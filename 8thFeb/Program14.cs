using System;

interface IShape
{
    void Draw();  // Interface method
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }
}

class Program
{
    static void Main()
    {
        IShape shape1 = new Circle();
        IShape shape2 = new Rectangle();

        shape1.Draw();  // Calls Circle's Draw()
        shape2.Draw();  // Calls Rectangle's Draw()
    }
}
