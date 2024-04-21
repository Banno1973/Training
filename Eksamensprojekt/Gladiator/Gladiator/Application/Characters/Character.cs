using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Application.Characters
{
    public class Character
    {
        private int attackPower;
        private int defenseRating;
        private int maxLifePoints;
        private int currentLifePoints;

        public int AttackPower { get => attackPower; set => attackPower = value; }
        public int DefenseRating { get => defenseRating; set => defenseRating = value; }
        public int MaxLifePoints { get => maxLifePoints; set => maxLifePoints = value; }
        public int CurrentLifePoints { get => currentLifePoints; set => currentLifePoints = value; }

        public Character()
        {
            AttackPower = 0;
            DefenseRating = 10;
            MaxLifePoints = 10;
            CurrentLifePoints = MaxLifePoints;
        }

        public Character(int attackPower, int defenseRating, int maxLifePoints)
        {
            this.attackPower = attackPower;
            this.defenseRating = defenseRating;
            this.maxLifePoints = maxLifePoints;
            this.currentLifePoints = maxLifePoints;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Attack Power: {AttackPower}");
            Console.WriteLine($"Defense Rating: {DefenseRating}");
            Console.WriteLine($"Max life: {MaxLifePoints}");
            Console.WriteLine($"Current life: {MaxLifePoints}");
        }
    }
}
