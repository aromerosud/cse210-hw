public class PromptGenerator{
    public string _nameFile = "prompts.csv";
    public string _prompt;
    public FileManager _fileManager = new FileManager();
    
    public string GetRandomPrompt(){
        var _data = _fileManager.LoadFromFile(_nameFile);
        if(_data.Count > 0){
            Console.WriteLine("Answer the following question and press Enter to continue.");
            var _random = new Random();
            int _index = _random.Next(_data.Count);
            var _randomPrompt = _data[_index]; 
            _prompt = string.Join(" | ", _randomPrompt);
        }
        return _prompt;
    }
}