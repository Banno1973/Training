// See https://aka.ms/new-console-template for more information

Console.WriteLine("Indtast temperaturen lige nu: ");

int temperatur = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((temperatur >= 20) ? "Det er dejligt varmt" : "Brr! Det er koldt!");
