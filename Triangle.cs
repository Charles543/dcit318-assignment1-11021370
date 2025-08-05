using System;

class TriangleTypeIdentifier
{
    public static void Run()
    {
        Console.WriteLine("Triangle Type Identifier");
        Console.WriteLine("========================");

        double side1 = GetValidSide("Enter the length of the first side: ");
        double side2 = GetValidSide("Enter the length of the second side: ");
        double side3 = GetValidSide("Enter the length of the third side: ");

        if (!IsValidTriangle(side1, side2, side3))
        {
            Console.WriteLine("Error: These sides cannot form a valid triangle!");
            Console.WriteLine("In a valid triangle, the sum of any two sides must be greater than the third side.");
            return;
        }

        string triangleType = DetermineTriangleType(side1, side2, side3);
        Console.WriteLine($"\nTriangle Type: {triangleType}");

        Console.WriteLine($"Sides: {side1}, {side2}, {side3}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static double GetValidSide(string prompt)
    {
        double side;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out side) && side > 0)
            {
                return side;
            }

            else
            {
                Console.WriteLine("Please enter a valid positive number.");
            }
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    static string DetermineTriangleType(double side1, double side2, double side3)
    {
        const double epsilon = 1e-9;

        bool side1EqualsSide2 = Math.Abs(side1 - side2) < epsilon;
        bool side1EqualsSide3 = Math.Abs(side1 - side3) < epsilon;
        bool side2EqualsSide3 = Math.Abs(side2 - side3) < epsilon;

        if (side1EqualsSide2 && side1EqualsSide3)
        {
            return "Equilateral";
        }
        else if (side1EqualsSide2 || side1EqualsSide3 || side2EqualsSide3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}