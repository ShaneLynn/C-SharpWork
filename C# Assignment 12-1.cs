//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 7.2 pg 199
//Assignment Date: 02/23/2021


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the window title for the program's purpose
            Console.Title = "Student Semester Grade Report";

            //Setup field variables to hold user values
            string studentName = "";
            double[] studentScore = new double [5];
            string[] letterGrade = new string [5];
            double overallScore;
            string overallGrade;

            //Create an object for grades use default constructor for the score
            LetterGrade grade = new LetterGrade(studentScore[0]);

            //Create a try/catch loop to handle execptions from the program.
            try
            {
            //Prompt user for the student's name and test score
            Console.WriteLine("Enter the student's name: ");
            studentName = Console.ReadLine();
            
                for(int counter = 0; counter < studentScore.Length; counter++)
                {
                    switch (counter)
                    {
                        case 0:
                            Console.WriteLine("Enter {0}'s English exam score: ", studentName);
                            break;
                        case 1:
                            Console.WriteLine("Enter {0}'s Math exam score: ", studentName);
                            break;
                        case 2:
                            Console.WriteLine("Enter {0}'s Science exam score: ", studentName);
                            break;
                        case 3:
                            Console.WriteLine("Enter {0}'s Social Science exam score: ", studentName);
                            break;
                        case 4:
                            Console.WriteLine("Enter {0}'s Programming exam score: ", studentName);
                            break;
                    }   
                
                    //Input validation loop to collect the correct input from the user and keep in the desired range of 0-100
                    while (!(double.TryParse(Console.ReadLine(), out studentScore[counter])) || (studentScore[counter] < 0) || (studentScore[counter] > 100))
                    {
                    Console.WriteLine("Exam score must be between 0 and 100.");
                    Console.WriteLine("Reenter student score: ");
                    }
                
                    //Access the letter grade class object and set the score value
                    grade.StudentScore = studentScore[counter];

                    //Call the grade calculation method to generate and store a letter grade based on the exam score
                    letterGrade[counter] = grade.FinalGrade();

                }
            
            //Beginning of catch statements for common program errors
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Calculate and store the overall score for the semester
                overallScore = ((studentScore[0] + studentScore[1] + studentScore[2] + studentScore[3] + studentScore[4]) / 5);

                //Create a new grade object and use it to store the overall semester grade
                LetterGrade ovrgrade = new LetterGrade(overallScore);
                overallGrade = ovrgrade.FinalGrade();

                //Display results to the user by looping through the array of scores and grades
                Console.WriteLine();
                Console.WriteLine("SEMESTER GRADE REPORT");
                Console.WriteLine();
                Console.WriteLine("Student Name: {0}", studentName);
                Console.WriteLine("         English Score: {0} | Grade: {1}", studentScore[0], letterGrade[0]);
                Console.WriteLine("            Math Score: {0} | Grade: {1}", studentScore[1], letterGrade[1]);
                Console.WriteLine("         Science Score: {0} | Grade: {1}", studentScore[2], letterGrade[2]);
                Console.WriteLine("  Social Science Score: {0} | Grade: {1}", studentScore[3], letterGrade[3]);
                Console.WriteLine("     Programming Score: {0} | Grade: {1}", studentScore[4], letterGrade[4]);
                Console.WriteLine();
                Console.WriteLine("Overall Semester Score: {0} | Grade: {1}", overallScore, overallGrade);

                //End of the Program.  Prompt the user that the program has ended and to exit the window.
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The report has finished.  Press any key to close the window...");
                Console.ReadKey();
            }
        }
    }
}
