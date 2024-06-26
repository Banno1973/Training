﻿namespace Gladiator.Characters
{
    using System;
    using Gladiator.Utilities;

    public class Hero : Character
    {
        public Hero(string name, int attack, int defense, int maxLifePoints, Dice damageDice)
            : base(name, attack, defense, maxLifePoints, damageDice) { }

        public override void PerformAttack(Character opponent)
        {
            int diceRoll = attackDice.Roll();
            int totalAttackRoll = diceRoll + Attack; 

            Console.WriteLine($"{Name} rolls a {diceRoll} on a 1d20 + {Attack} for a total of {totalAttackRoll}!\n");

            if (totalAttackRoll >= opponent.Defense)
            {
                int damage = DamageDice.Roll();
                opponent.TakeDamage(damage);
                Console.WriteLine($"{Name} attacks {opponent.Name} and rolls 1d{DamageDice.GetDieSides()} for {damage} damage! " +
                                    $"You reduced their life to {opponent.LifePoints}!\n");
            }
            else
            {
                Console.WriteLine($"{Name} attacks {opponent.Name} but misses.\n");
            }
        }

        public void Defend() 
        {
            Dice healingDie = new (4);
            int lifePointsGained = healingDie.Roll();

            Console.WriteLine($"You fend off your opponent to catch your breath. You roll a 1d4 and regain {lifePointsGained} life points.\n");
            
            RegainLifePoints(lifePointsGained);
        }

        public void RecklessAttack(Character opponent)
        {
            Dice selfDamageDie = new(4);
            int selfDamage = selfDamageDie.Roll();
            int opponentDamage = DamageDice.Roll();

            opponent.TakeDamage(opponentDamage);

            Console.WriteLine($"{Name} recklessly attacks {opponent.Name} and rolls 1d6 for {opponentDamage} damage, " +
                                $"but loses {selfDamage} life points!\n" +
                                $"You reduced their life to {opponent.LifePoints}!\n");

            if (opponent.IsAlive()) 
            { 
                TakeDamage(selfDamage); 
            }
        }

        public void Cheat(Character opponent) 
        {
            Console.WriteLine($"You cheat and do 100 damage!");
            opponent.TakeDamage(100);
        }
    }

}