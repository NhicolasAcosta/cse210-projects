using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Making the example events
        ConferenceEvent conferenceEvent = new ConferenceEvent
        {
            Title = "Conference Event",
            Description = "A conference with Elder Holland",
            Date = new DateTime(2023, 6, 15),
            Address = "123 Main Street",
            SpeakerName = "Jefrey R. Holland",
            Capacity = 200
        };
        ReceptionEvent receptionEvent = new ReceptionEvent
        {
            Title = "Reception Event",
            Description = "A networking reception",
            Date = new DateTime(2023, 6, 20),
            Address = "456 Park Avenue",
            RsvpEmail = "example@example.com"
        };
        OutdoorMeetingEvent outdoorMeetingEvent = new OutdoorMeetingEvent
        {
            Title = "Outdoor Meeting Event",
            Description = "A meeting in the park",
            Date = new DateTime(2023, 6, 25),
            Address = "Central Park",
            WeatherForecast = "Sunny"
        };

        // Generate marketing messages for each events
        List<Event> events = new List<Event> {conferenceEvent, receptionEvent, outdoorMeetingEvent};
        foreach (Event e in events)
        {
            Console.WriteLine("***** Standard Details *****");
            Console.WriteLine(e.GenerateStandardMessage());

            Console.WriteLine("***** Full Details *****");
            Console.WriteLine(e.GenerateFullDetailsMessage());

            Console.WriteLine("***** Short Description *****");
            Console.WriteLine(e.GenerateShortDescription());

            Console.WriteLine("*************************");
        }
    }
}
