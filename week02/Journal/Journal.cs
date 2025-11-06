using System;

public class Journal{
    public string _nameSaveFile;
    public string _nameLoadFile;
    public List<Entry> _entries = new List<Entry>();    
    public FileManager _fileManager = new FileManager();
    
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach(Entry item  in _entries){
            Console.WriteLine($"Date: {item._date} - Prompt: {item._prompt}");
            Console.WriteLine($"{item._answer}");
            Console.WriteLine($" ");
        }
    }
    
    public void SaveEntries(List<Entry> newEntries){
        Console.WriteLine("What is the filename? ");
        _nameSaveFile = Console.ReadLine();
        _fileManager.SaveToFile(newEntries, _nameSaveFile);
        _fileManager.SaveToJournalFiles(_nameSaveFile);
    }

    public void GetEntries(){
        Console.WriteLine("What is the filename? ");
        _nameLoadFile = Console.ReadLine();
        _entries = _fileManager.LoadFromFileJournals(_nameLoadFile);        
    }

    public void LoadAllJournals(Journal journal)
    {
        _entries.Clear();
        var fileNames = _fileManager.GetAllJournalFiles();
        foreach (var file in fileNames)
        {
            var entries = _fileManager.LoadFromFileJournals(file);
            foreach (var item in entries){
                journal.AddEntry(item);
            }                
        }
    }    
}