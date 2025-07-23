//Parameters are variables that are used to pass information into methods from the call line. 
//Let's use a program that calculates the factorial of a number to illustrate how parameters work. 
//Normally this would be done with a separate loop for each number, but we can use a method to handle the logic for us. All we need to do is pass the number to the method, and it will return the factorial of that number.

//`Num` is the parameter in this case, and it will be replaced with the value we pass when we call the method. The parameter type does not have to match the method type, but it is a good practice to keep them consistent.
static int Factorial(int Num)
{
    int result = 1;
    for (int i = Num; i > 1; i--)
    {
        result *= i;
    }
    return result;
}

//Now, this is all well and good, but so far this would need a custom input every time we want to calculate a factorial. To make it more flexible, we can ask the user to input a valid number.
int userInput;

//Too high will cause an overflow, so let's limit it to 15.
Console.Write("Enter a number lower than 16 to calculate its factorial: "); userInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
//`Factorial(userInput)` is called an Argument, which is the counterpart to a parameter inside a calling line of code.
Console.WriteLine("The factorial of " + userInput + " is " + Factorial(userInput));

//Finally, a method can only return one value at a time, but multiple parameters can be sent at one time.