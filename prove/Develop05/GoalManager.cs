using System;
using System.Collections.Generic;

// Goal Manager class
class GoalManager
{
    private List<Goal> goals;

    public GoalManager()
    {
        goals = new List<Goal>();
    }

    // Method to create new goals of any type
    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
    }

    // Method to record an event (accomplished goal) and update score
    public void RecordEvent(string goalName)
    {
        Goal goal = GetGoalByName(goalName);
        if (goal != null)
        {
            if (goal is NegativeGoal)
            {
                int pointsLost = goal.MarkComplete();
                Console.WriteLine($"Sorry! You lost {Math.Abs(pointsLost)} points for engaging in the negative behavior: {goalName}");
            }
            else
            {
                int pointsEarned = goal.MarkComplete();
                Console.WriteLine($"Congratulations! You earned {pointsEarned} points for completing the goal: {goalName}");
            }
        }
        else
        {
            Console.WriteLine($"Error: Goal '{goalName}' not found.");
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.DisplayProgress());
        }
    }

    public void DisplayScore()
    {
        int totalScore = 0;
        foreach (Goal goal in goals)
        {
            if (goal.Completed)
            {
                totalScore += goal.Score;
            }
        }
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void SaveGoals(string filename)
    {
        // Serialize and save goals to a file
    }

    public void LoadGoals(string filename)
    {
        // Deserialize and load goals from a file
    }

    // Method to get a goal by its name
    public Goal GetGoalByName(string name)
    {
        return goals.Find(g => g.Name == name);
    }
}