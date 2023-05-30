public class OutdoorMeetingEvent:Event
{
    private string weatherForecast;

    public string WeatherForecast
    {
        get {return weatherForecast;}
        set {weatherForecast = value;}
    }

    public override string GenerateFullDetailsMessage()
    {
        return base.GenerateFullDetailsMessage() + $"Event Type: Outdoor Meeting\nWeather Forecast: {WeatherForecast}\n";
    }
}
