using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2025", 30, 4.8));
        activities.Add(new Cycling("04 Nov 2025", 45, 20.0));
        activities.Add(new Swimming("05 Nov 2025", 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}