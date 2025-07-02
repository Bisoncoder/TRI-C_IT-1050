//Create a method that rolls dice and returns the sum of the rolls, however, this time the user will be able to set the number of rolls.

int userRolls;

Console.Write("How many times would you like to roll the dice? "); userRolls = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"The sum of your rolls is: {rollDice(userRolls)}");

// The method that rolls the dice and returns the sum of the rolls
static int rollDice(int rolls)
{
    Random random = new Random();
    //Total variable to hold the sum of the rolls
    int total = 0;
    //Loop through the number of rolls specified by the user
    for (int i = 0; i < rolls; i++)
    {
        //The die roll
        int die = random.Next(1, 7);
        total += die;
    }
    return total;
}