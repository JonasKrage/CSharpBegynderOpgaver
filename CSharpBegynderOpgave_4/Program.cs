//Opgradér spillet fra Opgave_3 med et Loop sådan at man får flere forsøg når man gætter forkert
//
int Midte = 55;

Random random = new Random();
int Resultat = random.Next(1, 11); //Generere et random tal imellem 0 og 100. (0 er med, men 101 er ikke)

Console.SetCursorPosition(Midte, 1);
Console.WriteLine("Gæt et tal mellem 1 og 10!");

Console.SetCursorPosition(Midte, 3);
int input = Convert.ToInt32(Console.ReadLine());

if (input < Resultat)
{
    Console.SetCursorPosition(Midte, 5);
    Console.WriteLine("Haha, du svarede forkert!");
}
else if (input > Resultat)
{
    Console.SetCursorPosition(Midte, 5);
    Console.WriteLine("Hehe, du svarede forkert!");
}
else
{
    Console.SetCursorPosition(Midte, 5);
    Console.WriteLine("Korrekt!");
}

//while(counter <= 3)
//{
//	Console.WriteLine(counter);
//	counter++;
//}

//Console.ReadKey();
//Console.WriteLine("");

////Eksempel på for loop
//for(int i = 0; i < 10; i += 2)
//{
//	Console.WriteLine(i);
//}
//Console.ReadKey();



