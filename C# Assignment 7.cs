//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 4.6 pg 95-101
//Assignment Date: 02/05/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the program window title and font color to white
            Console.Title = "The Rock, Paper, Sissors Game";

            //Setup the variables to hold the score totals for the computer and player
            int computerScore = 0;
            int playerScore = 0;
            
            //Setup the variable to run the main game loop
            bool playAgain = true;

            //Setup the variable to hold the player's input on game choice
            string gameChoice;

            //Setup the variable used to validate the game choice input from the player
            bool validChoice = false;
            
            //Display the initial game prompt to the player to pick a game mode
            Console.WriteLine("Which game type would you like to play?");
            Console.WriteLine("1. Best two out of three games or 2. Best three out of five games?");
            Console.WriteLine("Enter 1 or 2");
            
            //Store the player's input choice in upper case to make it easier to enter choices
            gameChoice = Console.ReadLine().ToUpper();

            /*Start the input validation loop to determine which method (Mult or Div) to branch to.  Sets the boolean
            value to true so the loop will run initially and will switch the loop off when a correct
            entry is made by the user */
            while (!validChoice)
            {
                //Setup the check to determine if the correct input has been added to turn off the loop
                if (gameChoice == "1" || gameChoice == "2")
                {
                    validChoice = true;
                }
                //This condition of the check prompts the user for the invalid entry and asks for another input
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Entry!");
                    Console.WriteLine("1. Best two out of three games or 2. Best three out of five games?");
                    Console.WriteLine("(Enter 1 or 2)");
                    gameChoice = Console.ReadLine().ToUpper();
                }

            }


            //This is the loop for game mode #1, best 2 out of 3 games (first to win 2 games).
            if (gameChoice == "1")
            {
                //Display a message to the player confirming game mode choice
                Console.WriteLine("Alright, lets play a game of best two out of three");
                Console.WriteLine(" ");

                //Start the game loop
                while (playAgain)
                {
                    //Call the methods to get shape choice and determine the winner
                    string playerShape = PlayerShape();
                    string computerShape = ComputerShape();
                    string winner = Winner(playerShape, computerShape);

                    //Display the game results to the player
                    Console.WriteLine("User shape: {0}", playerShape);
                    Console.WriteLine("Computer shape: {0}", computerShape);
                    Console.WriteLine("");
                    Console.WriteLine("{0} won and got the point this round!", winner);

                    //Setup a check for increasing score based on the winner results
                    if (winner == "Computer")
                    {
                        computerScore++;
                    }
                    else if (winner == "Player")
                    {
                        playerScore++;
                    }

                    //Display the score results to the player
                    Console.WriteLine("");
                    Console.WriteLine("The current score is: ");
                    Console.WriteLine("Computer: {0}", computerScore);
                    Console.WriteLine("Player: {0}", playerScore);
                    Console.WriteLine("");

                    //Setup a check to determine the game winner based on mode
                    if (computerScore == 2 || playerScore == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("{0} is the WINNER!", winner);
                    }
                    else
                    {
                        //If the score is not enough to win, move back to the top of the loop
                        continue;
                    }

                    //Once a winner is found, display a prompt to the player asking to play again
                    Console.WriteLine("Would you like to play again? y/n");
                    string choice = Console.ReadLine().ToUpper();
                    
                    //Setup a check to determine continued play.  If playing again, reset the score to 0
                    if (choice == "Y" || choice == "YES")
                    {
                        computerScore = 0;
                        playerScore = 0;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for playing.");
                        
                        //Deactivate the game loop
                        playAgain = false;
                    }
                }
            }
            else if (gameChoice == "2")
            //This is the loop for game mode #2, best 3 out of 5 games (first to win 3 games).

            {
                //Display a message to the player confirming game mode choice    
                Console.WriteLine("Alright, lets play a game of best three out of five");
                Console.WriteLine(" ");

                //Start the game loop
                while (playAgain)
                {
                    //Call the methods to get shape choice and determine the winner
                    string playerShape = PlayerShape();
                    string computerShape = ComputerShape();
                    string winner = Winner(playerShape, computerShape);

                    //Display the game results to the player
                    Console.WriteLine("User shape: {0}", playerShape);
                    Console.WriteLine("Computer shape: {0}", computerShape);
                    Console.WriteLine("");
                    Console.WriteLine("{0} won and got the point this round!", winner);

                    //Setup a check for increasing score based on the winner results
                    if (winner == "Computer")
                    {
                       computerScore++;
                    }
                    else if (winner == "Player")
                    {
                       playerScore++;
                    }

                    //Display the score results to the player
                    Console.WriteLine("");
                    Console.WriteLine("The current score is: ");
                    Console.WriteLine("Computer: {0}", computerScore);
                    Console.WriteLine("Player: {0}", playerScore);
                    Console.WriteLine("");

                    //Setup a check to determine the game winner based on mode
                    if (computerScore == 3 || playerScore == 3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("{0} is the WINNER!", winner);
                    }
                    else
                    {
                        //If the score is not enough to win, move back to the top of the loop
                        continue;
                    }

                    //Once a winner is found, display a prompt to the player asking to play again
                    Console.WriteLine("Would you like to play again? y/n");
                    string choice = Console.ReadLine().ToUpper();

                    //Setup a check to determine continued play.  If playing again, reset the score to 0    
                    if (choice == "Y" || choice == "YES")
                    {
                        computerScore = 0;
                        playerScore = 0;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for playing.");

                        //Deactivate the game loop
                        playAgain = false;
                    }
                }
            }


            //The player has chosen to stop playing
            //Change the font color to highlight the prompt to close the window and end the program
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }

        //Create the method that compares shapes, determines the winner, and returns the result to the program
        private static string Winner(string playerShape, string computerShape)
        {
            //Setup the default value for a tie
            string winner = "Nobody";
            
            //Setup a check to compare player and computer shape choices to determine the winner
            if (playerShape == "ROCK" && computerShape == "PAPER"
                || playerShape == "PAPER" && computerShape == "SCISSORS"
                || playerShape == "SCISSORS" && computerShape == "ROCK")
            {
                winner = "Computer";
            }
            else if (playerShape == "ROCK" && computerShape == "SCISSORS"
                || playerShape == "PAPER" && computerShape == "ROCK"
                || playerShape == "SCISSORS" && computerShape == "PAPER")

            {
                winner = "Player";
            }
            return winner;
        }

        //Create the method that gets the computer's input, validates it, and returns the result to the program
        private static string ComputerShape()
        {
            //Set the default shape choice
            string cShape = "PAPER";

            //Call a random number to generate the computer's choice
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            //Setup a switch check to format the random number into a valid result
            switch (randomNumber)
            {
                case 1:
                    cShape = "ROCK";
                    break;
                case 2:
                    cShape = "PAPER";
                    break;
                case 3:
                    cShape = "SCISSORS";
                    break;
            }
            return cShape;
        }

        //Create the method that gets the player's input, validates it, and returns the result to the program
        private static string PlayerShape()
        {
            //Set the default shape for the player
            string shape = "ROCK";

            //Setup the validation value and start the loop to collect the player's choice
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.WriteLine("Enter Rock, Paper, or Scissors:");
                shape = Console.ReadLine().ToUpper();
                if (shape == "ROCK" || shape == "PAPER" || shape == "SCISSORS")
                {
                    isValidInput = true;
                }
            }
            return shape;
        }
    }
}
