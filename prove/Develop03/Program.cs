using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("D&C", 84, 85);
        Scripture scripture = new Scripture(reference, "Neither take ye thought beforehand what ye shall say; but treasure up in your minds continually the words of life, and it shall be given you in the very hour that portion that shall be meted unto every man.");

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
