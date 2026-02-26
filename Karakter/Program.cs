int score;

while (true)
{
    Console.Write("Indtast din score (0-100): ");
    string scoreInputBruger = Console.ReadLine();

    if (int.TryParse(scoreInputBruger, out score))
    {
        if (score >= 0 && score <= 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("Den indtastede score skal være mellem 0 og 100.");
        }
    }
    else
    {
        Console.WriteLine("Det er ikke et tal, skriv venligst kun heltal.");
    }
}

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
   
