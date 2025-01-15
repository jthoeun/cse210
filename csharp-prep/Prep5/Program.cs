using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int squarenumber = squareNumber(usernumber);
        DisplayResult(username, squarenumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");

    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}