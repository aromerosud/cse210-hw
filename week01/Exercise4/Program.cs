using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> listsNumber = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                listsNumber.Add(number);
            }
        }

        double totalSum = 0;
        double countNumbers = 0;
        int largest = listsNumber[0];
        int smallest = listsNumber[0];
        for (int i = 0; i < listsNumber.Count(); i++)
        {
            countNumbers = i + 1;
            totalSum += listsNumber[i];
            if (listsNumber[i] > largest)
            {
                largest = listsNumber[i];
            }
            if (listsNumber[i] < smallest && listsNumber[i] > 0)
            {
                smallest = listsNumber[i];
            }
        }
        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {totalSum / countNumbers}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");
        listsNumber.Sort();
        foreach (int numbers in listsNumber)
        {
            Console.WriteLine(numbers);
        }
    }
}