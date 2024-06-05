using System;

class Program
{
    private Journal journal = new Journal();
    private string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Length)];
    }

    private void WriteNewEntry(string prompt)
    {
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        journal.AddEntry(prompt, response, date);
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\n*** Journal Menu ***");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Get a writing prompt"); // Option to get a writing prompt
        Console.WriteLine("6. Exit");
    }

    private void DisplayWritingPrompt()
    {
        string prompt = journal.GetRandomWritingPrompt();
        WriteNewEntry(prompt);
        Console.WriteLine("Entry added successfully.");
    }

    public void Run()
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = GetRandomPrompt();
                    WriteNewEntry(randomPrompt);
                    Console.WriteLine("Entry added successfully.");
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter file name to save journal: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveJournal(saveFileName);
                    Console.WriteLine("Journal saved successfully.");
                    break;
                case "4":
                    Console.Write("Enter file name to load journal: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadJournal(loadFileName);
                    Console.WriteLine("Journal loaded successfully.");
                    break;
                case "5":
                    DisplayWritingPrompt(); // Display writing prompt when chosen
                    break;
                case "6":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}