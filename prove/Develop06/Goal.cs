public abstract class Goal
{
    public string Name { get; }
    public int Points { get; }

    protected Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetDetailsString();
}
