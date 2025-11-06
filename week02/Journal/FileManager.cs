public class FileManager{
    private string _masterFile = "journals_list.txt";
    
    public void SaveToFile(List<Entry> _entries, string nameFile){
        using (StreamWriter outputFile = new StreamWriter(nameFile, true))
        {
            foreach(Entry item  in _entries){
                outputFile.WriteLine($"Date: {item._date} - Prompt: {item._prompt}");
                outputFile.WriteLine($"{item._answer}");
                outputFile.WriteLine($" ");
            }
        } 
    }

    public void SaveToJournalFiles(string nameFile){
        var existingFiles = new HashSet<string>();
        if (File.Exists(_masterFile))
        {
            existingFiles = File.ReadAllLines(_masterFile).ToHashSet();
        }

        if (!existingFiles.Contains(nameFile))
        {
            using (StreamWriter outputFile = File.AppendText(_masterFile))
            {
                outputFile.WriteLine(nameFile);
            }
        }
    }

    public List<string[]> LoadFromFile(string nameFile){
        var lines = new List<string[]>();
            using (var reader = new StreamReader(nameFile)){
            reader.ReadLine();
                while (!reader.EndOfStream){
                var line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var values = line.Split(',');
                lines.Add(values);
                }
            }
        return lines;
    }

    public List<Entry> LoadFromFileJournals(string fileName){
        var entries = new List<Entry>();
        try{
            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string datePromptLine = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(datePromptLine)) continue;
                    string answerLine = reader.ReadLine() ?? "";

                    int promptIndex = datePromptLine.IndexOf(" - Prompt: ");
                    string date = datePromptLine.Substring(6, promptIndex - 6);
                    string prompt = datePromptLine.Substring(promptIndex + 10);

                    entries.Add(new Entry
                    {
                        _date = date,
                        _prompt = prompt,
                        _answer = answerLine
                    });
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file '{fileName}' was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }        
        return entries;
    }

    public List<string> GetAllJournalFiles()
    {
        if (!File.Exists(_masterFile)){
            return new List<string>();
        }            

        return File.ReadAllLines(_masterFile).ToList();
    }
}