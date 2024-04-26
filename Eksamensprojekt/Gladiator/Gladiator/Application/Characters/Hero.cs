namespace Gladiator.Application.Characters
{
    public class Hero : Character

    {
        private double favorMultiplier = 0;
        public string Name { get; set; }
        public double FavorMultiplier { get => favorMultiplier; set => favorMultiplier = value; }
        public Background Background { get; set; }

        public Hero(string name, Background background)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }
            else
            {
                Name = "Unknown";
            }

            FavorMultiplier = background.FavorMultiplier;
            Background = background;
            AttackPower += background.AttackBonus;
            DefenseRating += background.DefenseBonus;
            MaxLifePoints += background.LifeBonus;
        }
    }
}
