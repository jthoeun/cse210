using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetMaskedText()
    {
        return reference.ToString() + " - " + string.Join(" ", words);
    }

    public void HideWords()
    {
        Random rand = new Random();
        int wordsToHide = Math.Max(1, words.Count / 10);

        for (int i = 0; i < wordsToHide; i++)
        {
            words[rand.Next(words.Count)].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden);
    }
}
