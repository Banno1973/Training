namespace Gladiator.Characters
{
    using System;

    public class Hero : Character
    {
        public Hero(string name, int attack, int defense, int maxLifePoints)
            : base(name, attack, defense, maxLifePoints) { }

        public override void PerformAttack(Character opponent)
        {
            int diceRoll = attackDice.Roll();
            int totalAttackRoll = diceRoll + Attack; 

            Console.WriteLine($"{Name} rolls a {diceRoll} on a 1d20 + {Attack} for a total of {totalAttackRoll}!");

            if (totalAttackRoll >= opponent.Defense)
            {
                Random rng = new Random();
                int damage = rng.Next(1, 7);  // Simulating damage roll (1d6)
                opponent.TakeDamage(damage);
                Console.WriteLine($"{Name} attacks {opponent.Name} for {damage} damage! You reduced their life to {opponent.LifePoints}!");
            }
            else
            {
                Console.WriteLine($"{Name} attacks {opponent.Name} but misses.");
            }
        }

        public void Defend() 
        {
            Dice healingDie = new (4);
            int lifePointsGained = healingDie.Roll();

            Console.WriteLine($"You fend off your opponent to catch your breath. You roll a 1d4 and regain {lifePointsGained} life points.");
            RegainLifePoints(lifePointsGained);
        }
    }

}