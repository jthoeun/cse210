using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity helps you reflect on the good things in your life by listing them.";
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        Console.WriteLine("Think about your response...");
        PauseWithAnimation(5);

        Console.WriteLine("Start listing items. Press Enter after each item.");
        List<string> items = new List<string>();
        int elapsedTime = 0;

        while (elapsedTime < Duration)
        {
            if (Console.KeyAvailable)
            {
                items.Add(Console.ReadLine());
            }
            Thread.Sleep(1000);
            elapsedTime += 1;
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}