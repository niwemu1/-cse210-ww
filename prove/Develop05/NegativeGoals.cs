// NegativeGoal class
class NegativeGoal : Goal
{
    private int penaltyPoints;

    public NegativeGoal(string name, int penaltyPoints) : base(name)
    {
        this.penaltyPoints = penaltyPoints;
    }

    public override int MarkComplete()
    {
        // Deduct penalty points for engaging in negative behavior
        score -= penaltyPoints;
        completed = true; // Mark the negative goal as completed
        return -penaltyPoints; // Return negative points earned
    }

    // No need to override GetPointsEarned for NegativeGoal
    // This method is inherited from the base class and can be kept as is.
}