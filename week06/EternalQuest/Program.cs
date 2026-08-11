using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            DisplayMenu();

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoals();
                    break;

                case "3":
                    RecordEvent();
                    break;

                case "4":
                    DisplayScore();
                    break;

                case "5":
                    SaveGoals();
                    break;

                case "6":
                    LoadGoals();
                    break;

                case "7":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Eternal Quest");
        Console.WriteLine("-------------------------");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Display Score");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Load Goals");
        Console.WriteLine("7. Quit");
        Console.WriteLine("-------------------------");
    }

    static void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            SimpleGoal goal = new SimpleGoal(
                name,
                description,
                points
            );

            _goals.Add(goal);
        }
        else if (type == "2")
        {
            EternalGoal goal = new EternalGoal(
                name,
                description,
                points
            );

            _goals.Add(goal);
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing the goal? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(
                name,
                description,
                points,
                target,
                bonus
            );

            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }

        Console.WriteLine("Goal created successfully.");
    }

    static void ListGoals()
    {
        Console.WriteLine();
        Console.WriteLine("Your Goals:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {_goals[i].GetDetailsString()}"
            );
        }
    }

    static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record.");
            return;
        }

        ListGoals();

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber < 1 || goalNumber > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[goalNumber - 1];

        if (goal.IsComplete())
        {
            Console.WriteLine("That goal has already been completed.");
            return;
        }

        int pointsEarned = goal.RecordEvent();

        _score += pointsEarned;

        Console.WriteLine();
        Console.WriteLine($"Congratulations! You earned {pointsEarned} points.");
        Console.WriteLine($"You now have {_score} points.");
    }

    static void DisplayScore()
    {
        Console.WriteLine();
        Console.WriteLine($"Your score is: {_score}");
    }

    static void SaveGoals()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty.");
            return;
        }

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "Simple")
            {
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(
                    name,
                    description,
                    points,
                    isComplete
                );

                _goals.Add(goal);
            }
            else if (type == "Eternal")
            {
                int timesCompleted = int.Parse(parts[4]);

                EternalGoal goal = new EternalGoal(
                    name,
                    description,
                    points,
                    timesCompleted
                );

                _goals.Add(goal);
            }
            else if (type == "Checklist")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(
                    name,
                    description,
                    points,
                    target,
                    bonus,
                    amountCompleted
                );

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}
