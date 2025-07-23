// This file is part of the Practice_OOP project, but it's been separated into its own file for better organization. 
namespace Practice_OOP
{
    internal class Animal
    {
        //Public indicates that these properties can be accessed from outside the class, say by a different class or method. Private would restrict access to within the class itself. A public property or method can be accessed externally by simply typing its name, without needing to delcare its availability first.
        //Properties
        public string name;
        public int age, weight;
        public string color;

        //Methods
        public void nameAnimal(string newName)
        {
            name = newName;
        }
        public string getName()
        {
            return name;
        }
    }
}
