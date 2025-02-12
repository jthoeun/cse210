using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetMaskedText()
    {
        return Reference.ToString() + " - " + string.Join(" ", words);
    }

    public void HideWords()
    {
        Random rand = new Random();
        int wordsToHide = Math.Max(1, words.Count / 10); // Hide around 10% of words

        for (int i = 0; i < wordsToHide; i++)
        {
            words[rand.Next(words.Count)].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(w => w.ToString() == "____");
    }
}