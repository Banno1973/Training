// Programmet skal bede brugeren indtaste hvor mange tal, han vil have
// i sit array. Derefter fyldes arrayet med tal fra 0 og op, indtil det
// ønskede antal er opnået.

// Herefter skal programmet udskrive tallene i arrayet i baglæns rækkefølge

Console.WriteLine("Hvor mange tal vil du have?");
int antal = Convert.ToInt32(Console.ReadLine());

int[] tal = new int[antal];
for (int i = 0; i < tal.Length; i++)
{
    tal[i] = i;
}

for (int i = tal.Length - 1; i > 0; i--)
{
    Console.WriteLine(tal[i].ToString());
}