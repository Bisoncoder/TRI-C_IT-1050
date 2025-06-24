Random RNG = new Random();

int Num1;
int Num2;
int Num3;
double Num0;

//ctrl+k+c to commentize selected code, ctrl+k+u to uncommentize

//methods for rng int
{
    //o to ~2bil
    Num1 = RNG.Next();
    //0 to written, written not included
    Num2 = RNG.Next(10);
    //between first and last numbers, last not included
    Num3 = RNG.Next(1, 8);
    Console.WriteLine(Num1);
    Console.WriteLine(Num2);
    Console.WriteLine(Num3);
}

//only method for rng double
{
    //NumO is rolled by NextDouble, which generates 0 to 1, but is mult by 100 before display
    Num0 = RNG.NextDouble() * 100;
    Console.WriteLine(Num0);
}

Console.Write("");