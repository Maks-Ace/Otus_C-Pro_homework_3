using NumberGuessingGame.Core.Entities;
using NumberGuessingGame.Core.Interfaces;
using NumberGuessingGame.Core.Services;
using NumberGuessingGame.UI;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var settings = new GameSettings();
            settings.MaxNubmerOfAttempts = 10;
            settings.MaxNumber = 10;
            settings.MinNumber = 0;

            var randomGenerator = new RandomNumberGeneratorService();
            
            var gameService = new GameService(settings, randomGenerator);

            var game = new GameConsoleUI(gameService);

            game.Run();
        }
    }
}
