using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int year;
        PromptUserBirthYear(out year);

        int sqre = SquareNumber(number);
        DisplayResult(name, sqre, year);


    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        string strnum = Console.ReadLine();
        int num = int.Parse(strnum);
        return num;

    }
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        string yearstr = Console.ReadLine();
        year = int.Parse(yearstr);

    }
    static int SquareNumber(int num)
    {
        int sqre = num * num;
        return sqre;
    }
    static void DisplayResult(string name, int sqre, int year)
    {
        int age = 2025 - year;
        Console.WriteLine($"{name}, the square of your number is {sqre}.");
        Console.WriteLine($"{name}, you will turn {age} years old this year.");
    }
}