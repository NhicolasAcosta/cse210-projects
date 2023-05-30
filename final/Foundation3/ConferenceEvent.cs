public class ConferenceEvent:Event
{
    private string speakerName;
    private int capacity;

    public string SpeakerName
    {
        get {return speakerName;}
        set {speakerName = value;}
    }

    public int Capacity
    {
        get {return capacity;}
        set {capacity = value;}
    }

    public override string GenerateFullDetailsMessage()
    {
        return base.GenerateFullDetailsMessage() + $"Event Type: Conference\nSpeaker Name: {SpeakerName}\nCapacity: {Capacity}\n";
    }
}
