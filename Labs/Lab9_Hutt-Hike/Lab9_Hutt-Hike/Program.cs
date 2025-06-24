int x;

for (x = 0; x < 101; x++)
{
    //divisible by both 3 and 7
    if (((x % 3 == 0) && (x % 7 == 0)) && x != 0)
    {
        Console.WriteLine("Hutt-Hike");
    }
    //divisible by 3 only
    else if ((x % 3 == 0) && x != 0)
    {
        Console.WriteLine("Hutt");
    }
    //divisble by 7 only
    else if ((x % 7 == 0) && x != 0)
    {
        Console.WriteLine("Hike");
    }
    //neither
    else
    {
        Console.WriteLine(x);
    }
}