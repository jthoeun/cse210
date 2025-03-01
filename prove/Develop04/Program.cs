using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else if (choice == "4")
            {
                Logger.LoadLogs();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else
            {
                Activity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    _ => null
                };

                if (activity != null)
                {
                    activity.StartActivity();
                }
            }
        }
    }
}