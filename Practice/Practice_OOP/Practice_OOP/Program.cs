//OOP (Object Oriented Programming) is a programming style that uses objects and classes to structure software programs.
//A class is a blueprint for creating objects, which are instances of classes. Classes are defined with properties (attributes) and methods (functions), which dictate what an ojbect is an can do.

class Animal
{
    //Public indicates that these properties can be accessed from outside the class, say by a different class or method. Private would restrict access to within the class itself.
    //Properties
    public string name;
    public int age, weight;

    //Methods
    public void Eat()
    {
        Console.WriteLine($"{name} is eating");
    }
}

//OOP also works as a subprogram, where itcan be called from the main program, even if it's in a different file.
//This can be done by opening the Solution Explorer, right-clicking on the project, and selecting "Add" -> "Class". This new window will allow you to name the class and add it to the project, without the clutter of the main program file.
