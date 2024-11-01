using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine($"Goal '{goal.Name}' added.");
    }

    public void RecordGoal(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == goalName)
            {
                totalScore += goal.RecordEvent();
                Console.WriteLine($"Recorded goal: {goalName}. You earned {goal.Points} points!");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void ShowGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"Total Score: {totalScore}");
    }
}
