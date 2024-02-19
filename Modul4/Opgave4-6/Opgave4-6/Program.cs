// See https://aka.ms/new-console-template for more information
Console.WriteLine("Indtast dit køn:");
string? køn = Console.ReadLine();

Console.WriteLine("Indtast din alder:");
int alder = Convert.ToInt32(Console.ReadLine());

if (alder >= 16 && køn.ToLower() == "mand")
{
    Console.WriteLine("Du spiller på senior herreholdet.");
} 
else if (alder >= 16 && køn.ToLower() == "kvinde")
{
    Console.WriteLine("Du spiller på senior dameholdet");
}
else if (alder < 16 && køn.ToLower() == "mand")
{
    Console.WriteLine("Du spiller på junior herreholdet");
}
else if (alder < 16 && køn.ToLower() == "kvinde")
{
    Console.WriteLine("Du spiller på junior dameholdet");
}
