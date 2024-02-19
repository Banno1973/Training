// Dette program skal fortælle hvad en gruppe med et bestemt antal
// medlemmer hedder.
// Programmet er korrekt, når det udskriver den korrekte beskrivelse,
// uanset om du indtaster 1, 2 eller 3.

using System;

Console.WriteLine("Hvor mange er I i gruppen? (1-3 personer)");
int antal = Convert.ToInt32(Console.ReadLine());

if (antal == 1)
{
    Console.WriteLine("Du er solist");
}
else if (antal == 2)
{
    Console.WriteLine("I er en duo");
}
else if (antal == 3) 
{
    Console.WriteLine("I er en trio");
}