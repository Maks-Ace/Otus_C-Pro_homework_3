using Microsoft.Extensions.Configuration;
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
            GameSettings settings = GetSettingsFromConfig();

            var randomGenerator = new RandomNumberGeneratorService();

            var gameService = new GameService(settings, randomGenerator);

            var game = new GameConsoleUI(gameService);

            game.Run();
        }

        private static GameSettings GetSettingsFromConfig()
        {
            var myConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();


            int.TryParse(myConfig["MaxNubmerOfAttempts"], out int maxNubmerOfAttempts);
            int.TryParse(myConfig["MaxNumber"], out int maxNumber);
            int.TryParse(myConfig["MinNumber"], out int minNumber);


            var settings = new GameSettings();
            settings.MaxNubmerOfAttempts = maxNubmerOfAttempts;
            settings.MaxNumber = maxNumber;
            settings.MinNumber = minNumber;
            
            return settings;
        }
    }
}
