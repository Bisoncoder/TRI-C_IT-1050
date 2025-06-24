//KEEP IT SIMPLE, STUPID

//Rolls
int d2 = 0;
int d3 = 0;
int d4 = 0;
int d5 = 0;
int d6 = 0;
int d7 = 0;
int d8 = 0;
int d9 = 0;
int d10 = 0;
int d11 = 0;
int d12 = 0;

//Incrementors
int DThrows;
int ThrowCount = 0;

//Avg calcs
int DTotal = 0;
double TotalKhan = 0;
double RollAvg;
Random  Die = new Random();

//Prompt
Console.Write("Enter how many times the dice should be thrown: ");
DThrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//Throw Counter
while (DThrows > 0)
{
    //Throw Mechanism
    DTotal = (Die.Next(1, 7) + Die.Next(1, 7)); 
    //Avg tracker
    TotalKhan = (TotalKhan + DTotal);
    //Incrementor
    DThrows--;
    ThrowCount++;
    //Freq tracker
    if (DTotal == 2)
    {
        d2++;
    }
    else if (DTotal == 3)
    {
        d3++;
    }
    else if (DTotal == 4)
    {
        d4++;
    }
    else if (DTotal == 5)
    {
        d5++;
    }
    else if (DTotal == 6)
    {
        d6++;
    }
    else if (DTotal == 7)
    {
        d7++;
    }
    else if (DTotal == 8)
    {
        d8++;
    }
    else if (DTotal == 9)
    {
        d9++;
    }
    else if (DTotal == 10)
    {
        d10++;
    }
    else if (DTotal == 11)
    {
        d11++;
    }
    else if (DTotal == 12)
    {
        d12++;
    }
}
//Throw Output
Console.WriteLine(); Console.WriteLine("Amount of times each result was rolled:");
Console.WriteLine("2: " + d2); Console.WriteLine("3: " + d3); Console.WriteLine("4: " + d4); Console.WriteLine("5: " + d5); 
Console.WriteLine("6: " + d6); Console.WriteLine("7: " + d7); Console.WriteLine("8: " + d8); Console.WriteLine("9: " + d9); 
Console.WriteLine("10: " + d10); Console.WriteLine("11: " + d11); Console.WriteLine("12: " + d12);

//Avg calculation
Console.WriteLine();
RollAvg = TotalKhan/ThrowCount;
Console.WriteLine("The average of all your rolls is: " + RollAvg);