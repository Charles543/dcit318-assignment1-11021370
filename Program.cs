using System;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("C# Programs Menu");
            Console.WriteLine("=================");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=================");
            Console.Write("Choose a program to run (0-3): ");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    GradeCalculator.Run();
                    break;
            }
        }
}