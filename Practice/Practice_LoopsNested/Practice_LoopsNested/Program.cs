//program has both loops running parallel, but external is predicated on internal condition returing false to "activate", then internal resets
//since internal resets, external stops and waits for internal to kick up again
//cycle repeats

//a starts at 0 and only increments when b kicks up
for (int a = 0; a < 3; a++)
{
    //b starts at 0, counts up to 3 before kicking up and resetting
    for (int b = 0; b < 3; b++)
    {
        Console.WriteLine("a is " + a + ", b is " + b);
    }
}
