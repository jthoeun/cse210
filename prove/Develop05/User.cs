class User
{
    private string _name;
    private List<Goal> _goals;
    private int _score;
    private int _level;

    public User(string name)
    {
        _name = name;
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = _goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordProgress();
            _score += goal.Points;
            CheckLevelUp();
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"Congratulations! You've leveled up to Level {_level}!");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine($"\n{_name}'s Goals (Level {_level}):");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetProgress()} {goal.Name} - {goal.Description}");
        }
        Console.WriteLine($"Total Score: {_score}\n");
    }
    public void SaveProgress(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_name);
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            writer.WriteLine(_goals.Count);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.GetProgress()}");
            }
        }
        Console.WriteLine("Progress saved successfully!");
    }
    public void LoadProgress(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved progress found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            _name = reader.ReadLine();
            _score = int.Parse(reader.ReadLine());
            _level = int.Parse(reader.ReadLine());
            int goalCount = int.Parse(reader.ReadLine());

            _goals.Clear();
            for (int i = 0; i < goalCount; i++)
            {
                string[] parts = reader.ReadLine().Split(',');
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = null;
                if (goalType == "SimpleGoal")
                    goal = new SimpleGoal(name, description, points);
                else if (goalType == "EternalGoal")
                    goal = new EternalGoal(name, description, points);
                else if (goalType == "ChecklistGoal")
                    goal = new ChecklistGoal(name, description, points, 10, 500); // Default values

                if (goal != null)
                {
                    goal.RecordProgress();
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Progress loaded successfully!");
    }
}