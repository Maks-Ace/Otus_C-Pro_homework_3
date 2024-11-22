using NumberGuessingGame.Core.Entities;
using NumberGuessingGame.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Core.Interfaces
{
    public interface IGuessGameService : IBaseGameService
    {
        GameStatus GetGameStatus();

        GuessResult MakeGuess(int guess);
        
        int GetAttemptsLeft();
    }
}
