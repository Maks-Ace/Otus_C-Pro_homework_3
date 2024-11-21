using NumberGuessingGame.Core.Interfaces;

namespace NumberGuessingGame.Core.Entities
{
    public class GameSettings : IGameSettings
    {
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
        public int MaxNubmerOfAttempts { get ; set ; }
    }
}
