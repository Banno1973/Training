// See https://aka.ms/new-console-template for more information

int?[] talrække = new int?[5];
int tæller = 0;

Console.WriteLine("Indtast 5 listen:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Indtast tal");
    talrække[i] = Convert.ToInt32(Console.ReadLine());
    if (talrække[i] < 5) tæller++;
}

Console.WriteLine($"Der er {tæller} tal, der er mindre end 5");