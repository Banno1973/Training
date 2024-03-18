// See https://aka.ms/new-console-template for more information

int[] talrække = new int[5];

for (int i = 0; i < 5 ; i++)
{
    Console.WriteLine("Indtast tal:");
    talrække[i] = Convert.ToInt32(Console.ReadLine());  
}

foreach (var tal in talrække)
{
    if (tal > 10) Console.WriteLine(tal);
}