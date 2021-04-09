//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 5.3 pg 128-137
//Assignment Date: 02/11/2021



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the program window title
            Console.Title = "The TicTacToe Game";

            //Create a new object from the board class and display the empty board to the user
            Board board = new Board();
            Console.WriteLine(board);

            //Setup the fields to store column/row data, special value of the player's name, and the win/lose flags that control the loop
            CellValue playerName = CellValue.X;
            int row = 0;
            int column = 0;
            bool playerWins = false;
            bool stalemate = false;
            
            //Setup the input validation loop variable
            bool validChoice = false;
            
            //Start the main game loop with two conditions to end the loop
            while (!(playerWins || stalemate))
            {


                /*Start the input validation loop to determine the game board move.  It will run initially and then switch the loop off
                 when a correct input is made by the user */
                do
                {
                    //Notify the player of who should play this round
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Player " + playerName + "'s");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(" turn to move");


                    //Show the input choices to the player for their move.  Choices line up with the keyboard number pad and game board grid.
                    Console.WriteLine("Enter your move choice:");
                    Console.WriteLine("Top (7-9), Mid (4-6), Low (1-3)");
                    
                    
                    //Collect the player's input choice for game move.
                    string areaChoice = Console.ReadLine().ToUpper();
                    
                    //Setup a check to determine if the correct input has been added, if so set the flag to turn off the loop
                        if (areaChoice == "1" || areaChoice == "2" || areaChoice == "3" || areaChoice == "4" || areaChoice == "5"
                             || areaChoice == "6" || areaChoice == "7" || areaChoice == "8" || areaChoice == "9")
                        {

                            //Switch the flag to exit the input validation loop
                            validChoice = true;

                            //Setup a switch statement to place the user's number choice into the corresponding row/column gride selection
                            switch (areaChoice)
                            {
                                case "7":
                                    row = 0;
                                    column = 0;
                                    break;

                                case "8":
                                    row = 0;
                                    column = 1;
                                    break;

                                case "9":
                                    row = 0;
                                    column = 2;
                                    break;

                                case "4":
                                    row = 1;
                                    column = 0;
                                    break;

                                case "5":
                                    row = 1;
                                    column = 1;
                                    break;

                                case "6":
                                    row = 1;
                                    column = 2;
                                    break;

                                case "1":
                                    row = 2;
                                    column = 0;
                                    break;

                                case "2":
                                    row = 2;
                                    column = 1;
                                    break;

                                case "3":
                                    row = 2;
                                    column = 2;
                                    break;
                            }

                        }
                        //This condition lets the user know the entry was invalid, shows the board again and asks for another input
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid Entry, please enter 1-9!");
                            Console.WriteLine(" ");
                            Console.WriteLine(board);
                            Console.WriteLine("Enter your move choice:");
                            Console.WriteLine("Top (7-9), Mid (4-6), Low (1-3)");

                            //Ask the player to input the choice again
                            areaChoice = Console.ReadLine().ToUpper();
                        }

                    //Once the input is validated, check to see if the move square is valid, if not switch the validChoice flag off to input again
                    if (board.AllCells[row, column] != CellValue.E)
                    {
                        Console.WriteLine("Invalid move choice!");
                        Console.WriteLine(" ");
                        Console.WriteLine(board);
                        validChoice = false;
                    }
                
                } while (!validChoice);

                //Create a new instance for the player class, and input the current variables to the constructor
                Player player = new Player(row, column, playerName);
                
                //Call the method to update the player's choices
                player.PlayerMove(board);
                
                //Display the updated board with the player's move
                Console.WriteLine(board);

                //Check the board to see if the win conditions are met
                playerWins = player.IsPlayerWin(board);
                stalemate = board.HasNoMoreE();
                
                //Setup a check to display which player met the win condition
                if (playerWins)
                { 
                    Console.WriteLine(" ");
                    Console.WriteLine("Player " + playerName + " wins!");
                }
                else if (stalemate)
                { 
                    Console.WriteLine(" ");
                    Console.WriteLine("Stalemate :(");
                }

                //At the end of the turn, check the player's name and return the opposite for the next player's turn.
                playerName = (playerName == CellValue.X) ? CellValue.O : CellValue.X;
                
                //Setup a check conditon to see if the players would like to play again.
                if (playerWins == true || stalemate == true)
                {
                    //Once a winner is found, display a prompt and input asking to play again
                    Console.WriteLine("Would you like to play again? (Enter y or yes)");
                    string choice = Console.ReadLine().ToUpper();

                    //Setup the conditions to reset the game if playing again.
                    if (choice == "Y" || choice == "YES")
                    {
                        //Set the playername field to empty
                        playerName = CellValue.E;
                        
                        //Reset the board values to empty (E)
                        board.AllCells[0, 0] = playerName;
                        board.AllCells[0, 1] = playerName;
                        board.AllCells[0, 2] = playerName;
                        board.AllCells[1, 0] = playerName;
                        board.AllCells[1, 1] = playerName;
                        board.AllCells[1, 2] = playerName;
                        board.AllCells[2, 0] = playerName;
                        board.AllCells[2, 1] = playerName;
                        board.AllCells[2, 2] = playerName;

                        //Print out the board again
                        Console.WriteLine(board);

                        //Reset the playername field
                        playerName = CellValue.X;

                        //Activate the game loop states
                        playerWins = false;
                        stalemate = false;
                    }
                    else
                    {
                        //Display a message confirming the choice not to play again
                        Console.WriteLine("");
                        Console.WriteLine("Maybe another time.  Thanks for playing!");
                    }


                }
            }
            
            //End of the Program.  Prompt the user that the program has ended and to exit the window.
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The game has ended.  Press any key to close the window...");
            Console.ReadKey();
        }
    }
}
