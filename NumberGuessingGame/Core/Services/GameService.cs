using NumberGuessingGame.Core.Entities;
using NumberGuessingGame.Core.Enums;
using NumberGuessingGame.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Core.Services
{
    public class GameService : IGuessGameService
    {
        private IGameSettings _settings;
        private Game _game;
        IRandomGeneratorService _randomGenerator;


        public GameService(IGameSettings settings, IRandomGeneratorService randomGenerator)
        {
            _randomGenerator = randomGenerator;
            _settings = settings;
            _game = new Game()
            {
                Status = GameStatus.NotStarted
            };
            _randomGenerator = randomGenerator;

        }

        public void StartNewGame()
        {
            // Завести нвоый инстанс игры
            _game = new Game()
            {
                Status = GameStatus.InProgress,
                MaxNumberOfAttempts = _settings.MaxNubmerOfAttempts,
                MaxNumber = _settings.MaxNumber,
                MinNumber = _settings.MinNumber,
                AttemptsLeft = _settings.MaxNubmerOfAttempts,
                NumberToGuess = _randomGenerator.Generate(_settings.MinNumber, _settings.MaxNumber),
            };

        }

        public void EndGame()
        {
            _game.Status = GameStatus.Finished;
        }
      
        public GameStatus GetGameStatus()
        {
            return _game.Status;
        }

        public int GetAttemptsLeft()
        {
            return _game.AttemptsLeft;
        }

        public GuessResult MakeGuess(int guess)
        {
            _game.AttemptsLeft--;
            
            if (_game.AttemptsLeft <= 0)
            {
                _game.Status = GameStatus.Lose;
                _game.GuessResult = GuessResult.OutOfAttempts;
                return GuessResult.OutOfAttempts;
            }

            switch (guess.CompareTo(_game.NumberToGuess))
            {
                case 0:
                    _game.Status = GameStatus.Win;
                    _game.GuessResult = GuessResult.Correct;
                    break;
                case -1:
                    _game.GuessResult = GuessResult.TooLow;
                    break;
                case 1:
                    _game.GuessResult = GuessResult.TooHigh;
                    break;
            }

            return _game.GuessResult;
        }

    }
}
