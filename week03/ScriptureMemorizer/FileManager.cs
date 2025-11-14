public class FileManager
{
    private string _filePath = "scriptures.txt";

    public void SaveToFile(Entry entry)
    {
        try
        {
            string content =
                $"REFERENCE: {entry.DisplayText()}\n" +
                $"TEXT:\n{entry.GetText()}\n" +
                "-----------------------------\n";

            File.AppendAllText(_filePath, content);

            Console.WriteLine("Entry saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    public List<Entry> LoadFile()
    {
        var entries = new List<Entry>();

        if (!File.Exists(_filePath))
        {
            return entries;
        }

        string[] lines = File.ReadAllLines(_filePath);

        string book = "";
        int chapter = 0;
        int verse = 0;
        int endVerse = 0;
        string text = "";
        bool readingText = false;

        foreach (string line in lines)
        {
            if (line.StartsWith("REFERENCE:"))
            {
                if (!string.IsNullOrWhiteSpace(text))
                {
                    entries.Add(new Entry(book, chapter, verse, endVerse, text));
                    text = "";
                }

                string reference = line.Substring("REFERENCE:".Length).Trim();
                var parts = reference.Split(' ');

                int chapterVerseIndex = Array.FindIndex(parts, p => p.Contains(":"));
                book = string.Join(" ", parts.Take(chapterVerseIndex));

                var chapterVerse = parts[chapterVerseIndex].Split(':');
                chapter = int.Parse(chapterVerse[0]);

                var verseParts = chapterVerse[1].Split('-');
                verse = int.Parse(verseParts[0]);
                endVerse = (verseParts.Length > 1) ? int.Parse(verseParts[1]):0;

                readingText = false;                
            }
            else if (line.StartsWith("TEXT"))
            {
                readingText = true;                    
            }
            else if (line.StartsWith("-----------------------------"))
            {
                readingText = false;
                if (!string.IsNullOrWhiteSpace(text))
                {
                    entries.Add(new Entry(book, chapter, verse, endVerse, text));
                    text = "";
                }
            }
            else if (readingText)
            {
                text += line + "\n";
            }
        }

        if (!string.IsNullOrWhiteSpace(text))
        {
            entries.Add(new Entry(book, chapter, verse, endVerse, text));
        }

        return entries;
    }
}