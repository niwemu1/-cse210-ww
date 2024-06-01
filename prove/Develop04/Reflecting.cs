using System;
using System.Threading;

class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public override void PerformActivity(int duration)
    {
        DisplayStartMessage(duration);

        string[] prompts = {
            "\nThink of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Countdown();

        string[] questions = {
            "\nWhy was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        DateTime startTime = DateTime.Now;
        TimeSpan elapsedTime = TimeSpan.Zero;

        foreach (string question in questions)
        {
            elapsedTime = DateTime.Now - startTime;
            if (elapsedTime.TotalSeconds >= duration)
                break;

            Console.WriteLine(question);
            DisplaySpinner();
            Thread.Sleep(3000); 
        }

        DisplayEndMessage((int)elapsedTime.TotalSeconds);
    }

    private void DisplaySpinner()
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(250);
        }
        Console.Write("\r   \r");
    }
}