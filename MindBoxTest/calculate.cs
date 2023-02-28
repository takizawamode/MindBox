using System;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            while (radius < 0)
            {
                Console.WriteLine("Error: radius cannot be negative.");
                Console.WriteLine("Enter a new radius:");
                radius = double.Parse(Console.ReadLine());
            }
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            while (side1 <= 0 || side2 <= 0 || side3 <= 0 || side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                Console.WriteLine("Error: sides must be positive and satisfy the triangle inequality (sum of any two sides is greater than the third).");
                Console.WriteLine("Enter new values for the sides:");
                side1 = double.Parse(Console.ReadLine());
                side2 = double.Parse(Console.ReadLine());
                side3 = double.Parse(Console.ReadLine());
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public bool IsRight()
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }

        public override string ToString()
        {
            return $"Triangle with sides {side1}, {side2}, {side3}";
        }
    }



    public static class ShapeCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }
}
