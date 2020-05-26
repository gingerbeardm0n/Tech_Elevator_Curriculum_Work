namespace Individual.Exercises.Classes
{
    public class Employee
    {
        //-----VARIABLES------------------------------------------------------------------------------------------------

        //-----PROPERTIES-----------------------------------------------------------------------------------------------

        public int EmployeeId { get; }
        public string FirstName { get; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public string Department { get; set; }
        public double AnnualSalary { get; private set; }

        //-----CONSTRUCTORS---------------------------------------------------------------------------------------------

        public Employee (int employeeId, string firstName, string lastName, double salary)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
        }

        //-----METHODS--------------------------------------------------------------------------------------------------

        public void RaiseSalary( double percent)
        {
            AnnualSalary = AnnualSalary * (1 + (percent / 100));
        }


    }

}
