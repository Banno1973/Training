// See https://aka.ms/new-console-template for more information

string?[] varer = new string[3];
double[] priser = new double[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Indtast varenavn:");
    varer[i] = Console.ReadLine();

    Console.WriteLine("Indtast pris:");
    priser[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{varer[i]}: \t {priser[i]:c}");
}
