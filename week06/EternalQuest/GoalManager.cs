public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    Menu _menu = new Menu();
    private FileManager _fileManager = new FileManager();
    public GoalManager()
    {
        // Initializes an empty list of goals and sets the player's score to 0.
        _score = 0;
        _goals = new List<Goal>();
    }    

    public void Start()
    {
        // This is the "main" function of this class. It is called by Program.cs and then runs the menu loop. 
        try
        {
            bool _hasAction = false;        
            do
            {
                DisplayPlayerInfo();
                string action = _menu.DisplayMenu();

                switch (action)
                {
                    case "1":    
                        CreateGoal();
                        _hasAction = true;               
                        break;

                    case "2": 
                        ListGoalDetails();
                        _hasAction = true; 
                        break;                   

                    case "3": 
                        SaveGoals();
                        _hasAction = true; 
                        break;

                    case "4": 
                        LoadGoals();
                        _hasAction = true;
                        break;

                    case "5": 
                        ListGoalNames();
                        RecordEvent();
                        _hasAction = true;
                        break;

                    case "6": 
                        _hasAction = false;
                        break;

                    default:
                        Console.WriteLine("Invalid selection.");
                        _hasAction = true; 
                        break;
                }   
            } while (_hasAction); 
        }
        catch (DivideByZeroException zeroDivErr)
        {
            Console.WriteLine("Error: A division by zero was attempted, which is not allowed.");
        }  
        catch(FormatException valErr)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }   
        catch(Exception ex) when (ex is InvalidCastException || ex is KeyNotFoundException || ex is IndexOutOfRangeException)
        {
            Console.WriteLine("Error: An attempt was made to access an element that does not exist or is not compatible." + ex.Message);
        }
    }

    public void DisplayPlayerInfo()
    {
        // Displays the player's current score.
        int totalPoints = _goals.Sum(g => g.GetPoints());
        double percent = totalPoints == 0 ? 0 : (_score*100.0/totalPoints);
        Console.WriteLine($"You have {_score} points. Progress: {percent:0.##}%");

        if(percent > 100)
        {
            Console.WriteLine("Amazing! You exceeded all goals!\n");
        }

    }

    public void ListGoalNames()
    {
        // Lists the name of each goal.
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach(var goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
            count++;
        }   
    }

    public void ListGoalDetails()
    {
        // Lists the details of each goal (including the checkbox indicating whether it is complete).
        Console.WriteLine("The goals are: ");

        int count = 1;
        foreach(var goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }

        int completed = _goals.Where(g => !(g is EternalGoal)).Count(g => g.IsComplete());
        int totalCompletable = _goals.Count(g => !(g is EternalGoal));
        Console.WriteLine($"Completed goals: {completed}/{totalCompletable}");

        Console.WriteLine("Eternal goals are always active. : )\n");

        Console.WriteLine("");  
    }

    public void CreateGoal()
    {
        // Asks the user for information about a new goal. Then, creates the goal and adds it to the list.        
        string action = _menu.DisplayMenuGoals();

        if (action != "1" && action != "2" && action != "3")
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine(); 

        Console.Write("What is the amount of points associated with this goal? ");
        int point = int.Parse(Console.ReadLine()); 

        switch (action)
        {
            case "1":  
                _goals.Add(new SimpleGoal(name, desc, point)); 
                Console.WriteLine("");                                 
                break;

            case "2": 
                _goals.Add(new EternalGoal(name, desc, point));  
                Console.WriteLine("");  
                break;

            case "3":  
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine()); 

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine()); 

                _goals.Add(new ChecklistGoal(name, desc, point, target, bonus));  
                Console.WriteLine("");  
                break;

            default:
                break;
        }       
    }

    public void RecordEvent()
    {
        // Asks the user which goal they have completed and then records the event by calling that goal's RecordEvent method.
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        if(choice >=1 && choice <= _goals.Count)
        {
            Goal selected = _goals[choice - 1];
            selected.RecordEvent();
            _score += selected.GetPoints();            

            Console.WriteLine($"You now have {_score} points.");   
            Console.WriteLine(""); 

            if (_goals.Where(g => !(g is EternalGoal)).All(g => g.IsComplete()))
            {
                Console.WriteLine("Congratulations! You have completed all your goals!");
                Console.WriteLine("Eternal goals are always active. : )\n");
            } 
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }               
    }

    public void SaveGoals()
    {
        // Saves the list of goals to a file.
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        _fileManager.SaveToFile(_score, _goals, fileName);
        Console.WriteLine("");
    }

    public void LoadGoals()
    {
        // Loads the list of goals from a file.
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        _fileManager.LoadFromFile(fileName, _goals, ref _score);
        Console.WriteLine("");
    }

}