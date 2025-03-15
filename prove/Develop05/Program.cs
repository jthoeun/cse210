using System;

class Program
{
    static void Main()
    {
        User user;
        string filename;

        Console.Write("Do you want to load your previous progress? (yes/no): ");
        string loadChoice = Console.ReadLine().ToLower();

        if (loadChoice == "yes")
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            filename = $"{name}.txt";

            if (System.IO.File.Exists(filename))
            {
                user = new User(name);
                user.LoadProgress(filename);
            }
            else
            {
                Console.WriteLine("No previous progress found. Starting new profile.");
                user = new User(name);
            }
        }
        else
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            filename = $"{name}.txt";
            user = new User(name);
        }

        while (true)
        {
            Console.WriteLine("\n1. Create a New Goal");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. Display Goals and Stats");
            Console.WriteLine("4. Save and Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Goal name: ");
                    string goalName = Console.ReadLine();
                    Console.Write("Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine("1. Simple 2. Eternal 3. Checklist");
                    Console.Write("Choice: ");
                    string type = Console.ReadLine();
                    if (type == "1")
                        user.CreateGoal(new SimpleGoal(goalName, description, points));
                    else if (type == "2")
                        user.CreateGoal(new EternalGoal(goalName, description, points));
                    else if (type == "3")
                    {
                        Console.Write("Target Count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus Points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        user.CreateGoal(new ChecklistGoal(goalName, description, points, target, bonus));
                    }
                    break;
                case "2":
                    Console.Write("Enter goal name: ");
                    user.RecordEvent(Console.ReadLine());
                    break;
                case "3":
                    user.DisplayGoals();
                    break;
                case "4":
                    user.SaveProgress(filename);
                    Console.WriteLine($"Progress saved to {filename}. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}