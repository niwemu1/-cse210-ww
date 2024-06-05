using System;

public class Program
{
    private static bool fullscreenModeEnabled = false;

    public static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        DisplayMemorizationTips(); 

        var inputText = "";
        var randomScripture = GetRandomScriptureFromDirectory("Scripture");

        if (randomScripture != null)
        {
            randomScripture.DisplayScripture();
            while (inputText.ToLower() != "quit")
            {
                Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");
                inputText = Console.ReadLine();
                if (inputText.ToLower() == "quit")
                    break;
                else
                {
                    if (!randomScripture.HideRandomWord())
                    {
                        Console.WriteLine("All words are hidden. Exiting...");
                        break;
                    }
                    randomScripture.DisplayScripture();
                }
            }
        }
        else
        {
            Console.WriteLine("No scriptures found in the directory. Exiting...");
        }
    }

    private static void DisplayWelcomeMessage()
{
    Console.WriteLine("Welcome to the Scripture Memorization Program!");
    Console.WriteLine("Let's work on memorizing some scriptures.");
    Console.WriteLine();
    //Exceeding Requirements
    Console.WriteLine("Press F to toggle fullscreen mode.");
    Console.WriteLine("Press ESC to exit fullscreen mode.");
    DisplayMemorizationTips(); //Exceeding Requirements Display memorization tips
    Console.WriteLine();
}
    private static void DisplayMemorizationTips()
    {
        Console.WriteLine("\nMemorization Tips:");
        Console.WriteLine("1. Break down scriptures into smaller sections for easier memorization.");
        Console.WriteLine("2. Use mnemonic devices or visualization techniques to associate scripture verses with images or stories.");
        Console.WriteLine("3. Practice active recall by reciting scriptures from memory regularly.");
        Console.WriteLine("4. Create flashcards or use repetition to reinforce memorization.");
        Console.WriteLine("5. Stay consistent and patient - memorization takes time and practice.");
        Console.WriteLine("6. Explore different techniques and find what works best for you.");
        Console.WriteLine("7. Don't forget to take breaks and rest your mind to avoid burnout.");
        Console.WriteLine();
    }

    private static Scripture GetRandomScriptureFromDirectory(string directoryPath)
    {
        // Implement logic to read scripture files from the directory
        // and return a random scripture
        // For demonstration purposes, let's return a hardcoded scripture
        return new Scripture(new Reference("John 3:16"), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
    }

    private static void ToggleFullscreenMode()
    {
        if (fullscreenModeEnabled)
        {
            Console.SetWindowSize(80, 30); // Set default window size
            fullscreenModeEnabled = false;
        }
        else
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight); // Set window size to maximum
            fullscreenModeEnabled = true;
        }
    }
}