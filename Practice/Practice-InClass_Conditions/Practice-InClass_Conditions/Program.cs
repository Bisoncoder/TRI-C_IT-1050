string Password;

Console.Write("Hello! Please enter your password: "); Password = Console.ReadLine();
Console.WriteLine();

//dont forget the curly brackets!
if (Password == "test")
{
    Console.WriteLine("Thank you. You can now proceed to your account.");
}
else if (Password != "test")
{
    Console.WriteLine("Password is incorrect. Access denied.");
}