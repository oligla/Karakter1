Console.Write("Indtast score (0-100): ");
int score = int.Parse(Console.ReadLine());

if (score > 89)
{
    Console.WriteLine("Din karakter er 12");
}
else if (score > 79)
{

    Console.WriteLine("Din karakter er 10");
}
else if (score > 64)
{
    Console.WriteLine("Din karakter er 7");
}
else if (score > 49)
{
    Console.WriteLine("Din karakter er 4");
}
else if (score > 24)
{
    Console.WriteLine("Din karakter er 02");
}
else if (score > 9)
{
    Console.WriteLine("Din karakter er 00");
}
else
{
    Console.WriteLine("Din karakter er -3");
}
   
 