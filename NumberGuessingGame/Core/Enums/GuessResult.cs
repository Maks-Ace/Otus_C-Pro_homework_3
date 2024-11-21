using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Core.Enums
{
    /// <summary>
    /// Результаты шага угадывания
    /// </summary>
    public enum GuessResult
    {
        /// <summary>
        /// Верный вариант
        /// </summary>
        Correct = 0,

        /// <summary>
        ///  Слишком  мальенькое число
        /// </summary>
        TooLow = 1,
        
        /// <summary>
        /// Слишком большое число
        /// </summary>
        TooHigh = 2,

        /// <summary>
        /// Недопустимое значение
        /// </summary>
        InvalidInput = 3,

        /// <summary>
        /// Число попыток закончилось
        /// </summary>
        OutOfAttempts = 4


    }
}
