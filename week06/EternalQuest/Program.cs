// Menu and file handling are in separate classes.
// Display the user's progress percentage. It can exceed 100% because extra points and additional effort are also counted : )
// Show the number of goals achieved when listing the goals; eternal goals are always active and are not included in the count.
// Special message when all goals are completed.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}