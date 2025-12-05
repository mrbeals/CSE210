using System;

// Added a counter for each activity, to track how many times they were completed in a session.
class Program
{
    static void Main(string[] args)
    {
        int choice = -1;
        int breatheCounter = 0;
        int reflectCounter = 0;
        int listCounter = 0;
        BreathingActivity breathe = new BreathingActivity();
        ReflectingActivity reflect = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start reflecting activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string strchoice = Console.ReadLine();
            choice = int.Parse(strchoice);

            if (choice == 1)
            {
                breathe.BreathingExercise();
                breatheCounter += 1;
            }
            else if (choice == 2)
            {
                reflect.ReflectionExercise();
                reflectCounter += 1;
            }
            else if (choice == 3)
            {
                listing.ListingExercise();
                listCounter += 1;
            }
            else if (choice >= 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Not a valid Selection, Try again");
                breathe.CountdownTimer(3);
            }
            

        }
        Console.Clear();
        Console.WriteLine($"You completed the {breathe.GetActivityName()} {breatheCounter} times!");
        Console.WriteLine("");
        Console.WriteLine($"You completed the {reflect.GetActivityName()} {reflectCounter} times!");
        Console.WriteLine("");
        Console.WriteLine($"You completed the {listing.GetActivityName()} {listCounter} times!");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Thank you! Have a Great Day!");
    }
}