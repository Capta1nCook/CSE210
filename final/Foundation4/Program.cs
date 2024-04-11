using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(30, 3);
        Cycling cycling = new Cycling(60, 15);
        Swimming swimming = new Swimming(30, 50);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.Display();
        }
    }
}