using Gladiator.Application.Characters;
using Gladiator.Application.Commands;

namespace Gladiator.Application
{
    public class CombatManager
    {
        public Hero Hero;
        public Opponent Opponent;

        public CombatManager(Hero hero, Opponent opponent)
        {
            Hero = hero;
            Opponent = opponent;
        }

        public GameState ResolveCombatRound(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    AttackCommand heroAttack = new AttackCommand(Hero, Opponent);
                    heroAttack.Execute();
                    Console.WriteLine(Opponent.IsAlive);

                    AttackCommand opponentAttack = new AttackCommand(Opponent, Hero);
                    opponentAttack.Execute();
                    Console.WriteLine(Hero.IsAlive);
                    break;
                default:
                    break;
            }

            GameState gameState = GameState.Battle;
            return gameState;
        }
    }
}
