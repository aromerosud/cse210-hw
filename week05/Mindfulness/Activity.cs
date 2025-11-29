public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine($"This activity will help you {_description}\n");   
        Console.Write("How long, in seconds, would you like for your session? ");  
        _duration = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...\n");
        ShowSpinner(3);        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        int elapsedFrames = 0;
        int totalFrames = seconds * 2;

        while (elapsedFrames < totalFrames)
        {
            foreach (string s in animationStrings)
            {
                if (elapsedFrames >= totalFrames) break; 
                Console.Write(s);
                Thread.Sleep(750);
                Console.Write("\b \b");
                elapsedFrames++;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }
}