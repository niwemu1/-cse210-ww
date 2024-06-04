using System;

// Checklist goal subclass
[Serializable]
class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;
    private int pointsPerCompletion;
    private int bonusPoints;

    public ChecklistGoal(string name, int pointsPerCompletion, int targetCount, int bonusPoints) : base(name)
    {
        this.pointsPerCompletion = pointsPerCompletion;
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
    }

    public override int MarkComplete()
    {
        if (!completed)
        {
            completedCount++;
            if (completedCount >= targetCount)
            {
                completed = true;
                return score + bonusPoints;
            }
            else
            {
                return pointsPerCompletion;
            }
        }
        return 0;
    }

    public override string DisplayProgress()
    {
        string status = completed ? "[X]" : "[ ]";
        return $"{status} {name} - Completed {completedCount}/{targetCount} times";
    }
}