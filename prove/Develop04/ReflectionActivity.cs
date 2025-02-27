using System;
using System.Threading;

class ReflectionActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "This activity helps you reflect on past experiences of strength and resilience.";
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        PauseWithAnimation(5);

        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine(Questions[random.Next(Questions.Length)]);
            PauseWithAnimation(5);
            elapsedTime += 5;
        }
    }
}