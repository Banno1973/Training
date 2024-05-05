namespace Gladiator.Characters
{
    using System;
    using Gladiator.Utilities;

    public class Opponent : Character
    {
        public Opponent(string name, int attack, int defense, int maxLifePoints, Dice damageDice)
            : base(name, attack, defense, maxLifePoints, damageDice) { }

        public override void PerformAttack(Character opponent)
        {
            int attackRoll = attackDice.Roll();
            int totalAttackRoll = attackRoll + Attack;

            Console.WriteLine($"{Name} rolls a {attackRoll} on a 1d20 + {Attack} for a total of {totalAttackRoll}!\n");

            if (totalAttackRoll >= opponent.Defense)
            {
                int damage = DamageDice.Roll();
                opponent.TakeDamage(damage);
                Console.WriteLine($"{Name} attacks {opponent.Name} and rolls 1d{DamageDice.GetDieSides()} for {damage} damage. They reduced your life to {opponent.LifePoints}!\n");
            }
            else
            {
                Console.WriteLine($"{Name} attacks {opponent.Name} but misses.\n");
            }
        }
    }

}
