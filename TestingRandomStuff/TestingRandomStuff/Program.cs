// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hvad hedder du?");
string navn = Console.ReadLine();

Console.WriteLine("Hvor gammel er du?");
int alder = Convert.ToInt32(Console.ReadLine());

string nyAlder = (alder + 1).ToString();

Console.WriteLine($"Hej {navn}");
Console.WriteLine($"Til næste år bliver du {nyAlder} år");