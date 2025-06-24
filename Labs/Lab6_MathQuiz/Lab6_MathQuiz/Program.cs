//variable declaration
int Question1;
int Question2;
int Question3;
int Question4;
int Question5;
int TotalAnswers;

//sets the start value
TotalAnswers = 0;

//introduction
Console.WriteLine("Welcome to the Bison Math Quiz. There are five (5) questions on this quiz, can you get them all correct?");
//question and prompt format
Console.WriteLine("Let's begin. First question: What is 1+1? Type your answer, then press enter: ");
Question1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
//checking process
if (Question1 == 2)
{
    TotalAnswers += 1;
    Console.WriteLine("That's correct!");
}
else if (Question1 != 2)
{
    Console.WriteLine("Sorry, that's incorrect.");
}

Console.WriteLine("Next question: What is 7-3? Type your answer, then press enter: ");
Question2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (Question2 == 4)
{
    TotalAnswers += 1;
    Console.WriteLine("That's correct!");
}
else if (Question2 != 4)
{
    Console.WriteLine("Sorry, that's incorrect.");
}

Console.WriteLine("Next question: What is 10/2? Type your answer, then press enter: ");
Question3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (Question3 == 5)
{
    TotalAnswers += 1;
    Console.WriteLine("That's correct!");
}
else if (Question3 != 5)
{
    Console.WriteLine("Sorry, that's incorrect.");
}

Console.WriteLine("Next question: What is 25+100-50? Type your answer, then press enter: ");
Question4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (Question4 == 75)
{
    TotalAnswers += 1;
    Console.WriteLine("That's correct!");
}
else if (Question4 != 75)
{
    Console.WriteLine("Sorry, that's incorrect.");
}

Console.WriteLine("Final question: What is 111/17? Type your answer, then press enter: ");
Question5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (Question5 == 6)
{
    TotalAnswers += 1;
    Console.WriteLine("That's correct!");
}
else if (Question5 != 6)
{
    Console.WriteLine("Sorry, that's incorrect.");
}

//end results
Console.WriteLine();
Console.WriteLine("Alright, that's all the questions. Let's see how many you got correct!");
Console.Write("You got "); Console.Write(TotalAnswers); Console.Write(" correct. ");
//bonus messages
if (TotalAnswers <= 0)
{
    Console.WriteLine("Were you even trying?");
}
else if(TotalAnswers <= 3)
{
    Console.WriteLine("C'mon, you can do better.");
}
else if(TotalAnswers < 5)
{
    Console.WriteLine("Almost there!");
}
else
{
    Console.WriteLine("Nice job! Last one was weird, right?");
}
//break between interactive display and automatic commandline message
Console.Write("");
