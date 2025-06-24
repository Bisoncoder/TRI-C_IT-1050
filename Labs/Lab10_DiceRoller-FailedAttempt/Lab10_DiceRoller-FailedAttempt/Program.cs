//KEEP IT SIMPLE, STUPID
int DThrows;
int ThrowCount;
int DTotal;
double TotalKhan = 0;
double RollAvg;
Random Die = new Random();

//Prompt
Console.Write("Enter how many times the dice should be thrown: ");
DThrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//Throw Counter
for (ThrowCount = 1; DThrows > 0; ThrowCount++)
{
    //Throw Mechanism
    DTotal = (Die.Next(1, 7) + Die.Next(1, 7));
    DThrows--;
    //Throw Output
    Console.WriteLine("Throw " + ThrowCount + ": " + DTotal);
    //Avg tracker
    TotalKhan = (TotalKhan + DTotal);
}
//Avg calculation
RollAvg = TotalKhan / (ThrowCount - 1);
Console.WriteLine("The average of all your rolls is: " + RollAvg);