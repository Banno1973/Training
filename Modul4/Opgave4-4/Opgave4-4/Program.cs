// See https://aka.ms/new-console-template for more information
Console.WriteLine("Indtast prisen på varen:");
decimal pris = Convert.ToDecimal(Console.ReadLine());

switch (pris)
{
	case < 10:
		Console.WriteLine($"{pris:C2} er billigt.");
		break;
	case >= 10 and < 100:
		Console.WriteLine($"{pris:C2} er i orden.");
		break;
	// eller default:
	// Det giver det samme resultat
	case >= 100:
		Console.WriteLine($"{pris:C2} er dyrt.");
		break;
}


