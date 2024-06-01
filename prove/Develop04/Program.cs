using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity(),
            new StretchingActivity()
        };

        Console.WriteLine("Welcome to Mindfulness Activity Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Streching Activity");
            Console.WriteLine("5. Quit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice >5 )
            {
                Console.WriteLine("Invalid choice. Please select again.");
                continue;
            }

            if (choice == 5)
            {
                Console.WriteLine("Thank you for using the program. Goodbye!");
                break;
            }

            Activity activity = activities[choice - 1];
            Console.WriteLine("Enter the duration of the activity in seconds:");
            int duration;
            if (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.WriteLine("Invalid duration. Please enter a positive integer.");
                continue;
            }

            activity.PerformActivity(duration);
        }
    }
}