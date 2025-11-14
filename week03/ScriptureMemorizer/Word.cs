public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string textResult = string.Empty;
        if (_isHidden)
        {
            textResult = new string('_', _text.Length);
        }
        else
        {
            textResult = _text;
        }
        return textResult;
    }
}