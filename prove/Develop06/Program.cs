using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record progress");
            Console.WriteLine("3. View progress");
            Console.WriteLine("4. View total points");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select the type of goal:");
                    Console.WriteLine("1. Simple goal");
                    Console.WriteLine("2. Eternal goal");
                    Console.WriteLine("3. Checklist goal");
                    string goalType = Console.ReadLine();

                    Console.Write("Goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == "1")
                    {
                        goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (goalType == "2")
                    {
                        goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (goalType == "3")
                    {
                        Console.Write("Number of times to complete: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Points per event: ");
                        int eventPoints = points;
                        Console.Write("Bonus upon completion: ");
                        int bonus = int.Parse(Console.ReadLine());
                        goals.Add(new ChecklistGoal(name, description, eventPoints, targetCount, bonus));
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Select a goal to record progress:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].Name}");
                    }
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    if (goalIndex >= 0 && goalIndex < goals.Count)
                    {
                        goals[goalIndex].RecordEvent();
                        totalPoints += goals[goalIndex].Points;
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal index.");
                    }
                    break;

                case "3":
                    foreach (var goal in goals)
                    {
                        Console.WriteLine(goal.GetProgress());
                    }
                    break;

                case "4":
                    Console.WriteLine($"Total points: {totalPoints}");
                    break;

                case "5":
                    Console.WriteLine("Thank you for using the program!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
