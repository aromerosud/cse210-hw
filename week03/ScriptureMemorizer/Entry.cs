public class Entry
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _text;

    public Entry (string book, int chapter, int startVerse, string text)
    {
        // Constructor for single verse
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _text = text;        
    }

    public Entry (string book, int chapter, int startVerse, int endVerse, string text)
    {
        // Constructor for multiple verses
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _text = text;    
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerse()
    {
        return _startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void SetVerse(int verse)
    {
        _startVerse = verse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public string DisplayText()
    {
        string result;
        if (_endVerse == 0)
        {
            result = _book + " " + _chapter + ":" + _startVerse;            
        }
        else
        {
            result = _book + " " + _chapter + ":" + _startVerse + "-" + _endVerse;
        }
         
        return result;
    }    
}