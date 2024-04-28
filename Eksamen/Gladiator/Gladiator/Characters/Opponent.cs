namespace Gladiator.Characters
{
    using System;

    public class Opponent : Character
    {
        public Opponent(string name, int attack, int defense, int maxLifePoints)
            : base(name, attack, defense, maxLifePoints) { }

        public override void PerformAttack(Character opponent)
        {
            int diceRoll = attackDice.Roll();
            int totalAttackRoll = diceRoll + Attack;

            Console.WriteLine($"{Name} rolls a {diceRoll} on a 1d20 + {Attack} for a total of {totalAttackRoll}!");

            if (totalAttackRoll >= opponent.Defense)
            {
                Random rng = new Random();
                int damage = rng.Next(1, 6);  // Simulating damage roll (1d6 for Opponent)
                opponent.TakeDamage(damage);
                Console.WriteLine($"{Name} attacks {opponent.Name} for {damage} damage. They reduced your life to {opponent.LifePoints}!");
            }
            else
            {
                Console.WriteLine($"{Name} attacks {opponent.Name} but misses.");
            }
        }
    }

}
