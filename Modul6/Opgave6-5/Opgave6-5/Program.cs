// See https://aka.ms/new-console-template for more information
string?[] venner = new string[3];
string mitNavn = "per";
bool mitNavnFundet = false;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Indtast navnet på din {i + 1}. ven:");
    venner[i] = Console.ReadLine();
    
    if (venner[i].Equals(mitNavn, StringComparison.CurrentCultureIgnoreCase))
    {
        mitNavnFundet = true;
    }
}

foreach (var item in venner)
{
    Console.WriteLine(item);
}

if (mitNavnFundet)
{
    Console.WriteLine("Godt, du huskede mig!");
} else
{
    Console.WriteLine("Øv, jeg troede, jeg var i din top 3!");
}

