using System;
using System.Threading;

class StretchingActivity : Activity
{
    public StretchingActivity() : base("Stretching Activity", "This activity will guide you through simple stretching exercises to relax your muscles and improve flexibility.") { }

    public override void PerformActivity(int duration)
    {
        DisplayStartMessage(duration);

        for (int i = 0; i < duration / 5; i++)
        {
            Console.WriteLine("\nStretch your arms upward...");
            DisplayStretchCountdown(3); // For the "Stretch upward" phase
            Console.WriteLine("\nStretch your arms backward...");
            DisplayStretchCountdown(2); // For the "Stretch backward" phase
        }

        DisplayEndMessage(duration);
    }

    private void DisplayStretchCountdown(int initialCount)
    {
        int delay = 500; // Initial delay in milliseconds
        for (int i = initialCount; i > 0; i--)
        {
            Console.Write($"\rStretch...{new string('.', initialCount - i + 1)}");
            Thread.Sleep(delay * (i + 1)); // Adjust the delay to create the desired effect
        }
        Console.Write("\r           \r"); // Clear the countdown
    }
}