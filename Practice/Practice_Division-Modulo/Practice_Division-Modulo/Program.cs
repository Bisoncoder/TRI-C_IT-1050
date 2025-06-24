int x;
int y;
int Quotient;
int Remainder;

x = 5;
y = 3;
//int division lops off decimal, no rounding
Quotient = x / y;
//modulo only writes remainder
Remainder = x % y;

Console.Write(x); Console.Write(" / "); Console.Write(y); Console.WriteLine(" = "); 
Console.Write(Quotient); Console.Write("R"); Console.WriteLine(Remainder);