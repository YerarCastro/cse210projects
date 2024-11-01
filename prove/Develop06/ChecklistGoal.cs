public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int totalTimes;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int totalTimes, int bonusPoints) : base(name, points)
    {
        this.totalTimes = totalTimes;
        this.bonusPoints = bonusPoints;
        timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (timesCompleted < totalTimes)
        {
            timesCompleted++;
            return Points;
        }
        return 0; // No additional points after completion
    }

    public override string GetDetailsString()
    {
        return timesCompleted >= totalTimes ? $"[X] {Name} - Completed {timesCompleted}/{totalTimes} times" : $"[ ] {Name} - Completed {timesCompleted}/{totalTimes} times";
    }
}
