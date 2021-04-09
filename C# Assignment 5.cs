//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming challenge 3.6 pg 73
//Assignment Date: 01/27/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the program window title and font color to white
            Console.Title = "Columbia College - Asterisk Challenge";
            Console.ForegroundColor = ConsoleColor.White;

            //Setup the variable for the user to enter a number and a loop cycle counter
            int userNumber = 0;
            int totalCycles = 0;

            //Display the main prompt to the user to start the loop and the exit conditions
            Console.WriteLine("Enter a number from 1 to 50:");
            Console.WriteLine("(If you would like to quit, enter a 0, negative, or number greater than 50)");
            
            //Collect and store the user's entry
            userNumber = int.Parse(Console.ReadLine());
            
            //Add a line spacing for display
            Console.WriteLine();

            //Setup the while loop to repeat asking for numbers until 0, negative, or greater than 50 causes an exit
            while (userNumber >= 1 && userNumber <= 50)
                {

                //Display a prompt and seperator line before the asterisks display
                Console.WriteLine();
                Console.WriteLine("And the number of asterisks are:");
                Console.WriteLine("--------------------------------------------------");

                //Setup an additional loop to write asterisks equal to the number entered
                for (int counter = 0; counter < userNumber; counter++)
                    {
                    Console.Write("*");
                    }

                //Display a closing line after the asterisks display
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                                
                //Increase the counter variable to keep track of the number of user entries.
                totalCycles++;

                //Prompt the user to enter a new number to cycle the loop again or exit.
                Console.WriteLine();
                Console.WriteLine("============================");
                Console.WriteLine("Enter a number from 1 to 50:");
                Console.WriteLine("(If you would like to quit, enter a 0, negative, or number greater than 50)");
                userNumber = int.Parse(Console.ReadLine());
                    
                }

            //Display a message to the user for using the program after exiting the loop
            Console.WriteLine(" ");
            Console.WriteLine("Thanks for using our system!");
            
            //Setup an if block that looks at user entries to provide additional encouragement to use the program
            if (totalCycles == 0)
                Console.WriteLine("A {0}? You didn't even enter a number!  At least give it a try!", totalCycles);
            else if (totalCycles ==1)
                Console.WriteLine("You entered a number {0} time...you can do more then that!", totalCycles);
            else if (totalCycles < 5)
                Console.WriteLine("You entered a number {0} times, not bad!", totalCycles);
            else if (totalCycles < 10)
                Console.WriteLine("You entered a number {0} times, great job!", totalCycles);
            else
                Console.WriteLine("You entered a number {0} times, you are a champ!", totalCycles);

            //Change the font color to highlight the message to close the window
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
