// See https://aka.ms/new-console-template for more information
string vejr;
int temperatur;

Console.WriteLine("Indtast vejret lige nu: ");
vejr = Console.ReadLine();

Console.WriteLine("Indtast temperaturen: ");
temperatur = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Der er lige nu {vejr}, og temperaturen er {temperatur} grader.");
