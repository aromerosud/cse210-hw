public class Menu
{
    private List<string> _options;
    private string _action; 

    public string DisplayMenu(){
         _options = ["1. Start breathing activity", "2. Start reflecting activity", "3. Start listing activity", "4. Quit"];        

        Console.WriteLine("Menu Options: ");
        foreach (var item in _options)
        {
            Console.WriteLine(item);
        } 
        Console.Write("Select a choice from the menu: ");
        _action = Console.ReadLine();  
        return _action;      
    }
}