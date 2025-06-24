int x;

//initialization
Console.WriteLine("Please enter a number lower than 10: ");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//condition
while (x <= 10)
{
    //body
    Console.WriteLine("doofus");

    //incrementor
    Console.Write("If you would like this program to stop, please enter a greater than 10: ");
    x = Convert.ToInt32(Console.ReadLine());
}
