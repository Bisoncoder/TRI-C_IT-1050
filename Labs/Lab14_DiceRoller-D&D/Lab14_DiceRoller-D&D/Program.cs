//Create a program that asks the user to enter a number of dice to roll, then how many sides that die has, and then rolls the dice and displays the results.

//Dice rolling method
static int Roll(int numberOfDice, int sides)
{
    Random random = new Random();
    int total = 0;
    for (int i = 0; i < numberOfDice; i++)
    {
        int die = random.Next(1, sides + 1);
        //Display each die roll for clarity and debugging
        Console.WriteLine($"Die {i + 1}: {die}");
        total += die;
    }
    return total;
}

//Prompts                                           Yes, you can declare variables in the middle of the code
Console.Write("Enter the number of dice to roll: "); int userInput = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
Console.Write("Enter the number of sides on the die: "); int sides = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
//"Loading"
Console.WriteLine($"Rolling {userInput}d{sides}..."); Console.WriteLine();
//Result
Console.WriteLine($"You rolled a total of {Roll(userInput, sides)}!");
