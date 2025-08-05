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

            switch (choice)
            {
                case "1":
                    GradeCalculator.Run();
                    break;

                case "2":
                    TicketPriceCalculator.Run();
                    break;

                case "3":
                    TriangleTypeIdentifier.Run();
                    break;

                case "0":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 0 and 3.");
                    break;


            }
        }

    }
}