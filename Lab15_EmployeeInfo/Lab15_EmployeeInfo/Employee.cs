namespace Lab15_EmployeeInfo
{
    internal class Employee
    {
        //These are the properties of an employee. DO NOT MAKE THESE PROPERTIES PUBLIC!
        private string name;
        private string department;
        private int salary;
        //Here, you will build out a few methods. These should be public.
        //Build a constructor here that assigns a name, department, and salary to an employee upon creation
        public Employee(string name, string department, int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        //Create a method that gives an employee a raise of 1000
        public void GiveRaise()
        {
            salary += 1000;
        }
        //Create a method with the same name (method overloading) that gives an employee a raise of a passed amount
        public void GiveRaise(int amount)
        {
            salary += amount;
        }

        //Create a method that changes an employee's department
        public void ChangeDepartment(string newDepartment)
        {
            department = newDepartment;
        }
        //Create a method that returns an employee's name, department, and salary as a nice looking string
        public string GetInfo()
        {
            return $"Name: {name}, Department: {department}, Salary: {salary:C}"; //C formats the salary as currency
        }
        //Do not 'display' the text here, just build the string and return it
    }
}
