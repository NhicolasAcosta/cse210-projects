using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        float square = SquareNumber(number);
        DisplayResult(name, square);
    }
    static void DisplayMessage()
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
        string sNumber = Console.ReadLine();
        int number = int.Parse(sNumber);
        return number;
    }
    static float SquareNumber(int number)
    {
        float square = number * number;
        return square;
    }
    static void DisplayResult(string name, float square)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {square}");
    }
}