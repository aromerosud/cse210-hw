public class Memorize
{
    private FileManager _fileManager;
    private List<Entry> _entries;
    
    public void Start()    
    {
        try
        {
            // Inputs
            _fileManager = new FileManager();
            _entries = _fileManager.LoadFile();
            bool hasAction = true;
            string output;

            if(_entries.Count == 0)
            {
                Console.WriteLine("No scriptures found. Please create a new entry first.");
                return;
            }        

            Console.WriteLine("Select a scripture to practice: ");

            for (int i = 0; i < _entries.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_entries[i].DisplayText()}");
            }

            // Input loop
            int choice = 0;
            do
            {
                Console.WriteLine("Enter the number of the scripture: ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > _entries.Count);

            Console.WriteLine("Enter how many words to hide per round:");
            int wordsHide = int.Parse(Console.ReadLine());

            // Start Memorize Process
            Entry entryData = _entries[choice - 1];
            Reference _reference = new Reference(
                entryData.GetBook(), 
                entryData.GetChapter(), 
                entryData.GetVerse(), 
                entryData.GetEndVerse());
            Scripture _scripture = new Scripture(_reference, entryData.GetText());

            Console.Clear();  
            output = _scripture.GetDisplayText(); 
            Console.WriteLine("\n");
            Console.Write($"{output}");      

            while (hasAction)
            {          
                Console.Write($"Press enter to continue or type 'quit' to finish: ");
                string action = Console.ReadLine().ToLower().Trim();

                if (action.Equals(""))
                {                  
                    Console.Clear();                     
                    _scripture.HideRandomWords(wordsHide);                
                    output = _scripture.GetDisplayText(); 
                    Console.WriteLine("\n");
                    Console.WriteLine($"{output}");

                    if (_scripture.IsCompletelyHidden())
                    {
                        hasAction = false;
                    }
                }
                else if (action.Equals("quit"))
                {
                    hasAction = false;
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }            
            }
            // End Memorize Process 
        }
        catch
        {
            Console.WriteLine("Oops, you entered an invalid value.\n");
        }  
    } 

    public void SaveEntry()
    {
        try
        {
            // User Inputs
            _fileManager = new FileManager();
            Console.WriteLine("Enter the book:");
            string book = Console.ReadLine();

            Console.WriteLine("Enter the chapter:");
            int chapter = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the starting verse:");
            int startVerse = int.Parse(Console.ReadLine());

            Console.WriteLine("Is there an ending verse? (y/n)");
            string hasEnd = Console.ReadLine().ToLower().Trim();

            int endVerse = 0;
            if (hasEnd == "y")
            {
                Console.WriteLine("Enter the ending verse:");
                endVerse = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the scripture text:");
            string text = Console.ReadLine();

            // Create Entry
            Entry entry;
            if (endVerse == 0)
            {
                entry = new Entry(book, chapter, startVerse, text);
            }
            else
            {
                entry = new Entry(book, chapter, startVerse, endVerse, text);
            }                

            // Save Entry
            _fileManager.SaveToFile(entry);

            Console.WriteLine("Scripture saved successfully!");
        }
        catch
        {
            Console.WriteLine("Oops, you entered an invalid value.\n");
        }        
    }   
}