// See https://aka.ms/new-console-template for more information
Console.WriteLine("Indtast et kortspilnummer:");

int kortnummer = Convert.ToInt32(Console.ReadLine());

switch(kortnummer)
{
    case 1: 
        Console.WriteLine("Es");
        break;
    case 11: 
        Console.WriteLine("Knægt");
        break;
    case 12: 
        Console.WriteLine("Dame");
        break;
    case 13: 
        Console.WriteLine("Konge");
        break;
    default:
        Console.WriteLine($"{kortnummer.ToString()}'er");
        break;
}