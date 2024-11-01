using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to Eternal Quest!");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Goal");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal(goalManager);
                    break;
                case "2":
                    RecordGoal(goalManager);
                    break;
                case "3":
                    goalManager.ShowGoals();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddGoal(GoalManager goalManager)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                Console.Write("Enter the points for this goal: ");
                int simplePoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new SimpleGoal(name, simplePoints));
                break;
            case "2":
                Console.Write("Enter the points for this goal: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new EternalGoal(name, eternalPoints));
                break;
            case "3":
                Console.Write("Enter the points for each completion: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter the total number of times to complete: ");
                int totalTimes = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, checklistPoints, totalTimes, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordGoal(GoalManager goalManager)
    {
        Console.Write("Enter the name of the goal you want to record: ");
        string goalName = Console.ReadLine();
        goalManager.RecordGoal(goalName);
    }
}
