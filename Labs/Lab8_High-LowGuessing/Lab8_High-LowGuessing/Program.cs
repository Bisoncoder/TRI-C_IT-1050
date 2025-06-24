Random RNG = new Random();

int CompNew;
int PlayerGuess;
int Tries; Tries = 0;

CompNew = RNG.Next(1, 11);

Console.Write("The computer has chosen a number between 1 and 10. Please enter your guess: "); 
PlayerGuess = Convert.ToInt32(Console.ReadLine());
Tries++;
Console.WriteLine();

//faliure con
while (PlayerGuess != CompNew)
{
    if (PlayerGuess < CompNew)
    {
        Tries++;
        Console.Write("Sorry, that was too low. Please try again: ");
        PlayerGuess = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
    }
    else if (PlayerGuess > CompNew)
    {
        Tries++;
        Console.Write("Sorry, that was too high. Please try again: ");
        PlayerGuess = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
    }
} 

//win con
if (PlayerGuess == CompNew)
{
    Console.WriteLine();    
    Console.Write("That's correct! That took you "); Console.Write(Tries); Console.WriteLine(" guesses.");
    Console.Write("");
}