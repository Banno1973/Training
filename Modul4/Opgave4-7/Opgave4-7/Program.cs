// See https://aka.ms/new-console-template for more information
Console.WriteLine("Indtast din LGBTQ identifikation:");
char identifikation = Convert.ToChar(Console.ReadLine());
string resultat;

switch (identifikation.ToString().ToLower())
{
	case "l":
		resultat = "Lesbian";
		break;
    case "g":
        resultat = "Gay";
        break;
    case "b":
        resultat = "Bisexual";
        break;
    case "t":
        resultat = "Transgender";
        break;
    case "q":
        resultat = "Queer";
        break;
    default:
        resultat = "Ingen af delene";
		break;
}

Console.WriteLine($"Du identificerer dig som: {resultat}");
