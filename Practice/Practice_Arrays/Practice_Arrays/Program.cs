//Arrays. For when you need to store a collection of items of the same type, but you don't know how many items you'll have at compile time. (Thanks, VS!)
//Formula: (arraytype)[] (arrayname) = new (arraytype)[size];
//The array index always starts at is 0, not 1! So an array of size 5 will have indices 0, 1, 2, 3, and 4. It also must be an integer.

int[] grades = new int[5];
grades[0] = 100;
grades[1] = 90;
grades[2] = 80;
grades[3] = 70;
grades[4] = 60;

int x = 3;

int UserChoice;


//Displays the third grade in the array.
Console.WriteLine("The third grade is: " + grades[2]); Console.WriteLine();

//What if you used a variable for the index output?

Console.WriteLine("The grade at index " + x + " is: " + grades[x]); Console.WriteLine();
//x's value can be changed to access different indices in the array.

//But going one-by-on one is tedious, so we can use a loop to iterate through the array.
//Just to be safe, instead of hardcoding the size of the array, we can use the Length property of the array: (arrayname).Length
for (int i = 0; i < grades.Length; i++)
{
    //(i + 1) is used to display the index in a human-readable way, since arrays start at 0.
    Console.WriteLine("Grade " + (i + 1) + " is: " + grades[i]);
}
Console.WriteLine();

//What if the user wants to access a specific grade?
Console.Write("Enter the grade you would like to see: "); UserChoice = Convert.ToInt32(Console.ReadLine());
//Without an array, you'd need a messy bunch of if statements.
Console.WriteLine("Your grade is: " + grades[UserChoice - 1]); //-1 because arrays start at 0, not 1.

//Final thing: don't use a variable that is larger than the size of the array or smaller than 0, or you'll get an IndexOutOfRangeException.