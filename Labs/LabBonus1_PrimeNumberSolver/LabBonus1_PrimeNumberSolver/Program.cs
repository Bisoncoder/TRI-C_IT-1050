//KEEP IT SIMPLE, STUPID
int User1;
int User2;
int Prime = 1;
int x;
int y;

//Prompt
Console.Write("Please enter a whole number: ");
User1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Please enter a larger whole number: ");
User2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//Output
Console.WriteLine("The primes between your selected numbers are: ");

//John advises to assume it is prime then prove if not
//Finder
//y is USer2, as long as y is greater or equal to User1, run then decrement
for (y = User2; y >= User1; y--)
{
    //x is 1 lower than User2, as long as x is greater than 1, run then decrement
    for (x = y-1; x > 1; x--)
    {
        //checks if x isn't prime, then trips flag 
        if (y % x == 0)
        {
            Prime = 0;
        }
    }
    //if flag was not tripped, x is prime and output
    if (Prime == 1)
    {
        Console.WriteLine(y);
    }
    Prime = 1;
}

//This works and checks a single number
//for (x = User1 - 1; x > 1; x--)
//{
//    if (User1 % x == 0)
//    {
//        Prime = 0;
//    }
//}
//if (Prime == 1)
//{
//    Console.WriteLine(User1);
//}