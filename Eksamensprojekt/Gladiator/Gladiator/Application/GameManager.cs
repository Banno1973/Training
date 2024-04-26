using Gladiator.Application.Characters;
using Gladiator.Screens;

namespace Gladiator.Application
{
    public class GameManager
    {
        private GameState currentState;
        private ScreenManager screenManager;
        private CombatManager combatManager;
        private string playerName;
        private Hero hero;
        private Opponent opponent;

        public GameManager()
        {
            currentState = GameState.Welcome;
            screenManager = new ScreenManager();
        }

        public void Run()
        {
            InitializeGame();

            while (currentState != GameState.GameOver)
            {
                RenderScreen(currentState);
                ProcessInput();
                UpdateGameState();
            }
        }

        private void RenderScreen(GameState currentState)
        {
            // Render screen based on game state
            switch (currentState)
            {
                case GameState.Welcome:
                    WelcomeScreen.Render();
                    break;
                case GameState.HeroCreation:
                    HeroCreatorScreen.Render();
                    break;
                case GameState.FirstRound:
                    FirstRoundScreen.Render();
                    break;
                case GameState.NewBattle:
                    break;
                case GameState.Battle:
                    BattleScreen battleScreen = new(); // pass by value or reference...?
                    battleScreen.Render(hero, opponent);
                    break;
                case GameState.GameOver:
                    GameOverScreen.Render();
                    break;
            }
        }

        private void ProcessInput()
        {
            // Get user input
            string userInput = Console.ReadLine();

            // Process input based on game state
            switch (currentState)
            {
                case GameState.Welcome:
                    // Handle input from Welcome screen
                    playerName = userInput;
                    break;
                case GameState.HeroCreation:
                    // Handle hero creation
                    int backgroundSelection = Convert.ToInt32(userInput);
                    hero = new Hero(playerName, BackgroundsRepository.Backgrounds[backgroundSelection - 1]);
                    Console.WriteLine(hero.Background.Name);
                    hero.DisplayStats();
                    break;
                case GameState.FirstRound:
                    opponent = new Opponent($"Opponent #{GameProgressTracker.MatchNumber}");
                    combatManager = new CombatManager(hero, opponent);
                    break;
                case GameState.Battle:
                    // Handle battle input
                    combatManager.ResolveCombatRound(userInput);
                    Console.ReadLine();
                    break;
                    // Add cases for other game states
            }
        }

        private void UpdateGameState()
        {
            // Update game state based on game logic
            switch (currentState)
            {
                case GameState.Welcome:
                    currentState = GameState.HeroCreation;
                    break;
                case GameState.HeroCreation:
                    currentState = GameState.FirstRound;
                    break;
                case GameState.FirstRound:
                    currentState = GameState.Battle;
                    break;
                case GameState.Battle:
                    if (!hero.IsAlive)
                    {
                        currentState = GameState.GameOver;
                    }
                    break;
                    // Add cases for other game states
            }
        }

        private void InitializeGame()
        {
            BackgroundsRepository.Initialize("backgrounds.json");
            GameProgressTracker.MatchNumber = 1;
        }
    }
}
