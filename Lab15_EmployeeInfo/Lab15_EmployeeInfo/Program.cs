//Start with this code for Lab 15. Build out the Employee class first, then complete the Main method.
using Lab15_EmployeeInfo;
using System;

public class Program
{
    public static void Main()
    {
        //Create three employee objects
        //You can completely make up the names, departments, and salaries of each employee
        Employee emp1 = new Employee("Johnny Boy", "Marketing", 60000);
        Employee emp2 = new Employee("Sally 'Rivet' Saul", "Engineering", 75000);
        Employee emp3 = new Employee("Bob", "Construction", 50000); Console.WriteLine();

        //Display the 'info' for each employee
        Console.WriteLine(emp1.GetInfo());
        Console.WriteLine(emp2.GetInfo());
        Console.Write(emp3.GetInfo());

        //Give the first employee a generic raise
        emp1.GiveRaise();

        //Give change the second employee's department to... something different
        emp2.ChangeDepartment("Research and Development"); Console.WriteLine();

        //Give the third employee a raise of 5000
        emp3.GiveRaise(5000); Console.WriteLine();

        //Display the 'info' for each employee again
        Console.WriteLine(emp1.GetInfo());
        Console.WriteLine(emp2.GetInfo());
        Console.WriteLine(emp3.GetInfo());
    }
}