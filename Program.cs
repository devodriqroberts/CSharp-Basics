// Using directive
using System;

namespace Basics.FitnessFrog {

    
    class Program 
    {

        static void Main() 
        {
                var runningTotal = 0.0;

            while (true) 
            {
                //Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

                //returns what the user typed
                var entry = Console.ReadLine();
                

                //Repeat until user quits
                if (entry.ToLower() == "quit") 
                {
                    Console.WriteLine("Goodbye");
                    break;
                } 
               
                var minutes = 0.0;

                try 
                {
                    minutes = double.Parse(entry);

                    if (minutes <= 0) 
                    {
                    Console.WriteLine($"{minutes} is not an exceptable number.");
                    continue;
                    }
                    else if (minutes <= 10) 
                    {
                    Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                    Console.WriteLine("Way to go!");
                    } 
                    else 
                    {
                    Console.WriteLine("Ok, now you're just showing off.");
                    }
                } 
                catch (FormatException)
                {
                    Console.WriteLine("Sorry, that was not a valid input");
                    continue;
                }

                //Add minute exercised to total
                runningTotal += double.Parse(entry);

                //Display total minutes exercised to the scren
                Console.WriteLine($"You've exercised {runningTotal} minutes");

                }

            
        }
    }
}
