//variable declaration
double UserHeight;

//prompt
Console.Write("Hello. Please enter your height in inches, then press enter: ");
UserHeight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
//checking process
if  (UserHeight < 60 || UserHeight > 75)
{
    Console.WriteLine("Your height is not average.");
}
else
{
    Console.WriteLine("Your height is average.");
}
Console.Write("");