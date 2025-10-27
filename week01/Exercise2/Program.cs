using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, this program will help you know what your final grade is.");
        Console.WriteLine("");
        Console.Write("Enter your grade: ");
        string scoreComplete = Console.ReadLine();
        string grade;
        string symbol = string.Empty;

        int score = int.Parse(scoreComplete);

        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        int lastDigit = score % 10;
        if (lastDigit >= 7)
        {
            symbol = "+";
        }
        else if (lastDigit < 3)
        {
            symbol = "-";
        }

        if (score >= 93)
        {
            symbol = "";
        }

        if (score < 60)
        {
            symbol = "";
        }

        Console.WriteLine($"Grade: {grade}{symbol }");
        if (score >= 70)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You need at least 70% to pass. Don't worry, keep trying and you'll do better next time!");
        }
    }
}