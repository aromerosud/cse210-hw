using System.Collections;

public class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();   
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        // Splits text into words and creates Word objects
        string[] arrayWords = text.Split(" ");        

        _reference = reference;
        foreach (string item in arrayWords)
        {
            Word word = new Word(item);
            _words.Add(word);
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word item in _words)
        {
            if (!item.IsHidden())
            {
                visibleWords.Add(item);
            }
        }

        if (visibleWords.Count == 0)
        {
            return;
        }

        int wordsHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }


    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string scriptureResult = string.Empty;
        foreach (Word item in _words)
        {
            scriptureResult = scriptureResult + " " + item.GetDisplayText();
        }
        return reference + " " + scriptureResult;
    }


    public bool IsCompletelyHidden()
    {
        bool result = true;
        foreach (Word item in _words)
        {
            if (!item.IsHidden())
            {
                result = false;
                break;
            }         
        }
        return result;             
    }
}