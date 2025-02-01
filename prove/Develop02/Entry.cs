using System;

class Entry
{
    public string GivenJournalDate { get; }
    public string JournalPrompt { get; }
    public string DailyJournalEntry { get; }

    public Entry(string date, string prompt, string entry)
    {
        GivenJournalDate = date;
        JournalPrompt = prompt;
        DailyJournalEntry = entry;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {GivenJournalDate}\nPrompt: {JournalPrompt}\nEntry: {DailyJournalEntry}\n");
    }
}