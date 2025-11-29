public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private string _selectedPrompt;

    private Random _random;

    public ListingActivity() : base ("Listing", "reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {                    
        _random = new Random();

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };      
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:\n");

        _selectedPrompt = GetRandomPrompt();
        Console.WriteLine($"--- {_selectedPrompt} ---\n");
        

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        List<string> userList = GetListFromUser();
        _count = userList.Count;


        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();

        DisplayEndingMessage();        
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];        
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                list.Add(input);
            }
        }

        return list;        
    }
}