using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 15.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 24.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 60, 20));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 60, 30));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

