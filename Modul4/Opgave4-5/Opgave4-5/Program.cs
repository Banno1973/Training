// See https://aka.ms/new-console-template for more information

const string sne = "sne";
const string frost = "frostvejr";

Console.WriteLine("Hvordan er vejret?");
string? vejr  = Console.ReadLine();

Console.WriteLine("Hvad er temperaturen?");
double temperatur = Convert.ToDouble(Console.ReadLine());

if (vejr is not null && (vejr.Equals(sne, StringComparison.OrdinalIgnoreCase) || vejr.Equals(frost, StringComparison.OrdinalIgnoreCase)) && temperatur < 0)
{
    Console.WriteLine("Jeg tror, det er vinter.");
}