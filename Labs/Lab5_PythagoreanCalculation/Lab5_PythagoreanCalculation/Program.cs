//variable declaration
double a;
double b;
double c;

//user assigns variable values, program squares input values
Console.WriteLine("This program calculates the hypotenuse of a right triangle.");
Console.Write("Start by entering a value for side A, then press enter: ");
a = Convert.ToDouble(Console.ReadLine()); a = Math.Pow(a, 2);
Console.WriteLine();

Console.Write("Thank you. Now, please type in a value for side B, then press enter: ");
b = Convert.ToDouble(Console.ReadLine()); b = Math.Pow(b, 2);
Console.WriteLine();

//math equation to get final result
//REMEMBER THE ADDITION, NOT MULTIPLICTAION (the problem I ran into in class)
c = (a + b); 
Console.WriteLine("Here is your result!");
Console.Write("The hypotenuse of your triangle is: "); Console.Write(Math.Sqrt(c));
Console.WriteLine();