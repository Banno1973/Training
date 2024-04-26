using Gladiator.Application.Characters;
using Gladiator.Interfaces;

namespace Gladiator.Application.Commands
{
    public class AttackCommand : ICommand
    {
        private bool attackSucceeded;
        private int damageDone = 0;

        public Character Attacker { get; set; }
        public Character Defender { get; set; }

        public AttackCommand(Character attacker, Character defender)
        {
            Attacker = attacker;
            Defender = defender;
        }

        public void Execute() 
        {
            attackSucceeded = CalculateAttack();

            if (attackSucceeded)
            {
                damageDone = CalculateDamage();
                Console.WriteLine($"{Attacker.Name} attacks and hits {Defender.Name} for {damageDone} damage!");
                Defender.ReduceLifePoints(damageDone);
            }
            else
            {
                damageDone = 0;
                Console.WriteLine($"{Attacker.Name} attacks, but misses!");
            }
        }

        private bool CalculateAttack()
        {
            Random random = new Random();
            int roll = random.Next(20) + 1;
            int attackRoll = roll + Attacker.AttackPower;
            Console.WriteLine($"{Attacker.Name} rolls a {roll} + {Attacker.AttackPower} for their attack roll.");
            if (attackRoll > Defender.DefenseRating)
            {
                return true;
            };
            return false;
        }

        private int CalculateDamage()
        {
            Random random = new Random();
            int damageRoll = random.Next(6) + 1;
            Console.WriteLine($"{Attacker.Name} rolls a {damageRoll} for their damage.");
            return damageRoll;
        }
    }
}
