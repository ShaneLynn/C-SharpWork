//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Challenge 5.1 pg 125
//Assignment Date: 02/11/2021


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the program window title
            Console.Title = "Semester Grade Entry";

            //Setup variables for the user to enter the amount of students to record scores and input validation
            int classSize = 0;
            string userInput = "";
            int userTest = -1;
            
            //Prompt the user to enter a number for the class size
            Console.WriteLine("Please enter the total students with semester scores:");
            userInput = Console.ReadLine();

            //Create a loop to validiate the number input.  This only accepts positive numbers and no letters
            while (int.TryParse(userInput, out userTest) == false || userTest < 0)
            {
                Console.WriteLine("Invalid Input!");
                Console.WriteLine("Please enter the total students with semester scores:");
                userInput = Console.ReadLine();
            }
            //Once the input is a useable number, store it to the field variable
            classSize = userTest;


            //Setup array fields to store the information on each student
            string[] studentName = new string[classSize];
            int[] homeWork = new int[classSize];
            int[] mid1 = new int[classSize];
            int[] mid2 = new int[classSize];
            int[] finalExam = new int[classSize];

            //Create a new array of the CollegeStudent's class to hold the results and create a new object array for the student data
            CollegeStudent[] students = new CollegeStudent[classSize];
            
            //Setup a loop to step through the class size entered and store data for each student
            for (int counter = 0; counter < classSize; counter++)
            {
                //Prompt the user for the student's name
                Console.WriteLine("Enter student {0}'s name:", counter+1);
                studentName[counter] = Console.ReadLine();

                //----------------------------------------------------------------------------------------------------
                //Prompt the user for the homework's score and use input validation
                Console.WriteLine("Enter {0}'s homework score (0-100):", studentName[counter]);
                
                //Prompt the user for input
                userInput = Console.ReadLine();

                //Create a loop to validiate the number input.  This only accepts positive numbers and no letters
                while (int.TryParse(userInput, out userTest) == false || userTest < 0)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("Enter {0}'s homework score (0-100):", studentName[counter]);
                    userInput = Console.ReadLine();
                }
                //Once the input is a useable number, store it to the field variable
                homeWork[counter] = userTest;

                //----------------------------------------------------------------------------------------------------
                //Prompt the user for the midterm1's score and use input validation
                Console.WriteLine("Enter {0}'s midterm one score (0-100):", studentName[counter]);
                
                //Prompt the user for input
                userInput = Console.ReadLine();

                //Create a loop to validiate the number input.  This only accepts positive numbers and no letters
                while (int.TryParse(userInput, out userTest) == false || userTest < 0)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("Enter {0}'s midterm one score (0-100):", studentName[counter]);
                    userInput = Console.ReadLine();
                }
                //Once the input is a useable number, store it to the field variable
                mid1[counter] = userTest;

                //----------------------------------------------------------------------------------------------------
                //Prompt the user for the midterm2's score and use input validation
                Console.WriteLine("Enter {0}'s midterm two score (0-100):", studentName[counter]);

                //Prompt the user for input
                userInput = Console.ReadLine();

                //Create a loop to validiate the number input.  This only accepts positive numbers and no letters
                while (int.TryParse(userInput, out userTest) == false || userTest < 0)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("Enter {0}'s midterm two score (0-100):", studentName[counter]);
                    userInput = Console.ReadLine();
                }
                //Once the input is a useable number, store it to the field variable
                mid2[counter] = userTest;

                //----------------------------------------------------------------------------------------------------
                //Prompt the user for the final exam's score and use input validation
                Console.WriteLine("Enter {0}'s final exam score (0-100):", studentName[counter]);

                //Prompt the user for input
                userInput = Console.ReadLine();

                //Create a loop to validiate the number input.  This only accepts positive numbers and no letters
                while (int.TryParse(userInput, out userTest) == false || userTest < 0)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("Enter {0}'s final exam two score (0-100):", studentName[counter]);
                    userInput = Console.ReadLine();
                }
                
                //Once the input is a useable number, store it to the field variable
                finalExam[counter] = userTest;

                //Call the CollegeStudent's class constructor to store in the array each student's data
                students[counter] = new CollegeStudent(studentName[counter], homeWork[counter], mid1[counter], mid2[counter], finalExam[counter]);

            }
            
            //Display the intial report header to the user that also shows how many students have data
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("==Here is the final semester's student report==");
            Console.WriteLine("");
            Console.WriteLine("Total students with scores this semester: {0}", classSize);
            Console.WriteLine("");

            //Create a final loop to step through the students array and display the final results for each student
            for (int counter = 0; counter < classSize; counter++)
            {
                //Call the CollegeStudent ToString method to display the data on each student
                Console.WriteLine(students[counter]);
            }

                        
            //Exit console prompt to the user indicating the program has ended.
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("End of report. Press any key to close the window...");
            Console.ReadKey();
        }
    }
}
