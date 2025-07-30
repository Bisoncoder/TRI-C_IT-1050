//A method's name and required parameters are equally important for a method to function correctly, and together they are called a signature.
//If we have two methods, say `Console.WriteLine("Hello, World!");` and `Console.WriteLine();` (yes, these are methods too, they're just built into the .NET framework), e can see that they have the same name but different signatures. This is called method overloading, and it allows us to define multiple methods with the same name but different parameters. (It's actually a good idea to do this if your methods are doing similiar things.)

//For example, we have the methods `rollDice()` and `rollDice(int sides)`. We specify to the computer which method we want to use by passing the correct parameters. If we pass no parameters, it will use the first method, and if we pass an integer, it will use the second method.
//THIS ONLY WORKS INSIDE OF A CLASS.

//Here's an example of method overloading in C#:

double rollDice()
{
    Random random = new Random();
    int die1, die2;
    die1 = random.Next(1, 7); // Returns a random number between 1 and 6
    die2 = random.Next(1, 7);
    return die1 + die2; // Returns the sum of the two dice
}
double rollDice(int numDice)
{
    Random random = new Random();
    int total = 0;
    for (int i = 0; i < numDice; i++)
    {
        total += random.Next(1, 7);
    }
    return total; // Returns the sum of the dice
}

Console.WriteLine(rollDice()); // Calls the first method, rolls two dice
Console.WriteLine(rollDice(3)); // Calls the second method, rolls three dice