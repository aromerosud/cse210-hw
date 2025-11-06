public class Menu{
    public List<string> _optionsIni = new List<string>();
    
    public string _option; 

    public string DisplayMenu(){
         _optionsIni = ["1. Write", "2. Display", "3. Load", "4. Save", "5. Load All Journals", "6. Quit"];        

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