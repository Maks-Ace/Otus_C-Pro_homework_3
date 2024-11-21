using NumberGuessingGame.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Core.Entities
{
    public class Game
    {
        public int MaxNumberOfAttempts { get; set; }

        public int AttemptsLeft { get; set; }

        public int MinNumber {  get; set; }

        public int MaxNumber {  get; set; }

        public int NumberToGuess { get; set; }

        public GameStatus Status { get; set; }

        public GuessResult GuessResult { get; set; }
    }
}
