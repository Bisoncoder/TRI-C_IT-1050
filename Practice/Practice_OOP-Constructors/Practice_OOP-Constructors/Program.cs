//We already know that when an object is instantiated from a class, it recieves all the variables of the class. But what if we we haven't set the variables yet? What do they default to?
//In C#, "value type" variables (like int, float, double, etc.) default to 0, while "reference type" variables (like string, object, etc.) default to null. This is the same "null" in the `NullPointerException` error, where you try to access a variable that hasn't been set yet.
//By default, object instantiation ends with an empty pair of parentheses, like this: `new MyClass()`. This is called the "default constructor". If you don't define any constructors in your class, C# automatically provides a default constructor that initializes all value type variables to 0 and reference type variables to null.
//To put it simply, contructors set the starting values of an object.

//Now that we've made a class with a constructor, let's make a program that uses it.
using Practice_OOP_Constructors;

Employee Jones = new Employee("Tom", "Jones");
Employee Smith = new Employee("Jane", "Smith");
Console.WriteLine($"{Jones.fname} {Jones.lname} has a salary of ${Jones.salary}.");