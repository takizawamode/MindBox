using System;
using ShapeLibrary;

class review
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a shape:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Triangle");

        int selection = int.Parse(Console.ReadLine());

        switch (selection)
        {
            case 1:
                Console.WriteLine("Enter radius of circle:");
                double radius = double.Parse(Console.ReadLine());
                while (radius < 0)
                {
                    Console.WriteLine("Error: radius cannot be negative.");
                    Console.WriteLine("Enter a new radius:");
                    radius = double.Parse(Console.ReadLine());
                }
                Circle circle = new Circle(radius);
                Console.WriteLine($"Area of circle with radius {radius} = {ShapeCalculator.CalculateArea(circle)}");
                break;

            case 2:
                Console.WriteLine("Enter sides of triangle:");
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double side3 = double.Parse(Console.ReadLine());

                while (side1 <= 0 || side2 <= 0 || side3 <= 0 || side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                {
                    Console.WriteLine("Error: sides must be positive and satisfy the triangle inequality (sum of any two sides is greater than the third).");
                    Console.WriteLine("Enter new values for the sides:");
                    side1 = double.Parse(Console.ReadLine());
                    side2 = double.Parse(Console.ReadLine());
                    side3 = double.Parse(Console.ReadLine());
                }

                Triangle triangle = new Triangle(side1, side2, side3);
                Console.WriteLine($"{triangle} has an area of {ShapeCalculator.CalculateArea(triangle)}");

                if (triangle.IsRight())
                {
                    Console.WriteLine("The triangle is a right triangle.");
                }
                else
                {
                    Console.WriteLine("The triangle is not a right triangle.");
                }
                break;

            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }
}
