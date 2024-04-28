﻿using Gladiator.Characters;

public class Game
{
    private Hero _hero;
    private Opponent _currentOpponent;
    private int _currentMatch = 0;
    private const int TotalMatches = 5;  // Total number of matches including the champion

    public Game()
    {
        Console.WriteLine("Welcome to the Gladiator Arena!");
        Console.Write("Enter the name of your hero: ");
        string heroName = Console.ReadLine();
        _hero = new Hero(heroName, 3, 10, 15);  // Initialize hero with initial stats
    }

    public void Start()
    {
        for (int i = 0; i < TotalMatches; i++)
        {
            Console.Clear(); // Clear the console for a new match screen
            Console.WriteLine($"Match {i + 1}");
            SetupOpponent(i);

            Console.WriteLine("Press any key to start the match...");
            Console.ReadKey();

            if (!ConductMatch())
            {
                Console.WriteLine("You have been defeated. Press any key to restart the game...");
                Console.ReadKey();
                return;
            }

            if (i < TotalMatches - 1) // Check if there are more matches left
            {
                Console.WriteLine("You won the match! Press any key to proceed to the next match...");
                Console.ReadKey();
            }

            _hero.ResetLifePoints();  // Reset hero's life points after each match
        }

        Console.WriteLine("Congratulations! You've defeated all opponents, including the champion!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    private void SetupOpponent(int matchNumber)
    {
        int life = 6 + matchNumber * 2;  // Incremental increase in life
        int attack = 1 + matchNumber;    // Incremental increase in attack
        int defense = 7 + matchNumber;   // Incremental increase in defense
        _currentOpponent = new Opponent($"Opponent {matchNumber + 1}", attack, defense, life);
    }

    private void DisplayMatchStats()
    {
        Console.WriteLine("Match Stats:");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($"| {_hero.Name, -10} | Attack: {_hero.Attack, 3} | Defense: {_hero.Defense, 3} | Life: {_hero.LifePoints, 3} |");
        Console.WriteLine($"| {_currentOpponent.Name, -10} | Attack: {_currentOpponent.Attack, 3} | Defense: {_currentOpponent.Defense, 3} | Life: {_currentOpponent.LifePoints, 3} |");
        Console.WriteLine("-------------------------------------------------------");
    }

    private bool ConductMatch()
    {
        Console.WriteLine($"Match {_currentMatch + 1}: Your opponent is {_currentOpponent.Name} with {_currentOpponent.LifePoints} life points.");

        // Simulate hero and opponent take turns attacking in a match
        while (_hero.IsAlive() && _currentOpponent.IsAlive())
        {
            Console.Clear(); // Clear console between each combat round
            DisplayMatchStats(); // Display tabulated stats for the hero and opponent
            Console.WriteLine("\nAvailable Actions:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend. Do nothing, by regain 1d4 life.");
            Console.WriteLine("Choose an action (enter the number): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _hero.PerformAttack(_currentOpponent);
                    break;
                case "2":
                    _hero.Defend();
                    break;
                default:
                    Console.WriteLine("Invalid input, lost your turn!");
                    break;
            }

            if (_currentOpponent.IsAlive())
            {
                _currentOpponent.PerformAttack(_hero);
                if (!_hero.IsAlive())
                {
                    Console.WriteLine("You have been defeated in the arena.");
                    return false;  // Game ends
                }
            }
            Console.WriteLine("Press any key to proceed to next combat round...");
            Console.ReadKey();
        }

        if (_hero.IsAlive())
        {
            Console.WriteLine($"You won Match {_currentMatch + 1}!");
            _currentMatch++;
            return true;  // Hero survives, proceed to next match
        }
        else
        {
            Console.WriteLine("You have been defeated in the arena.");
            return false;  // Game ends
        }
    }
}

