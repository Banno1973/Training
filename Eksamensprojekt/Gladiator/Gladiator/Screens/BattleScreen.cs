using Gladiator.Application;
using Gladiator.Application.Characters;

namespace Gladiator.Screens
{
    public class BattleScreen : IScreenWithData<Hero, Opponent>
    {
        public void Render(Hero hero, Opponent opponent)
        {
            Console.Clear();
            Console.WriteLine("\nB A T T L E");
            Console.WriteLine("-----------");
            Console.WriteLine($"Match number: {GameProgressTracker.MatchNumber}");
            Console.WriteLine($"Opponent: {opponent.Name}");

            Console.WriteLine("\nPlayer stats\t\tOpponent stats");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Attack bonus: \t{hero.AttackPower}\t\t{opponent.AttackPower}");
            Console.WriteLine($"Defense: \t{hero.DefenseRating}\t\t{opponent.DefenseRating}");
            Console.WriteLine($"Max life: \t{hero.MaxLifePoints}\t\t{opponent.MaxLifePoints}");
            Console.WriteLine($"Current life: \t{hero.CurrentLifePoints}\t\t{opponent.CurrentLifePoints}");

            Console.WriteLine("\nBattle options");
            Console.WriteLine("--------------");
            Console.WriteLine("[1] Attack");


        }
    }
}
