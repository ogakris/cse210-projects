
using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine();
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Your score: {score}");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Create New Goal selected.");
                    break;

                case 2:
                    Console.WriteLine("List Goals selected.");
                    break;

                case 3:
                    Console.WriteLine("Record Event selected.");
                    break;

                case 4:
                    Console.WriteLine("Save Goals selected.");
                    break;

                case 5:
                    Console.WriteLine("Load Goals selected.");
                    break;

                case 6:
                    Console.WriteLine("Thank you for using Eternal Quest!");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }
        }
    }
}
```
