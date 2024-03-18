// See https://aka.ms/new-console-template for more information
int antal;
string?[] huskeliste;

Console.WriteLine("Indtast antal elementer i huskelisten:");
antal = Convert.ToInt32(Console.ReadLine());

huskeliste = new string[antal];

for (int i = 0; i < antal; i++)
{
    Console.WriteLine("Indtast element:");
    huskeliste[i] = Console.ReadLine();
}

foreach (var i in huskeliste)
{
    Console.WriteLine(i);
}

