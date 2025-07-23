//C# is bitchy for some reason and doesn't like classes and objects in the same file, so we have to make a new file for the class.
using System.Globalization;

namespace Practice_OOP_Constructors
{
    public class Employee
    {
        public string fname;
        public string lname;
        public int id;
        public double salary;
        //Constructor
        //2 very important things to note about constructors: 1) The name of the constructor must match the name of the class, and 2) constructors do not have a return type, not even void.
        //Constructors can also take parameters, just like regular methods. Just like when making a method, when making a constructor, you should ask yourself "What additional information is needed to create this object?"
        public Employee(string f, string l)
        {
            fname = f;
            lname = l;
            salary = 30_000; //default salary
        }
    }
}
