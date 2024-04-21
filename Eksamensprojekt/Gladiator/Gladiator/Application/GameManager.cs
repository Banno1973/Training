using Gladiator.Application.Characters;
using Gladiator.Screens;

namespace Gladiator.Application
{
    public class GameManager
    {
        private GameState currentState;
        private ScreenManager screenManager;
        private string playerName;
        private Hero hero;

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
                case GameState.Battle:
                    BattleScreen battleScreen = new(); // pass by value or reference...?
                    battleScreen.Render(hero);
                    break;
                    // Add cases for other game states
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
                    break;
                case GameState.Battle:
                    // Handle battle input
                    //HandleBattleInput(userInput);
                    break;
                    // Add cases for other game states
            }
        }

        //private void HandleBattleInput(string userInput)
        //{
        //    // Parse user input and execute corresponding command
        //    switch (userInput.ToLower())
        //    {
        //        case "attack":
        //            ICommand attackCommand = new AttackCommand();
        //            attackCommand.Execute();
        //            break;
        //            // Add cases for other player actions
        //    }
        //}

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
                    // Handle battle input
                    //HandleBattleInput(userInput);
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
