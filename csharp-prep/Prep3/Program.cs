using System;

class Program
{
    static void Main(string[] args)
    //Console.Write("What is the magic number?");
    //int magicNumber = int.Parse(Console.ReadLine());
    {
        Random randomnumberGenereator = new Random();
        int magicNumber = randomnumberGenereator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher!");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}