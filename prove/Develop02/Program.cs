using System;

class Progarm
{


    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string inputChoice = "";

        while (inputChoice != "5")
        {
            Console.WriteLine("Please select the number of one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would I like to do? ");
            inputChoice = Console.ReadLine();

            if (inputChoice == "1")
            {
                Journal.AddEntry(journal.entries);
            }
            else if (inputChoice == "2")
            {
                Entry.Display(journal.entries);
            }
            else if (inputChoice == "3")
            {
                Journal.Save(journal.entries);
            }
            else if (inputChoice == "4")
            {
                journal.entries = Journal.Load();
            }
            else if (inputChoice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("That wasn't an option!");
            }
                                                                                    
        } 
        
        
        
    }

}