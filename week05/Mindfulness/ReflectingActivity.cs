public class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;
    private List<string> _questionPool;

    public ReflectingActivity() : base("Reflecting", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {                    
        _random = new Random();        

        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _questionPool = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(6);
            Console.WriteLine("");
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        if (_questionPool.Count == 0)
        {
            _questionPool = new List<string>(_questions);
        }

        int index = _random.Next(_questionPool.Count);
        string selected = _questionPool[index];
        _questionPool.RemoveAt(index); 

        return selected;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}