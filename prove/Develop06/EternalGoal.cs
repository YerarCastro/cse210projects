public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return Points; // Always earn points for each recording
    }

    public override string GetDetailsString()
    {
        return $"[ ] {Name}";
    }
}
