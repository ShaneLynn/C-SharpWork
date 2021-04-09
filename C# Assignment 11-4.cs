//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 6.3 pg 171
//Assignment Date: 02/16/2021

namespace dropbox11
{
    class PartTimeEmployee : Employee
    {
        //Setup the fields to hold the hourly salary information for part time employees
        private decimal hourlyWage;
        private decimal hoursWorked;

        ////Setup the properties needed to adjust the field variables
        public decimal HourlyWage
        {
            get { return hourlyWage; }
            set { hourlyWage = value; }
        }

        public decimal HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        //Setup the default constructor for part time employees that collects additional information on hourly salary
        public PartTimeEmployee(string employeeId, string employeeName, string employeeType, decimal hourlyWage, decimal hoursWorked) : base(employeeId, employeeName, employeeType)
        {
            this.hourlyWage = hourlyWage;
            this.hoursWorked = hoursWorked;
        }

        //Create the method that calculates the weekly pay for part time hourly employees
        public override decimal GetWeeklyPaid()
        {
            decimal payAmount;
            payAmount = HoursWorked * HourlyWage;
            return payAmount;
        }

        //Modify the default ToString method to call the Employee class TS method and add in the hourly salary calculations.
        public override string ToString()
        {
            string str;
            str = base.ToString() + string.Format(" | Pay amount: {0:C}", GetWeeklyPaid());
            return str;
        }
    }
}
