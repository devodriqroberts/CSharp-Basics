// Using directive
using System;

namespace Basics.FitnessFrog {

    
    class Program 
    {

        static void Main() 
        {
                int runningTotal = 0;
                bool keepGoing = true;

            while (keepGoing) 
            {
                //Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

                //returns what the user typed
                string entry = Console.ReadLine();

                //Repeat until user quits
                if (entry.ToLower() == "quit") 
                {
                    keepGoing = false;
                    
                } else 
                {
                    
                //Add minute exercised to total
                runningTotal += int.Parse(entry);

                //Display total minutes exercised to the scren
                Console.WriteLine($"You've exercised {runningTotal} minutes");

                }

                
            }
            Console.WriteLine("Goodbye");
        }
    }
}
