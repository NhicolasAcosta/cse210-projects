public class ReceptionEvent:Event
{
    private string rsvpEmail;
    public string RsvpEmail
    {
        get {return rsvpEmail;}
        set {rsvpEmail = value;}
    }

    public override string GenerateFullDetailsMessage()
    {
        return base.GenerateFullDetailsMessage() + $"Event Type: Reception\nRSVP Email: {RsvpEmail}\n";
    }
}
