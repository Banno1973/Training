// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hvad vil du have at drikke?");
string? drik = Console.ReadLine();

if (drik.Equals("kaffe", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Kaffe er det rigtige valg!"); 
} 
else
{
    Console.WriteLine("Det er da også okay...");
}