// Opret en liste af drikkevarer
List<Drikkevare> drikkevarer = new List<Drikkevare>
            {
                // Tilføj drikkevarer til listen
                new Drikkevare("Almindelig kaffe", 6.00, true, true, false),
                new Drikkevare("Latte Macchiato", 9.00, true, false, false),
                new Drikkevare("Cappuccino", 6.00, true, true, false),
                new Drikkevare("Espresso", 6.00, true, true, false),
                new Drikkevare("The", 5.00, true, true, false),
                new Drikkevare("Cacao", 7.00, false, false, true),
                new Drikkevare("Suppe", 7.00, false, false, false)
            };

// Menu
Console.WriteLine("Velkommen til Kaffeautomaten!");
Console.WriteLine("Vælg en drikkevare fra listen ved at indtaste et nummer:");
Console.WriteLine();

// Vis alle drikkevarer 
for (int i = 0; i < drikkevarer.Count; i++)
{
    Console.WriteLine($"{i + 1}. {drikkevarer[i].Navn} - {drikkevarer[i].Pris:C}");
}

// Bed brugeren om at vælge en drikkevare
Console.Write("\nIndtast nummeret på den ønskede drikkevare: ");
int valgtIndex = Convert.ToInt32(Console.ReadLine());

// Brugervalg
if (valgtIndex > 0 && valgtIndex <= drikkevarer.Count)
{
    Drikkevare valgtDrikkevare = drikkevarer[valgtIndex - 1];

    // Vis en besked om den valgte drikkevare
    Console.WriteLine($"\nDu har valgt: {valgtDrikkevare.Navn}");
    Console.WriteLine($"Pris: {valgtDrikkevare.Pris:C}");

    // Vis tilgængelige tillæg
    Console.WriteLine("Tilgængelige tillæg:");

    // Liste til at gemme valgte tillæg
    List<string> valgteTillæg = [];

    // Loop gennem tillæg
    while (true)
    {
        if (valgtDrikkevare.SukkerTilladt)
        {
            Console.WriteLine("1. Sukker (+1,00 kr)");
            Console.Write("Vil du tilføje sukker? (J/N): ");
            string svar = Console.ReadLine().ToUpper();
            if (svar == "J")
            {
                valgteTillæg.Add("Sukker");
            }
        }

        if (valgtDrikkevare.FlødeTilladt)
        {
            Console.WriteLine("2. Fløde (+1,00 kr)");
            Console.Write("Vil du tilføje fløde? (J/N): ");
            string svar = Console.ReadLine().ToUpper();
            if (svar == "J")
            {
                valgteTillæg.Add("Fløde");
            }
        }

        if (valgtDrikkevare.FlødeskumTilladt)
        {
            Console.WriteLine("3. Flødeskum (+1,00 kr)");
            Console.Write("Vil du tilføje flødeskum? (J/N): ");
            string svar = Console.ReadLine().ToUpper();
            if (svar == "J")
            {
                valgteTillæg.Add("Flødeskum");
            }
        }

        // Hop ud af loop - den kører lidt for længe ellers viser det sig :D 
        break;
    }

    // Beregn den samlede pris
    double totalPris = valgtDrikkevare.Pris + (valgteTillæg.Count * 1.00);

    // Vis de valgte tillæg
    if (valgteTillæg.Count > 0)
    {
        Console.WriteLine("\nValgte tillæg:");
        foreach (var tillæg in valgteTillæg)
        {
            Console.WriteLine(tillæg);
        }
    }

    // Vis den samlede pris
    Console.WriteLine($"\nDen samlede pris er: {totalPris:C}");
}
else
{
    Console.WriteLine("\nUgyldigt valg.");
}

Console.ReadLine(); // Afvent input


public class Drikkevare
{
    public string Navn { get; set; }
    public double Pris { get; set; }
    public bool SukkerTilladt { get; set; }
    public bool FlødeTilladt { get; set; }
    public bool FlødeskumTilladt { get; set; }

    public Drikkevare(string navn, double pris, bool sukkerTilladt, bool flødeTilladt, bool flødeskumTilladt)
    {
        Navn = navn;
        Pris = pris;
        SukkerTilladt = sukkerTilladt;
        FlødeTilladt = flødeTilladt;
        FlødeskumTilladt = flødeskumTilladt;
    }
}