//OOP (Object Oriented Programming) is a programming style that uses objects and classes to structure software programs.
//A class is a blueprint for creating objects, which are instances of classes. Classes are defined with properties (attributes) and methods (functions), which dictate what an ojbect is an can do.
//OOP also works as a subprogram, where it can be called from the main program, even if it's in a different file.
//This can be done by opening the Solution Explorer, right-clicking on the project, and selecting "Add" -> "Class". This new window will allow you to name the class and add it to the project, without the clutter of the main program file.

//Now for an object of the class Animal, we can create an instance of it in the main program (this one).
using Practice_OOP;

//New object of the class `Animal`.
Animal a1 = new Animal();
Animal a2 = new Animal();
//Assigns the value given to `nameAnimal` to the `name` property of the object.
a1.nameAnimal("Dog");
a2.nameAnimal("Cat");
//Prints the name of the animal using the `getName` method.
Console.WriteLine($"Animal Name: {a1.getName()}.");
Console.WriteLine($"Animal Name: {a2.getName()}.");