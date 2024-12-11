using System;

public class Rectangle
{
    private double side1;
    private double side2;
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public double CalculateArea()
    {
        return side1 * side2;
    }
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }
    public double Area
    {
        get { return CalculateArea(); }
    }
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Данiїл Iванченко, КIб-1-23-4.0д");
        Console.Write("Введiть довжину першої сторони: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Введiть довжину другої сторони: ");
        double side2 = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(side1, side2);
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
    }
}
