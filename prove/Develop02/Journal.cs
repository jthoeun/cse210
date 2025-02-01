using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> JournalEntries { get; private set; } = new List<Entry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public void AddJournalEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        string date = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine($"Date: {date} ");

        Console.Write("Enter your journal entry: ");
        string entry = Console.ReadLine();

        JournalEntries.Add(new Entry(date, prompt, entry));
        Console.WriteLine("Journal entry added successfully.");
    }

    public void DisplayJournal()
    {
        if (JournalEntries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        Console.WriteLine("Your Journal Entries:");
        foreach (var entry in JournalEntries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournalEntry()
    {
        Console.Write("Enter the file name to save your journal (e.g., my_journal.txt): ");
        string filePath = Console.ReadLine();

        try
        {
            List<string> lines = new List<string>();
            foreach (var entry in JournalEntries)
            {
                lines.Add($"Date: {entry.GivenJournalDate}");
                lines.Add($"Prompt: {entry.JournalPrompt}");
                lines.Add($"{entry.DailyJournalEntry}");
                lines.Add($"{""}");
            }
            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Journal entries saved successfully to '{filePath}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
        }
    }

    public void LoadJournalEntry()
    {
        Console.Write("Enter the file name to load your journal (e.g., my_journal.txt): ");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("The specified file does not exist.");
            return;
        }

        try
        {
            JournalEntries.Clear();
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    JournalEntries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
            Console.WriteLine($"Journal entries loaded successfully from '{filePath}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
        }
    }
}