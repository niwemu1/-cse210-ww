using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter your choice:");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateGoal(goalManager);
                        break;
                    case 2:
                        RecordEvent(goalManager);
                        break;
                    case 3:
                        goalManager.DisplayGoals();
                        break;
                    case 4:
                        goalManager.DisplayScore();
                        break;
                    case 5:
                        Console.Write("Enter filename to save goals: ");
                        string saveFileName = Console.ReadLine();
                        goalManager.SaveGoals(saveFileName);
                        break;
                    case 6:
                        Console.Write("Enter filename to load goals: ");
                        string loadFileName = Console.ReadLine();
                        goalManager.LoadGoals(loadFileName);
                        break;
                    case 7:
                        Console.WriteLine("Exiting the program.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void CreateGoal(GoalManager goalManager)
{
    Console.WriteLine("Enter goal type (1. Simple, 2. Checklist, 3. Eternal, 4. Negative):");
    if (int.TryParse(Console.ReadLine(), out int typeChoice))
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        
        Goal goal = null;
        switch (typeChoice)
        {
            case 1:
                goal = CreateSimpleGoal(name);
                break;
            case 2:
                goal = CreateChecklistGoal(name);
                break;
            case 3:
                goal = CreateEternalGoal(name);
                break;
            case 4:
                goal = CreateNegativeGoal(name);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
        if (goal != null)
        {
            goalManager.CreateGoal(goal);
            Console.WriteLine($"Goal '{name}' created successfully.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}

    static void RecordEvent(GoalManager goalManager)
{
    Console.WriteLine("Enter goal name to mark as complete:");
    string name = Console.ReadLine();
    
    Goal goal = goalManager.GetGoalByName(name);
    if (goal != null)
    {
        if (goal is NegativeGoal)
        {
            int pointsLost = goal.MarkComplete();
            Console.WriteLine($"Sorry! You lost {Math.Abs(pointsLost)} points for engaging in the negative behavior: {name}");
        }
        else
        {
            int pointsEarned = goal.MarkComplete();
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points for completing the goal: {name}");
        }
    }
    else
    {
        Console.WriteLine($"Error: Goal '{name}' not found.");
    }
}
    static SimpleGoal CreateSimpleGoal(string name)
    {
        Console.WriteLine("Enter points for completing the goal:");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            return new SimpleGoal(name, points);
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting points to 0.");
            return new SimpleGoal(name, 0);
        }
    }

    static ChecklistGoal CreateChecklistGoal(string name)
    {
        Console.WriteLine("Enter points per completion:");
        if (int.TryParse(Console.ReadLine(), out int pointsPerCompletion))
        {
            Console.WriteLine("Enter target count:");
            if (int.TryParse(Console.ReadLine(), out int targetCount))
            {
                Console.WriteLine("Enter bonus points:");
                if (int.TryParse(Console.ReadLine(), out int bonusPoints))
                {
                    return new ChecklistGoal(name, pointsPerCompletion, targetCount, bonusPoints);
                }
            }
        }
        Console.WriteLine("Invalid input. Creating default checklist goal.");
        return new ChecklistGoal(name, 0, 0, 0);
    }

    static EternalGoal CreateEternalGoal(string name)
    {
        Console.WriteLine("Enter points for completing the goal:");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            return new EternalGoal(name, points);
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting points to 0.");
            return new EternalGoal(name, 0);
        }
    }

    static NegativeGoal CreateNegativeGoal(string name)
    {
        Console.WriteLine("Enter penalty points for engaging in negative behavior:");
        if (int.TryParse(Console.ReadLine(), out int penaltyPoints))
        {
            return new NegativeGoal(name, penaltyPoints);
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting penalty points to 0.");
            return new NegativeGoal(name, 0);
        }
    }
}