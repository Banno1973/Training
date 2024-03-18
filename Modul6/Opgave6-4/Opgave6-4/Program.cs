// See https://aka.ms/new-console-template for more information
string?[] salatfavoritter = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Indtast {i + 1}. favorittilbehør til salaten:");
    salatfavoritter[i] = Console.ReadLine();
}

Array.Reverse(salatfavoritter);

foreach (string favorit in salatfavoritter)
{
    Console.WriteLine(favorit);
}
