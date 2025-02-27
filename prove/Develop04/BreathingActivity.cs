using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity helps you relax by guiding you through slow breathing.";
    }

    protected override void RunActivity()
    {
        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(3);
            elapsedTime += 3;

            if (elapsedTime >= Duration) break;

            Console.WriteLine("Breathe out...");
            PauseWithAnimation(3);
            elapsedTime += 3;
        }
    }
}