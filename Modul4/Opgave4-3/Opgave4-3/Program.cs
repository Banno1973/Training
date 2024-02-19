// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vil du have ananas på din pizza?");

string? svar = Console.ReadLine();

switch (svar?.ToLower())
{
	case "ja":
		Console.WriteLine("Det får du så.");
		break;
	case "nej":
		Console.WriteLine("Okay, du bliver fri.");
		break;
	default:
		Console.WriteLine("Det svar forstår jeg ikke.");
		break;
}

