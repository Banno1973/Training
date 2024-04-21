using Gladiator.Application;
using Gladiator.Application.Characters;
using Gladiator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Screens
{
    public class BattleScreen : IScreenWithData<Hero>
    {
        public void Render(Hero hero)
        {
            Console.Clear();
            Console.WriteLine("\nB A T T L E");
            Console.WriteLine("-----------");
            Console.WriteLine($"Match number: {GameProgressTracker.MatchNumber}");

            Console.WriteLine("\nPlayer stats\t\tOpponent stats");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Attack bonus: \t{hero.AttackPower}\t\t{hero.AttackPower}");
            Console.WriteLine($"Defense: \t{hero.DefenseRating}\t\t{hero.DefenseRating}");
            Console.WriteLine($"Max life: \t{hero.MaxLifePoints}\t\t{hero.MaxLifePoints}");
            Console.WriteLine($"Current life: \t{hero.CurrentLifePoints}\t\t{hero.CurrentLifePoints}");

            Console.WriteLine("\nBattle options");
            Console.WriteLine("--------------");
            Console.WriteLine("[1] Attack");


        }
    }
}
