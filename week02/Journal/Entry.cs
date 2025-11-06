public class Entry{
    public string _date;
    public string _answer;
    public string _prompt;
    PromptGenerator _promptGenerator = new PromptGenerator();
      

    public void Display(){
        DateTime theCurrentTime = DateTime.Now;   
        _date = theCurrentTime.ToShortDateString();

        _prompt = _promptGenerator.GetRandomPrompt();        
        Console.WriteLine(_prompt);
        
        _answer = Console.ReadLine();                
    }
}