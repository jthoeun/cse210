using System;

class Comment
{
    private string _commenterName;
    private string _text;
    private DateTime _timestamp;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
        _timestamp = DateTime.Now;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }

    public DateTime GetTimestamp()
    {
        return _timestamp;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"[{_timestamp}] {_commenterName}: {_text}");
    }
}