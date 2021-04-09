//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 6.3 pg 171
//Assignment Date: 02/16/2021

namespace dropbox11
{
    class FullTimeEmployee : Employee
    {
        //Setup a field to hold the annual salary information for full time employees
        private decimal annualSalary;

        //Setup the property needed to adjust the field variable
        public decimal AnnualSalary
        {
            get { return annualSalary; }
            set { annualSalary = value; }
        }

        //Setup the default constructor for full time employees that collects additional information on annual salary
        public FullTimeEmployee(string employeeId, string employeeName, string employeeType, decimal annualSalary) : base(employeeId, employeeName, employeeType)
        {
            this.annualSalary = annualSalary;
        }

        //Create the method that calculates the weekly pay for annual salary employees
        public override decimal GetWeeklyPaid()
        {
            decimal payAmount;
            payAmount = AnnualSalary / 52;
            return payAmount;
        }

        //Modify the default ToString method to call the Employee class TS method and add in the annual salary calculations.
        public override string ToString()
        {
            string str;
            str = base.ToString() + string.Format(" | Pay amount: {0:C}", GetWeeklyPaid());
            return str;
        }
    }
}
