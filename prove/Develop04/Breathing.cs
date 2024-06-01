using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void PerformActivity(int duration)
    {
        DisplayStartMessage(duration);

        for (int i = 0; i < duration / 5; i++)
        {
            Console.WriteLine($"\nBreathe in...");
            DisplayCountdown(5);
            Console.WriteLine($"\nBreathe out...");
            DisplayCountdown(5);
            
        }

        DisplayEndMessage(duration);
    }

    private void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r... {i:D2}  "); 
            Thread.Sleep(1000);
        }
        Console.Write("\r        ");
    }
}