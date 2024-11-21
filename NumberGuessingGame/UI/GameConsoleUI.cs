using NumberGuessingGame.Core.Enums;
using NumberGuessingGame.Core.Interfaces;
using NumberGuessingGame.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.UI
{
    internal class GameConsoleUI
    {
        private bool _isRunning = true;
        private IGameService _gameService;

        public GameConsoleUI(IGameService gameService)
        {
            _gameService = gameService;
        }


        public void Run()
        {
            while (_isRunning)
            {
                switch (_gameService.GetGameStatus())
                {
                    case GameStatus.InProgress:
                        ShowInGameInterface();
                        break;
                    case GameStatus.Win:
                        ShowYouWin();
                        break;
                    case GameStatus.Lose:
                        ShowYouLose();
                        break;
                    default:
                        ShowMainMenu();
                        break;
                }
            }
        }

        private void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("*** Угадайка ***");

            Console.Write("\n\rВведите команду:");

            var userInput = Console.ReadLine();

            ProcessUserInput(userInput);
        }

        private void ShowInGameInterface()
        {
            Console.Clear();
            Console.WriteLine($"Количество оставшися попыток: {_gameService.GetAttemptsLeft()}");
            Console.Write($"\n\rВведите число или команду: ");

            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parseResult))
            {
                _gameService.MakeGuess(parseResult);
            }
            else
            {
                ProcessUserInput(userInput);
            }
        }

        private void ShowYouWin()
        {
            Console.Clear();
            Console.WriteLine("Поздравляю вы выиграли!!!");
            Console.ReadKey();
            _gameService.EndGame();
        }

        private void ShowYouLose()
        {
            Console.Clear();
            Console.WriteLine("Ты проиграл!!");
            Console.ReadKey();
            _gameService.EndGame();
        }

        private void ShowHelp()
        {
            Console.Clear();
            Console.WriteLine("*** *** ***\r\nПеречень доступных команд:");
            Console.WriteLine("\n\rnew - запустить новую игру\r\nhelp - вывести справку\n\rfinish - закончить начатую игру\n\rexit - выйти из игру\n\r");

            Console.Write("*** *** ***\n\r Нажмите любую клавишу для выхода из подсказки");
            Console.ReadKey();
            Console.Clear();
        }

        private void ProcessUserInput(string? userInput)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return;
            }


            switch (userInput.ToLower().Trim())
            {
                case "exit":
                    _isRunning = false;
                    break;
                case "new":
                    _gameService.StartNewGame();
                    break;
                case "help":
                    ShowHelp();
                    break;
                case "finish":
                    _gameService.EndGame();
                    break;
                default:
                    Console.WriteLine("\n\rНеизвестная команда, для подскази введите help");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
