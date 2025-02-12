using System;

class Word
{
    private string text;

    public Word(string text)
    {
        this.text = text;
    }

    public void Hide()
    {
        text = "____";
    }

    public override string ToString()
    {
        return text;
    }
}