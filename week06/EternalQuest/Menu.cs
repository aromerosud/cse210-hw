public class Menu
{
    private List<string> _options;
    private List<string> _optionGoals;
    private string _action; 

    public Menu()
    {
         _options = ["1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit"]; 
         _optionGoals = ["1. Simple Goal", "2. Eternal Goal", "3. Checklist Goal"]; 
    }

    public string DisplayMenu(){               

        Console.WriteLine("Menu Options: ");
        foreach (var item in _options)
        {
            Console.WriteLine(item);
        } 
        Console.Write("Select a choice from the menu: ");
        _action = Console.ReadLine();  
        return _action;      
    }

    public string DisplayMenuGoals()
    {

        Console.WriteLine("The types of Goals are:");
        foreach(var item in _optionGoals)
        {
            Console.WriteLine(item);
        }
        Console.Write("Which type of goal would you like to create? ");
        _action = Console.ReadLine();
        return _action;
    }
}