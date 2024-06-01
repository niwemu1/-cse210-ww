class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void PerformActivity(int duration)
    {
        DisplayStartMessage(duration);

        string[] prompts = {
            "\nWho are people that you appreciate?",
            "\nWhat are personal strengths of yours?",
            "\nWho are people that you have helped this week?",
            "\nWhen have you felt the Holy Ghost this month?",
            "\nWho are some of your personal heroes?"
        };

        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("\nBegin listing...");

        DateTime startTime = DateTime.Now;
        TimeSpan elapsedTime = TimeSpan.Zero;
        int itemsCount = 0;

        while ((elapsedTime = DateTime.Now - startTime).TotalSeconds < duration)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                itemsCount++;

            DisplaySpinner();
            Thread.Sleep(500);
        }

        Console.WriteLine($"\nYou listed {itemsCount} items.");
        DisplayEndMessage((int)elapsedTime.TotalSeconds);
    }

    private void DisplaySpinner()
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(125);
        }
        Console.Write("\r   \r"); 
    }
}