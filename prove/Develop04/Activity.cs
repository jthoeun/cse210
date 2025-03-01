using System;
using System.Threading;

abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {Name}");
        Console.WriteLine(Description);
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);

        RunActivity();

        EndActivity();
    }

    protected abstract void RunActivity();

    protected void EndActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {Name} for {Duration} seconds.");
        Logger.SaveLog(Name, Duration);
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{new string('.', i)}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}