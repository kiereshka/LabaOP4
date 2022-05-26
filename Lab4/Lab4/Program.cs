using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{

    public static class Program
    {
        public static void Main()
        {
            var square = new Square(5, Color.Aqua);
            Console.WriteLine(square);
            // Console.WriteLine($"Длина {square.LinesLength}");
            // Console.WriteLine($"Площадь: {square.GetArea()}");

            var circle = new Circle(7, Color.Coral);
            Console.WriteLine(circle);
            Console.WriteLine($"Радиус: {circle.R}\n");
            // Console.WriteLine($"Площадь: {circle.GetArea()}");

            var line = new Line(10, Color.Plum);
            Console.WriteLine(line);
            // Console.WriteLine($"Длина: {line.Length}");
        }
    }

    public abstract class GeometricFigure
    {
        public Color Color { get; set; }

        public GeometricFigure(Color color)
        {
        Color = color;
        }
    }

    public class Square : GeometricFigure
    {
        public double LinesLength { get; set; }

        public double GetArea() => Math.Pow(LinesLength, 2);

        public Square(double linesLength, Color color) : base(color)
        {
            LinesLength = linesLength;
        }

        public override string ToString()
        {
        return $"Квадрат, площадь {GetArea()} кв. ед. Цвет фигуры: {Color.Name}\n";
        }
    }

    public class Circle : GeometricFigure
    {
        public double R { get; set; }

        public double GetArea() => Math.PI * Math.Pow(R, 2);

        public Circle(double radius, Color color) : base(color)
        {
            R = radius;
        }

        public override string ToString()
        {
        return $"Круг, площадь {GetArea()} кв. ед. Цвет фигуры: {Color.Name}";
        }
    }

    public class Line : GeometricFigure
    {
        public double Length { get; set; }

        public Line(double length, Color color) : base(color)
        {
            Length = length;
        }


        public override string ToString()
        {
        return $"Отрезок, длина {Length} ед. Цвет фигуры: {Color.Name}\n";
        }
    }
}
