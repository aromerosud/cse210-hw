using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("03 Nov 2025", 30, 5.0));
        activities.Add(new Cycling("03 Nov 2025", 40, 20.0));
        activities.Add(new Swimming("03 Nov 2025", 25, 30));

        foreach(var item in activities)
        {
            Console.WriteLine(item.GetSummary());
        }
    }
}