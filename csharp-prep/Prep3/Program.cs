using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string continuue = "yes";
        do
        {
        Console.WriteLine("What is the Magic Number? ");
        string magic_number = Console.ReadLine();
        int magic = int.Parse(magic_number);
        bool guessed = false;
        int counter = 0;

        

        Random randomgenerator = new Random();
        int target = randomgenerator.Next(1, magic);

            while (guessed == false)
            {
                Console.WriteLine("What is your Guess? ");
                string guess_string = Console.ReadLine();
                int guess = int.Parse(guess_string);
                counter += 1;

                if (guess == target)
                {

                    Console.WriteLine($"You guessed it in {counter} tries!");
                    Console.WriteLine("Continue? ");
                    continuue = Console.ReadLine();
                    guessed = true;
                }
                else if (guess < target)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Lower");
                }
            }
        } while (continuue == "yes");




    }
}