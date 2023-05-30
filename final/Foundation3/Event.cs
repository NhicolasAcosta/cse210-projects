using System;

public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string address;

    public string Title
    {
        get {return title;}
        set {title = value;}
    }

    public string Description
    {
        get {return description;}
        set {description = value;}
    }

    public DateTime Date
    {
        get {return date;}
        set {date = value;}
    }

    public string Address
    {
        get {return address;}
        set {address = value;}
    }

    public virtual string GenerateStandardMessage()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nAddress: {Address}\n";
    }

    public virtual string GenerateFullDetailsMessage()
    {
        return GenerateStandardMessage();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {Title}\nDate: {Date}\n";
    }
}
