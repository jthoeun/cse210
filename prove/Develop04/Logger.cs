using System;
using System.IO;

class Logger
{
    private static string logFilePath = "activity_log.txt";

    public static void SaveLog(string activityName, int duration)
    {
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: Completed {activityName} for {duration} seconds.");
        }
    }

    public static void LoadLogs()
    {
        if (File.Exists(logFilePath))
        {
            string[] logs = File.ReadAllLines(logFilePath);
            Console.WriteLine("\n--- Activity Log ---");
            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }
            Console.WriteLine("----------------------");
        }
        else
        {
            Console.WriteLine("No logs found.");
        }
    }
}