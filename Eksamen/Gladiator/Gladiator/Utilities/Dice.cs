namespace Gladiator.Utilities
{
    public class Dice
    {
        private Random _random;
        private int _sides;

        public Dice(int sides)
        {
            _sides = sides;
            _random = new Random();
        }

        public int GetDieSides()
        {
            return _sides;
        }

        // Roll a die numberOfDice times and sum the results - roll 1 die as default
        public int Roll(int numberOfDice = 1)
        {
            int total = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                total += _random.Next(1, _sides + 1);
            }
            return total;
        }
    }
}
