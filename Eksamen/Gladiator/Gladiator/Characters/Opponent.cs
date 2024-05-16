namespace Gladiator.Characters
{
    using System;
    using Gladiator.Utilities;

    public class Opponent : Character
    {
        public Opponent(string name, int attack, int defense, int maxLifePoints, Dice damageDice)
            : base(name, attack, defense, maxLifePoints, damageDice) { }

        public override void PerformAttack(Character hero)
        {
            int attackRoll = attackDice.Roll();
            int totalAttackRoll = attackRoll + Attack;

            Console.WriteLine($"{Name} rolls a {attackRoll} on a 1d20 + {Attack} for a total of {totalAttackRoll}!\n");

            if (totalAttackRoll >= hero.Defense)
            {
                int damage = DamageDice.Roll();
                int totalDamage = damage;

                // Increase damage when below 33% health
                if (LifePoints < MaxLifePoints / 3)
                {
                    totalDamage += 1; 
                    Console.WriteLine($"{Name} enrages due to low health and deals 1 extra damage!");
                }

                hero.TakeDamage(totalDamage);
                Console.WriteLine($"{Name} attacks {hero.Name} and rolls 1d{DamageDice.GetDieSides()} for {totalDamage} damage. " +
                                    $"They reduced your life to {hero.LifePoints}!\n");
            }
            else
            {
                Console.WriteLine($"{Name} attacks {hero.Name} but misses.\n");
            }
        }
    }
}
