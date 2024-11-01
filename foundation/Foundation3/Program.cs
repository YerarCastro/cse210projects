using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities with at least one of each type
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 30, 20.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 40)
        };

        // Display the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
