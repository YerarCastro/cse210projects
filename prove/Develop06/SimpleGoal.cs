public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
            return Points;
        }
        return 0; // No points if already completed
    }

    public override string GetDetailsString()
    {
        return isComplete ? $"[X] {Name}" : $"[ ] {Name}";
    }
}
