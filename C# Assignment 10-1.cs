//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 6.1 pg 163
//Assignment Date: 02/16/2021


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the window title for the program's purpose
            Console.Title = "Employee Compensation Report";
            
            //Create a list to hold employee information
            List<Employee> allEmployees = new List<Employee>();

            //Setup working field variables to store user input data
            string userInput;
            int totalEmployees;
            string holdEMPLID;
            string holdEmpName;
            string holdEmpType = "";
            decimal holdSalary = 0;
            decimal holdHourRt = 0;
            decimal holdHourWrk = 0;

            //Input valdiation flag
            bool inputFlag = false;
            int userTest;

            //Prompt the user to enter the total employees being recorded
            Console.WriteLine("Enter the total employees to record:");
            userInput = Console.ReadLine();

            //Create another loop to validiate the number input.  This only accepts positive numbers and no letters
            while (int.TryParse(userInput, out userTest) == false || userTest < 1)
            {
               Console.WriteLine("Invalid Input!");
               Console.WriteLine("Enter 1 or higher");
               userInput = Console.ReadLine();
            }
           
            //Set the variable from the input valdiation
            totalEmployees = userTest;

            //Setup arrays to store employee entries
            FullTimeEmployee[] FTE = new FullTimeEmployee[totalEmployees];
            PartTimeEmployee[] PTE = new PartTimeEmployee[totalEmployees];

            //Create a loop to step through the user input process
            for (int iter = 0; iter < totalEmployees; iter++)
            {
                Console.WriteLine("What is the new employee's ID?");
                holdEMPLID = Console.ReadLine();
                
                Console.WriteLine("What is the new employee's name?");
                holdEmpName = Console.ReadLine();

                Console.WriteLine("What is the new employee's job type?");
                Console.WriteLine("(Enter FT for Full-time and PT for Part-Time)");
                userInput = Console.ReadLine().ToUpper();
                
                //Setup a check to call the correct fields for user input based on employee type
                if (userInput == "FT")
                {
                    holdEmpType = userInput;

                    Console.WriteLine("What is the new employee's annual salary? (x.xx)");
                    holdSalary = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                else if (userInput == "PT")
                {
                    holdEmpType = userInput;

                    Console.WriteLine("What is the new employee's hourly wage?  (x.xx)");
                    holdHourRt = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("What is the new employee's hours worked?  (x.xx)");
                    holdHourWrk = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                else
                {

                    //Create an input validation section for employee type
                    do
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine();
                        Console.WriteLine("What is the new employee's job type?");
                        Console.WriteLine("(Enter FT for Full-time and PT for Part-Time)");
                        userInput = Console.ReadLine().ToUpper();

                        if (userInput == "FT")
                        {
                            holdEmpType = userInput;

                            Console.WriteLine("What is the new employee's annual salary? (x.xx)");
                            holdSalary = decimal.Parse(Console.ReadLine());
                            Console.WriteLine();
                            inputFlag = true;
                        }
                        else if (userInput == "PT")
                        {
                            holdEmpType = userInput;

                            Console.WriteLine("What is the new employee's hourly wage? (x.xx)");
                            holdHourRt = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("What is the new employee's hours worked? (x.xx)");
                            holdHourWrk = decimal.Parse(Console.ReadLine());
                            Console.WriteLine();
                            inputFlag = true;
                        }

                    } while (inputFlag != true);
                }

                //Store the employee entry into the corresponding list based on employee type
                if (holdEmpType == "FT")
                {
                    FTE[iter] = new FullTimeEmployee(holdEMPLID, holdEmpName, holdEmpType, holdSalary);
                    allEmployees.Add(FTE[iter]);
                }
                else
                { 
                    PTE[iter] = new PartTimeEmployee(holdEMPLID, holdEmpName, holdEmpType, holdHourRt, holdHourWrk);
                    allEmployees.Add(PTE[iter]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is the current earnings report for these employees:");

            //Create a loop that steps through each list object and displays a report of each Employee and FT / PT class ToString methods
            foreach(Employee emp in allEmployees)
            {
                Console.WriteLine(emp);
            }
            
            //End of the Program.  Prompt the user that the program has ended and to exit the window.
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The report has finished.  Press any key to close the window...");
            Console.ReadKey();
        }
    }
}
