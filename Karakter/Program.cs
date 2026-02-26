using System.ComponentModel.Design;
using System.Data;

int score;
int karakter;


while (true)
{
    Console.Write("Indtast din score (0-100): ");
    string scoreInputBruger = Console.ReadLine();

    if (int.TryParse(scoreInputBruger, out score))
    {
        if (ErGyldigScore(score))
        {
            karakter = BeregnKarakter(score);
            Console.WriteLine($"Din karakter er: {karakter}");
            break;
        }
        else
        {
            Console.WriteLine("Den indtastede score skal være mellem 0-100");
        }

    }
    else
    {
        Console.WriteLine("Det er ikke et tal, skriv venligst kun heltal.");
    }
}




    static int BeregnKarakter(int score)
    {
        if (score > 89)
        {
            return 12;
        }
        else if (score > 79)
        {
            return 10;
        }
        else if (score > 64)
        {
            return 7;
        }
        else if (score > 49)
        {
            return 4;
        }
        else if (score > 24)
        {
            return 02;
        }
        else if (score > 9)
        {
            return 00;
        }
        else
        {
            return -3;
        }
    }

    static bool ErGyldigScore(int score)
    {
        if (score >= 0 && score <= 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
