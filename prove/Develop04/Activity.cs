using System;
using System.Threading;

abstract class Activity
{
    protected string name;
    protected string description;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void DisplayStartMessage(int duration)
    {
        Console.WriteLine($"\nStarting {name} for {duration} seconds:");
        Console.WriteLine(description);
        Countdown();
    }

    public void DisplayEndMessage(int duration)
    {
        Console.WriteLine("\nCongratulations! You've completed the activity.");
        Console.WriteLine($"You spent {duration} seconds on {name}.");
    }

    protected void Countdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\rBegin in.... {i}"); 
            Thread.Sleep(1000);
            
        }
    }

    public abstract void PerformActivity(int duration);
}