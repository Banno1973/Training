// See https://aka.ms/new-console-template for more information

string?[] favoritter = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Hvad er din { i + 1 }. favoritting?");
    favoritter[i] = Console.ReadLine();
}

foreach (var ting in favoritter)
{
    Console.WriteLine(ting);
}
