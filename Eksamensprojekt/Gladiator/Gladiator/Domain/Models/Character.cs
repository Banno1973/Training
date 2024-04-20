using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Domain.Models
{
    internal class Character
    {
        private int attackPower;
        private int defenseRating;
        private int lifePoints;

        protected int AttackPower { get => attackPower; set => attackPower = value; }
        protected int DefenseRating { get => defenseRating; set => defenseRating = value; }
        protected int LifePoints { get => lifePoints; set => lifePoints = value; }
    }
}
