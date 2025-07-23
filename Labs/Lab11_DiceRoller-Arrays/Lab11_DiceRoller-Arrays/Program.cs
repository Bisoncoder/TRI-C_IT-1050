//Keep it simple, stupid
//This program simulates rolling two six-sided dice a specified number of times.

//Array to hold the frequency of each possible roll (2-12), so index 0 corresponds to a roll of 2, index 1 to a roll of 3, etc.
int[] Rolls = new int[11];
//The dice
Random Die = new Random();

//Incrementors
//Number of times the dice should be thrown
int DThrows;
//Counter for the number of throws made, so the average can be calculated
int ThrowCount = 0;

//Avg calcs
//Total of current roll
int DTotal = 0;
//Total of all rolls for average calculation
double TotalKhan = 0;
//Average of all rolls
double RollAvg;

//Prompt
Console.Write("Enter how many times the dice should be thrown: "); DThrows = Convert.ToInt32(Console.ReadLine());

//Rolling mechanism
while (DThrows > 0)
{
    //Throw Mechanism
    DTotal = (Die.Next(1, 7) + Die.Next(1, 7));
    //Individual roll total and overall total tracker
    TotalKhan += DTotal;
    //Incrementor
    DThrows--; ThrowCount++;
    //Freq tracker
    //Increment the count for the rolled value, adjusting for the array index (2 corresponds to index 0).
    Rolls[DTotal - 2]++;
}

//Throw Output
Console.WriteLine(); Console.WriteLine("Amount of times each result was rolled:");
for (int x = 0; x < Rolls.Length; x++)
{
    //Output the frequency of each roll, adjusting for the array index (2 corresponds to index 0).
    Console.WriteLine((x + 2) + ": " + Rolls[x]);
}

//Avg calculation
Console.WriteLine(); Console.WriteLine("The total of your rolls is: " + TotalKhan); 
RollAvg = TotalKhan/ThrowCount;
Console.WriteLine("The average of all your rolls is: " + TotalKhan + "/" + ThrowCount + " = " + RollAvg);