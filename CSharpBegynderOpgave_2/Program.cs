/*   Opgave 2
    - Udvid dit visitkort fra sidst ved at gøre brug af Forskellige datatyper, variabler og user input.
    - Se bunden af koden for eksempler
 */
Console.BackgroundColor = ConsoleColor.Green;
Console.Clear();

Console.ForegroundColor = ConsoleColor.Magenta; 

int Midte = 40; 
int Svar = 80;

Console.SetCursorPosition(Midte, 0); 
Console.WriteLine("Chat med Jonas AI!");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.SetCursorPosition(Midte, 1);
Console.WriteLine("Spørg om hvad som helst!");

//Spørg: "Hvor gammel er du?"
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.SetCursorPosition(Midte, 2);
string Navn = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(Svar, 3);
Console.WriteLine("12");

//Spørg: "Hvad hedder du?"
Console.ForegroundColor = ConsoleColor.Magenta;
Console.SetCursorPosition(Midte, 4);
string Alder = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(Svar, 5);
Console.WriteLine("Jonas");

//Spørg: "Hvad er dit yndlingsdyr?"
Console.ForegroundColor = ConsoleColor.Red;
Console.SetCursorPosition(Midte, 6);
Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Gray;
Console.SetCursorPosition(Svar, 7);
Console.WriteLine("Næbdyr");

// Spørg "Hvad er din yndlingsfarve?"
Console.ForegroundColor = ConsoleColor.Cyan;
Console.SetCursorPosition(Midte, 8);
Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.SetCursorPosition(Svar, 9);
Console.WriteLine("Cyan");




/*
    Console.SetCursorPosition(5, 1); //Sætter cursorens start position.

    string StrengVariabel = "Blablabla"; //En streng er det samme som en tekst.
    int IntegerVariabel = 0; //En Integer er et Heltal
    double DoubleVariable = 0.5; //En double er et komma-tal
    bool ErEnBoolVariabel = true; //En bool kan have 2 værdier. true eller false.    

    Console.ReadLine(); //Læser brugeren input og returnere en streng. kan f.eks gemmes i en variabel.
    
 */