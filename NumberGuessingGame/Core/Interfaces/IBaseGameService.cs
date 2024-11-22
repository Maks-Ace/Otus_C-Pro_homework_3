using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Core.Interfaces
{
    /// <summary>
    /// Базовый интерфейс игры, содержит только методы начать и закончить игру 
    /// Создан для демонстрации ISP
    /// </summary>
    public interface IBaseGameService
    {
        void StartNewGame();

        void EndGame();
    }
}
