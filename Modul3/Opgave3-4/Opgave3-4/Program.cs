// See https://aka.ms/new-console-template for more information
Console.Write("Indtast antal sider i dit dokument: ");
int antalSider = Convert.ToInt32(Console.ReadLine());
int antalSiderSparet = antalSider / 2;

if (antalSiderSparet > 0) 
{ 
    Console.WriteLine($"Du sparer {antalSiderSparet} ved at printe dobbeltsidet");
} 
else
{
    Console.WriteLine($"Du sparer intet ved at printe dobbeltsidet.");
}