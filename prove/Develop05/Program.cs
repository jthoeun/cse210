class Program
{
    static void Main()
    {
        User user = new User("John Doe");
        while (true)
        {
            Console.WriteLine("\n1. Create a New Goal");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine("1. Simple 2. Eternal 3. Checklist");
                    Console.Write("Choice: ");
                    string type = Console.ReadLine();
                    if (type == "1") user.CreateGoal(new SimpleGoal(name, description, points));
                    else if (type == "2") user.CreateGoal(new EternalGoal(name, description, points));
                    else if (type == "3")
                    {
                        Console.Write("Target Count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus Points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        user.CreateGoal(new ChecklistGoal(name, description, points, target, bonus));
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
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
