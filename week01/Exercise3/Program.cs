using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int count = 0;
        string has_again = "yes";

        while (has_again.ToLower().Equals("yes")){
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("Higher");
                count = count + 1;
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
                count = count + 1;
            }
            else
            {
                count = count + 1;
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It look yoy {count} guesses");
                Console.WriteLine("");
                Console.WriteLine("Would you like to play again (yes/no)? ");
                has_again = Console.ReadLine();
                number = randomGenerator.Next(1, 100);
                count = 0;
            }
        }

        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}