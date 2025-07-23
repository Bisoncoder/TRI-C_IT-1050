//Create a method that rolls two dice and returns the sum of the two rolls.
//The method only needs to be called five (5) times.

//Roll counter and output
for (int r = 0; r < 5; r++)
{
    Console.WriteLine("Rolling the dice..."); Console.WriteLine("The results of roll " + (r + 1) + " are: " + DiceTotal());
    Console.WriteLine();
}

//Roller
static int DiceTotal()
{
    //Roll two dice and return the sum
    Random random = new Random();
    int Dice = random.Next(1, 7) + random.Next(1, 7);
    return Dice;
}