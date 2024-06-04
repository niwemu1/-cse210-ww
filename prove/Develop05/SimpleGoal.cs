using System;

// Simple goal subclass
[Serializable]
class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name)
    {
        score = points;
    }

    public override int MarkComplete()
    {
        if (!completed)
        {
            completed = true;
            return score;
        }
        return 0;
    }
}