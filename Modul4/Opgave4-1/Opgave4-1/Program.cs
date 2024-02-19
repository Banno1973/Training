// See https://aka.ms/new-console-template for more information
const string mitNavn = "Per";

Console.WriteLine("Indtast dit navn: ");
string? ditNavn = Console.ReadLine();

string resultat = (mitNavn == ditNavn) ? "Samme som mit. Fantastisk!" : $"{ditNavn} er okay, men alligevel ikke en {mitNavn}!";
Console.WriteLine(resultat);

//Console.WriteLine((mitNavn == ditNavn) ? "Samme som mit. Fantastisk!" : $"{ditNavn} er okay, men alligevel ikke en {mitNavn}!");