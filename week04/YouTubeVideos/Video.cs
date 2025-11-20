using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

public class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberComment()
    {
        return _comments.Count;
    }

    public string GetVideos()
    {
        string result =  $"\nTitle: {_title}\n Author: {_author}\n Time: {_duration} seconds\n";
        result += $"Number o comments: {GetNumberComment()}\n";
        result += "Comments:\n";

        foreach(Comment item in _comments)
        {
            result += $"- {item.GetComment()}\n";
        }

        return result;
        
    }
}