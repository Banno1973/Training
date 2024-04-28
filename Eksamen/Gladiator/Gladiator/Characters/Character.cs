namespace Gladiator.Characters
{
    using System;

    public abstract class Character
    {
        public string Name { get; private set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int MaxLifePoints { get; private set; }

        private int _currentLifePoints;

        public int LifePoints
        {
            get { return _currentLifePoints; }
            private set { _currentLifePoints = Math.Max(0, Math.Min(value, MaxLifePoints)); }
        }

        // Shared d20 for all attack rolls, protected so derived classes can access it
        protected static Dice attackDice = new(20);

        public Character(string name, int attack, int defense, int maxLifePoints)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            MaxLifePoints = maxLifePoints;
            _currentLifePoints = maxLifePoints;
        }

        public bool IsAlive()
        {
            return LifePoints > 0;
        }

        public void TakeDamage(int damage)
        {
            LifePoints -= damage;
        }

        public void ResetLifePoints()
        {
            LifePoints = MaxLifePoints;
        }

        public void RegainLifePoints(int lifePoints)
        {
            LifePoints += lifePoints;
        }

        public abstract void PerformAttack(Character opponent);
    }
}

