using System;

class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create sample activities
        activities.Add(new RunningActivity("Morning Run", DateTime.Now.Subtract(hours: 1), 5.0));
        activities.Add(new SwimmingActivity("Pool Workout", DateTime.Now.Subtract(hours: 2), 20));
        activities.Add(new CyclingActivity("Bike Ride", DateTime.Now.Subtract(hours: 3), 10.0));

        // Display summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            if (activity is SwimmingActivity)
            {
                Console.WriteLine($"Distance (km): {((SwimmingActivity)activity).GetDistance()}");
                Console.WriteLine($"Distance (miles): {((SwimmingActivity)activity).GetDistance(true)}");
            }
            else
            {
                Console.WriteLine($"Distance: {activity.GetDistance()}");
            }
            Console.WriteLine($"Speed: {activity.GetSpeed(activity.GetDuration().TotalMinutes)} mph");
            Console.WriteLine($"Pace: {activity.GetPace(activity.GetDistance())} min/mile");
            Console.WriteLine("\n");
        }
    }
}