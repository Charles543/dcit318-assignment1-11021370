using System;

class TicketPriceCalculator
{
    public static void Run()
    {
        Console.WriteLine("=== Movie Theater Ticket Price Calculator ===");

        Console.Write("Please enter your age:");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            decimal ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7.00m;
                Console.WriteLine("You are eligible for a discount!");
            }
            else
            {
                ticketPrice = 10.00m;
            }

            Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}.");
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid age (whole number).");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}