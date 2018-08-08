// Using directive
using System;

namespace Basics.FitnessFrog {

    
    class Program {

        static void Main() {
            //Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");
                //returns what the user typed
            string entry = Console.ReadLine();
            //Add minute exercised to total

            //Display total minutes exercised to the scren
            Console.WriteLine($"You've exercised {entry} minutes");
            //Repeat until user quits
        }
    }
}
