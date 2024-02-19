// See https://aka.ms/new-console-template for more information
Console.WriteLine("Indtast dit køn:");
string? køn = Console.ReadLine();

Console.WriteLine("Indtast din alder:");
int alder = Convert.ToInt32(Console.ReadLine());

if (alder >= 50 && køn.ToLower() == "mand")
{
    Console.WriteLine("Du bør screenes for prostatakræft.");
}
else if (alder < 50 && køn.ToLower() == "mand")
{
    Console.WriteLine("Du bør screenes for prostatakræft, når du bliver 50");
}
else if (køn.ToLower() == "kvinde")
{
    Console.WriteLine("Du er ikke i risikogruppen for prostatakræft");
}