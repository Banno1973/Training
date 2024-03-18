// See https://aka.ms/new-console-template for more information

string?[] ordliste = new string[5];

for (int i = 0; i < ordliste.Length; i++)
{
    Console.WriteLine("Indtast ord:");
    ordliste[i] = Console.ReadLine();
}

foreach (string str in ordliste)
{
    if (str.Length == 4) Console.WriteLine(str);
}