namespace Gladiator.Application.Characters
{
    public class Hero : Character

    {
        private string name = "Anonymous"; // default assignment to avoid null values
        private double favorMultiplier = 0;

        public string Name { get => name; set => name = value; }
        public double FavorMultiplier { get => favorMultiplier; set => favorMultiplier = value; }
        public Background Background { get; set; }

        public Hero(string name, Background background)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                this.name = name;
            }

            FavorMultiplier = background.FavorMultiplier;
            Background = background;
            AttackPower += background.AttackBonus;
            DefenseRating += background.DefenseBonus;
            MaxLifePoints += background.LifeBonus;
        }
    }
}
