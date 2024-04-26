using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Application.Characters
{
    public class Character
    {
        private string _name;
        private int _attackPower;
        private int _defenseRating;
        private int _maxLifePoints;
        private int _currentLifePoints;
        private bool _isAlive;

        public string Name { get => _name; set => _name = value; }
        public int AttackPower { get => _attackPower; set => _attackPower = value; }
        public int DefenseRating { get => _defenseRating; set => _defenseRating = value; }
        public int MaxLifePoints { get => _maxLifePoints; set => _maxLifePoints = value; }
        public int CurrentLifePoints { get => _currentLifePoints; set => _currentLifePoints = value; }
        public bool IsAlive { get => _isAlive; set => _isAlive = value; }

        public Character(string name)
        {
            Name = name;
            AttackPower = 0;
            DefenseRating = 10;
            MaxLifePoints = 10;
            CurrentLifePoints = MaxLifePoints;
            IsAlive = true;
        }

        public Character()
        {
            AttackPower = 0;
            DefenseRating = 10;
            MaxLifePoints = 10;
            CurrentLifePoints = MaxLifePoints;
            IsAlive = true;
        }

        public Character(int attackPower, int defenseRating, int maxLifePoints, bool isAlive)
        {
            _attackPower = attackPower;
            _defenseRating = defenseRating;
            _maxLifePoints = maxLifePoints;
            _currentLifePoints = maxLifePoints;
            _isAlive = isAlive;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Attack Power: {AttackPower}");
            Console.WriteLine($"Defense Rating: {DefenseRating}");
            Console.WriteLine($"Max life: {MaxLifePoints}");
            Console.WriteLine($"Current life: {MaxLifePoints}");
        }

        public void ReduceLifePoints(int damage)
        {
            // Reduce current life with damage number
            _currentLifePoints -= damage;
            
            // Character dies, if damage reduces character's life points to 0 or less
            if (_currentLifePoints <= 0)
            {
                IsAlive = false;
            }        
        }
    }
}
