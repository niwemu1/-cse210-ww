using System;

public abstract class Activity
{
    private DateTime startTime;
    private string name;

    public Activity(string name, DateTime startTime)
    {
        this.name = name;
        this.startTime = startTime;
    }

    public string Name { get { return name; } }
    public DateTime StartTime { get { return startTime; } }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed(double durationInMinutes)
    {
        return GetDistance() / durationInMinutes * 60;
    }

    public virtual double GetPace(double distance)
    {
        return distance == 0 ? 0 : 60 / GetSpeed(GetDuration().TotalMinutes);
    }

    public TimeSpan GetDuration()
    {
        return DateTime.Now - startTime;
    }

    public virtual string GetSummary()
    {
        return $"Name: {Name}\nStart Time: {StartTime.ToString("yyyy-MM-dd HH:mm")}\nDuration: {GetDuration().ToString("hh:mm:ss")}";
    }
}

public class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(string name, DateTime startTime, double distance) : base(name, startTime)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }
}

public class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(string name, DateTime startTime, int laps) : base(name, startTime)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Distance in kilometers
    }

    public override double GetDistance(bool useMiles)
    {
        if (useMiles)
        {
            return laps * 50 / 1000.0 * 0.62; // Distance in miles
        }
        return GetDistance();
    }
}

public class CyclingActivity : Activity
{
    private double distance;

    public CyclingActivity(string name, DateTime startTime, double distance) : base(name, startTime)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }
}