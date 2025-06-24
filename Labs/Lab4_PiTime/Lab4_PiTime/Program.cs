double x;
double y;

x = Math.PI;

Console.WriteLine("Please type in the radius of your circle: ");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

Console.Write("The area of your circle is "); Console.Write(x * Math.Pow(y,2)); Console.Write(". ");
Console.Write("The circumference is "); Console.Write(2 * x * y); Console.Write(". ");
Console.WriteLine(" ");