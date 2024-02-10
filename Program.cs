using System;

//Napisz program, który składa dowolne dwa łańcuchy tekstowe. Użytkownik podaje pierwszy i drugi łańcuch. Wyświetl wyniki tej operacji.

class Konkatenacja
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj piwerszy łańcuch tekstowy: ");
        string pierwszyLancuch = Console.ReadLine();

        Console.WriteLine("Podaj drugi łańcuch tekstowy: ");
        string drugiLancuch = Console.ReadLine();

        string poloczoneLancuchy = pierwszyLancuch + drugiLancuch;
        Console.WriteLine($"Wynik połączenia podanych łańcuchów: {poloczoneLancuchy}.");
    }
}