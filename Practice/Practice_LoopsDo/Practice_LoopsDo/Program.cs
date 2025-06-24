//do loops run at least once regardless of condition true or false
//minmizes repeated code written both before and inside a loop
//"while" and its condition go at the end

string action;

do
{
    Console.WriteLine("Would you like to exit? Yes or No?");
    action = Console.ReadLine();
} while (action != "Yes");
Console.WriteLine("Have a nice day!");