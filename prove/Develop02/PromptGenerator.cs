using System;
using System.Collections.Generic;

class PromptGenerator
{
    private static Random _random = new Random();
    private List<string> _journalPrompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced today and how you handled it.",
        "Write about someone who made a positive impact on you today.",
        "What is something new you learned today?",
        "What would be something you want to improve on today?",
        "How are you mentally feeling today?",
        "How did you show Chirst-like love?",
        "What opprotunites you came across today?",
        "How many things you were able to complete today?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "Did you have a spirtual moment today? If so, what was it?"

    };

    public string GetRandomPrompt()
    {
        if (_journalPrompts.Count == 0)
        {
            return "No prompts available.";
        }

        ShuffleList(_journalPrompts);
        return _journalPrompts[_random.Next(_journalPrompts.Count)];
    }

    private void ShuffleList(List<string> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
}