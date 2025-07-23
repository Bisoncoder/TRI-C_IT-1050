//Methods are basically prewritten code that can be reused throughout your program. Making a method means you only have to write the code once, and you can call it whenever you need it. This is useful for reducing code duplication and improving readability.
//Also, due to the nature of methods, they do not run until they are called, and thus can be written on the fly without having to worry about the order of execution.

Console.Write("Press any key to begin. "); Console.ReadKey();
Console.WriteLine();
Welcome();

//       |       |
//Return v  Name v 
static void Welcome()
//     | Parameters^
//Body v           |
{
    Console.WriteLine();
    Console.WriteLine("Welcome! This program describes the use of methods in C#."); Console.WriteLine("Please be patient. The program will start shortly.");
}

//Methods have four main components: the return type, the method name, the parameters, and the method body. Let's use the one we just created as an example:
//1. Return Type: This is the type of value that the method will return. In our case, it is `void`, meaning it does not return any value. These can be any data type like `int`, `double`, `string`, or `bool`; or `void` if no value is returned; but can also return objects or classes.
//2. Method Name: This is the name of the method, which is `Welcome` in our case. It follows the same rules as variables.
//3. Parameters: These are the inputs that the method can take. Our `Welcome` method does not take any parameters, so it is empty. These are indicated by parentheses `()`.
//4. Method Body: This is the code that defines what the method does, enclosed in curly braces `{}`. In our case, it prints a welcome message to the console.
//These have been labeled with arrows in the code above.

//By default, variables and related info are not shared between the main block and methods. That is unless you include a `return` statement. Let's make a new method to demonstrate this:

// This piece calls the MathSimple method and prints the result.
//Do keep in mind that the parameters of the method must be included in the method call. You cannot simply write the name of the method and expect it to work.
Console.WriteLine();
Console.WriteLine(MathSimple());

// This method takes two integers and returns their sum.
static int MathSimple()
{
    int x = 15;
    int y = 22;
    int Result = x + y;

    return Result; 
}

//However, that was a very simple example that isn't very practical to separate into a method. Let's make a more practical example.
//Let's say someone wants to randomize the colors of three different pieces of clothing. Without methods, we'd have to repeat the same code three times, which is inefficient. Instead, we can do this:

Console.WriteLine();
Console.WriteLine("Today you should wear " + RandomizeClothingColor() + " pants, a " + RandomizeClothingColor() + " shirt, and a " + RandomizeClothingColor() + " hat.");

// This method randomizes the color of a piece of clothing and returns the color.
static string RandomizeClothingColor()
{
    string color;
    int choice;

    choice = new Random().Next(1, 4); // Generates a random number between 1 and 3.
    if (choice == 1)
    {
        color = "red";
    }
    else if (choice == 2)
    {
        color = "blue";
    }
    else
    {
        color = "green";
    }
    return color; // Returns the chosen color.
}

//C# does have a strange quirk where a random defined inside a method will be repeadtedly called, it may end up returning the same value multiple times. To avoid this, you can create a single instance of `Random` outside of the method and use it within the method.