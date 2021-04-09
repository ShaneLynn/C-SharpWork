//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 6.3 pg 171
//Assignment Date: 02/16/2021

namespace dropbox11
{
    abstract class Employee
    {
        //Setup fields to store incoming employee information.  Created new field to hold employee type for reporting.
        private string employeeId;
        private string employeeName;
        private string employeeType;

        //Setup the properties to act on the field variables
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }

        //Setup the default constructor for the class to input employee data
        public Employee(string employeeId, string employeeName, string employeeType)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeType = employeeType;
        }

        //Setup an abstract GetWeeklyPaid() method so that inheritors need to implement a version
        public abstract decimal GetWeeklyPaid();

        //Override the default ToString method to display the employee name and ID information
        public override string ToString()
        {
            string str;
            str = string.Format("ID: {0} | Name: {1} | FT/PT: {2}", EmployeeId, EmployeeName, EmployeeType);
            return str;
        }
    }
}