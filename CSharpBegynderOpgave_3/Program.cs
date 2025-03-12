//Lav et spil hvor man kan gætte et, af computeren, random genereret tal.


int Midte = 55;

Console.SetCursorPosition(Midte, 1);

Console.BackgroundColor = ConsoleColor.Black;

Random random = new Random();
int Resultat = random.Next(1, 1001); //Generere et random tal imellem 0 og 100. (0 er med, men 101 er ikke)

Console.SetCursorPosition(Midte, 3);
Console.WriteLine("Indtast et tal");

Console.BackgroundColor = ConsoleColor.Black;

Console.SetCursorPosition(Midte, 5);
int input = Convert.ToInt32(Console.ReadLine());


if(input > Resultat)
{
    Console.SetCursorPosition(Midte, 7);
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Du gættede forkert");
}
else if(input < Resultat)
{
    Console.SetCursorPosition(Midte, 7);
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Hehehehhehhehehehe Du gættede forkert");
}
else
{
    Console.SetCursorPosition(Midte, 7);
    Console.BackgroundColor = ConsoleColor.Green;
	Console.WriteLine("korrekt!");
}

Console.BackgroundColor = ConsoleColor.Black;

Console.ReadKey();