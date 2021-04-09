//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming challenge 3.5 pg 70-71
//Assignment Date: 01/26/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the program window title and font color to white
            Console.Title = "Columbia College - Weight Tracking";
            Console.ForegroundColor = ConsoleColor.White;


            //Setup the variables to hold student BMI category totals
            int totalUnderweight = 0;
            int totalNormalweight = 0;
            int totalOverweight = 0;
            int totalObese = 0;

            //Setup the array to hold the user input weight values.  Currently set for 15 students.
            double[] BMI = new double[15];

            //Create a loop to collect each student's BMI data and store it in the array
            for (int count = 0; count < BMI.Length; count++)
            {
                Console.WriteLine("Enter a BMI for student {0}:", count + 1);
                BMI[count] = double.Parse(Console.ReadLine());

                //Setup a while loop to check and prevent negative or zero user entries
                while (BMI[count] < 1)
                {
                    Console.WriteLine("Please do not enter zero or negative numbers.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter a BMI for student {0}:", count + 1);
                    BMI[count] = double.Parse(Console.ReadLine());
                }
            }

            //Create the loop to compare the array BMI scores to the provided weight categories
            for (int count = 0; count < BMI.Length; count++)
            {
                if (BMI[count] < 18.5) totalUnderweight++;
                else if (BMI[count] < 25) totalNormalweight++;
                else if (BMI[count] < 30) totalOverweight++;
                else totalObese++;
            }

            //Display the final results to the user
            Console.WriteLine(" ");
            Console.WriteLine("Thanks!  Here are the results from the entries:");
            Console.WriteLine("Total students under optimal weight:  {0}", totalUnderweight);
            Console.WriteLine("Total students at optimal weight:     {0}", totalNormalweight);
            Console.WriteLine("Total students above optimal weight:  {0}", totalOverweight);
            Console.WriteLine("Total students obese:                 {0}", totalObese);

            //Change the font color to highlight the message to close the window
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
