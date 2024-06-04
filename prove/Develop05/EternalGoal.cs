using System;

// Eternal goal subclass
[Serializable]
class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name)
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