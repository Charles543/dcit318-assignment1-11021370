using System;

class GradeCalculator
{
    public static void Run()
    {
        Console.WriteLine("Grade Calculator");
        Console.WriteLine("================");

        Console.Write("Enter a numerical grade between 0 and 100:");

        if (double.TryParse(Console.ReadLine(), out double grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Error: Please enter a grade between 0 and 100.");
            }
            else
            {
                string letterGrade;
                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                Console.WriteLine($"Numerical Grade: {grade}");
                Console.WriteLine($"Your Letter grade is: {letterGrade}");
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid numerical grade.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}using System;

class GradeCalculator
{
    public static void Run()
    {
        Console.WriteLine("Grade Calculator");
        Console.WriteLine("================");

        Console.Write("Enter a numerical grade between 0 and 100:");

        if (double.TryParse(Console.ReadLine(), out double grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Error: Please enter a grade between 0 and 100.");
            }
            else
            {
                string letterGrade;
                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                Console.WriteLine($"Numerical Grade: {grade}");
                Console.WriteLine($"Your Letter grade is: {letterGrade}");
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid numerical grade.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}