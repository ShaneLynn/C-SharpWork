//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming challenge 4.2 pg 93
//Assignment Date: 02/05/2021


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the program window title
            Console.Title = "Build-a-Method Workshop - Multiply, Divide, Add, and Subtract!";

            //Setup the arrays to collect user values to pass to the methods
            int[] multInput = new int[2];
            int[] divInput = new int[2];
            int[] addsubInput = new int[2];

            //Setup an array to hold values for input validataion of the user input numbers.
            int[] userTest = new int[2] { -1, -1 };

            //Setup a boolean to control the user input validation loop for M/D choice
            bool validChoice = false;
            
            //Setup the variables to hold the user input for M/D choice and number entries
            string toolChoice;
            string userInput;
            
            //Display a greeting to the user and setup the first choice to pick the method
            Console.WriteLine("Welcome!");
            Console.WriteLine("Would you like to Multiply, Divide, or Add and Subract today?");
            Console.WriteLine("(Enter M to multiply, D to divide, or AS to add/subtract)");
           
            //Prompt the user and store the input choice.  Using upper case to make it easier on the user
            toolChoice = Console.ReadLine().ToUpper();

            /*Start the input validation loop to determine which method (Mult or Div) to branch to.  Sets the boolean
            value to true so the loop will run initially and will switch the loop off when a correct
            entry is made by the user */
            while (!validChoice) 
            {
                //Setup the check to determine if the correct input has been added to turn off the loop
                if (toolChoice == "M" || toolChoice == "D" || toolChoice == "AS" || toolChoice == "MULTIPLY" || toolChoice == "DIVIDE" || toolChoice == "ADD/SUBTRACT")
                {
                    validChoice = true;
                }
                //This condition of the check prompts the user about the invalid entry and asks for another input
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Entry!");
                    Console.WriteLine("Would you like to multiply, divide, or add/subract today?");
                    Console.WriteLine("(Enter M to multiply, D to divide, or AS to add/subtract)");
                    toolChoice = Console.ReadLine().ToUpper();
                }

            }

            //Once the intial input validation loop is passsed, put each mode into an if check which determines if 
            //the Multiplication, Division, Addition/Subtraction selector is activated.
            if (toolChoice == "M" || toolChoice == "MULTIPLY") //This is the branch for multiplication
            {
                //Confirm to the user their choice of branch
                Console.WriteLine("");
                Console.WriteLine("Awesome!");
                Console.WriteLine("Let's Multiply two numbers!");

                //Setup a loop to collect and store user input for each number
                for (int counter = 0; counter < 2; counter++)
                {
                    //Prompt the user for a number based on array position and store it into the validation variable
                    Console.WriteLine("Please enter a positive whole number for number {0}:", counter + 1);
                    userInput = Console.ReadLine();

                    //Create another loop to validiate the number input.  This only accepts positive numbers and no letters
                    while (int.TryParse(userInput, out userTest[counter]) == false || userTest[counter] < 0)
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine("Please enter a positive whole number for number {0}:", counter + 1);
                        userInput = Console.ReadLine();
                    }
                    //Once the input is a useable number, store it into the array to pass to the calculation method
                    multInput[counter] = userTest[counter];
                }
                //Call the multiplication method using the provided inputs
                int multResult = Multiply(multInput[0], multInput[1]);
                
                //Display the final multiplication result to the user
                Console.WriteLine("And the result of {0} * {1} is {2}", multInput[0], multInput[1], multResult);
            }
            else if (toolChoice == "D" || toolChoice == "DIVIDE") //This is the branch for division
            {
                //Confirm to the user their choice of branch
                Console.WriteLine("");
                Console.WriteLine("Fantastic!");
                Console.WriteLine("Let's Divide two numbers!");

                //Setup a loop to collect and store user input for each number
                for (int counter = 0; counter < 2; counter++)
                {
                    //Prompt the user for a number based on array position and store it into the validation variable
                    Console.WriteLine("Please enter a positive whole number for number {0}:", counter + 1);
                    userInput = Console.ReadLine();

                    //Create another loop to validiate the number input.  This only accepts positive numbers and no letters
                    while (int.TryParse(userInput, out userTest[counter]) == false || userTest[counter] < 0)
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine("Please enter a positive whole number for number {0}:", counter + 1);
                        userInput = Console.ReadLine();
                    }
                    //Once the input is a useable number, store it into the array to pass to the calculation method
                    divInput[counter] = userTest[counter];
                }

                //Call the division method using the provided inputs. Setup a variable to store the extra method output
                int divRemainder = 0;
                int divResult = Divide(divInput[0], divInput[1], out divRemainder);

                //Display the final division result to the user
                Console.WriteLine("And the result of {0} / {1} is {2} with {3} remaining", divInput[0], divInput[1], divResult, divRemainder);


            }
            else if (toolChoice == "AS" || toolChoice == "ADD/SUBTRACT") //This is the branch for adding and subtracting
            {
                //Confirm to the user their choice of branch
                Console.WriteLine("");
                Console.WriteLine("This will be fun!");
                Console.WriteLine("Let's Add and Subtract two numbers!");

                //Setup a loop to collect and store user input for each number
                for (int counter = 0; counter < 2; counter++)
                {
                    //Prompt the user for a number based on array position and store it into the validation variable
                    Console.WriteLine("Please enter a positive whole number for number {0}:", counter + 1);
                    userInput = Console.ReadLine();

                    //Create another loop to validiate the number input.  This only accepts positive numbers and no letters
                    while (int.TryParse(userInput, out userTest[counter]) == false || userTest[counter] < 0)
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine("Please enter a positive whole number for number {0}:", counter + 1);
                        userInput = Console.ReadLine();
                    }
                    //Once the input is a useable number, store it into the array to pass to the calculation method
                    addsubInput[counter] = userTest[counter];
                }

                //Call the addition/subtraction method using the provided inputs. Setup a variable to store the extra method output
                int subResult = 0;
                int addResult = SumAndDifference(addsubInput[0], addsubInput[1], out subResult);

                //Display the final addition/subtraction result to the user
                Console.WriteLine("And the result of {0} + {1} is {2}", addsubInput[0], addsubInput[1], addResult);
                Console.WriteLine("While the result of {0} - {1} is {2}", addsubInput[0], addsubInput[1], subResult);


            }
            //Change the font color to highlight the prompt to close the window and end the program
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
        
        //Setup a method that accepts 2 integer numbers, multiplies them together, and passes the product back to the program.
        static int Multiply(int x, int y)
        {
            int multTotal = (x * y);
            return multTotal;
        }
        //Setup a method that accepts 2 integer numbers, divides them together, and then passes the result and remainder back to the program.
        static int Divide(int x, int y, out int divRemTotal)
        {
            int divTotal = (x / y);
            divRemTotal = (x % y);
            return divTotal;
        }
        //Setup a method that accepts 2 integer numbers, adds them together, and then passes the result and the subtraction back to the program.
        static int SumAndDifference(int x, int y, out int diffTotal)
        {
            int sumTotal = (x + y);
            diffTotal = (x - y);
            return sumTotal;
        }
    }
}
