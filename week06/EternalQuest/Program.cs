using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        goals.Add(new SimpleGoal(
            "Run a marathon",
            "Complete a marathon",
            1000));

        goals.Add(new EternalGoal(
            "Read scriptures",
            "Read scriptures every day",
            100));

        goals.Add(new ChecklistGoal(
            "Attend the temple",
            "Attend the temple 10 times",
            50,
            10,
            500));

        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

        Console.WriteLine();

        int points = goals[0].RecordEvent();

        Console.WriteLine($"You earned {points} points!");

        Console.WriteLine();

        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
}
