using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("D&C", 4, 5);
        Scripture scripture = new Scripture(reference, "And faith, hope, charity and love, with an eye single to the glory of God, qualify him for the work.");

        Console.Clear();
        Console.WriteLine(scripture.GetMaskedText());

        while (true)
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideWords();
            Console.Clear();
            Console.WriteLine(scripture.GetMaskedText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }
    }
}
