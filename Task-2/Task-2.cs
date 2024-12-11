using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    private double a;
    private double v;
    private string nm;
    public Point(double a, double v, string nm)
    {
        this.a = a;
        this.v = v;
        this.nm = nm;
    }
    public double A
    {
        get { return a; }
    }
    public double V
    {
        get { return v; }
    }
    public string Nm
    {
        get { return nm; }
    }
}
public class Figure
{
    private Point[] points;
    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[] { p1, p2, p3 };
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 };
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
    }
    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.A - A.A, 2) + Math.Pow(B.V - A.V, 2));
    }
    public double CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Point current = points[i];
            Point next = points[(i + 1) % points.Length];
            perimeter += GetSideLength(current, next);
        }
        return perimeter;
    }
    public string GetName()
    {
        if (points.Length == 3)
            return "Три точки, тож трикутник";
        else if (points.Length == 4)
            return "Чотири точки, тож квадрат";
        else if (points.Length == 5)
            return "П'ять точок, тож п'ятикутник";
        else
            return "Багатокутник";
    }
    public void DisplayPoints()
    {
        foreach (var point in points)
        {
            Console.WriteLine($"Точка {point.Nm}: ({point.A}, {point.V})");
        }
    }
}
namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(20, 1, "1");
            Point p2 = new Point(14, 1, "2");
            Point p3 = new Point(4, 4, "3");
            Point p4 = new Point(11, 4, "4");
            Figure figure = new Figure(p1, p2, p3, p4);
            Console.WriteLine("Данiїл Iванченко, КIб-1-23-4.0д");
            Console.WriteLine($"Що то таке: {figure.GetName()}");
            Console.WriteLine($"Периметр: {figure.CalculatePerimeter()}");
            Console.WriteLine("Координати точок:");
            figure.DisplayPoints();
        }
    }
}
