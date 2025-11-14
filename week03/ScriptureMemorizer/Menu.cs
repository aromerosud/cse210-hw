public class Menu
{
    private List<string> _optionsIni = new List<string>();
    private string _option; 

    public string DisplayMenu(){
         _optionsIni = ["1. Create new scripture entry", "2. Practice memorization", "3. Quit"];        

        Console.WriteLine("Please select one of the following choices: ");
        foreach (var item in _optionsIni)
        {
            Console.WriteLine(item);
        } 
        Console.Write("What would you like to do? ");
        _option = Console.ReadLine();  
        return _option;      
    }

}