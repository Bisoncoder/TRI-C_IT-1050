//password guesser, but three tries locks the user out
//KEEP IT SIMPLE, STUPID

string pw;
int pwbad = 0;

do
{
    Console.Write("PLease enter your password: ");
    pw = Console.ReadLine(); 
    pwbad++;
    Console.WriteLine();
    
} while (pw != "doofus" && pwbad < 3);

if (pw == "doofus")
{
    Console.Write("Welcome [user]!");
    Console.WriteLine();
}
else
{
    Console.WriteLine("GET OUT OF HERE, STALKER!");
}

//KEEP IT SIMPLE, STUPID